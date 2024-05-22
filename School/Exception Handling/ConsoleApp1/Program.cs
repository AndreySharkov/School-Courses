using System;
using System.Numerics;
using SharpDX;
using SharpDX.D3DCompiler;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using SharpDX.Windows;
using Buffer = SharpDX.Direct3D11.Buffer;
using Device = SharpDX.Direct3D11.Device;

class Program
{
    [STAThread]
    static void Main()
    {
        var form = new RenderForm("SharpDX - Simple Cube");
        var description = new SwapChainDescription()
        {
            BufferCount = 1,
            ModeDescription = new ModeDescription(800, 600, new Rational(60, 1), Format.R8G8B8A8_UNorm),
            IsWindowed = true,
            OutputHandle = form.Handle,
            SampleDescription = new SampleDescription(1, 0),
            SwapEffect = SwapEffect.Discard,
            Usage = Usage.RenderTargetOutput
        };

        Device device;
        SwapChain swapChain;
        Device.CreateWithSwapChain(DriverType.Hardware, DeviceCreationFlags.None, description, out device, out swapChain);

        var context = device.ImmediateContext;
        var factory = swapChain.GetParent<Factory>();
        factory.MakeWindowAssociation(form.Handle, WindowAssociationFlags.IgnoreAll);

        var backBuffer = Texture2D.FromSwapChain<Texture2D>(swapChain, 0);
        var renderView = new RenderTargetView(device, backBuffer);

        var depthBuffer = new Texture2D(device, new Texture2DDescription()
        {
            Format = Format.D32_Float,
            ArraySize = 1,
            MipLevels = 1,
            Width = 800,
            Height = 600,
            SampleDescription = new SampleDescription(1, 0),
            Usage = ResourceUsage.Default,
            BindFlags = BindFlags.DepthStencil,
            CpuAccessFlags = CpuAccessFlags.None,
            OptionFlags = ResourceOptionFlags.None
        });

        var depthView = new DepthStencilView(device, depthBuffer);

        context.Rasterizer.SetViewport(new Viewport(0, 0, 800, 600));
        context.OutputMerger.SetTargets(depthView, renderView);

        var vertices = Buffer.Create(device, BindFlags.VertexBuffer, new[]
        {
            new Vector4(-1.0f, -1.0f, -1.0f, 1.0f), new Vector4(-1.0f,  1.0f, -1.0f, 1.0f),
            new Vector4( 1.0f,  1.0f, -1.0f, 1.0f), new Vector4( 1.0f, -1.0f, -1.0f, 1.0f),
            new Vector4(-1.0f, -1.0f,  1.0f, 1.0f), new Vector4(-1.0f,  1.0f,  1.0f, 1.0f),
            new Vector4( 1.0f,  1.0f,  1.0f, 1.0f), new Vector4( 1.0f, -1.0f,  1.0f, 1.0f)
        });

        var indices = Buffer.Create(device, BindFlags.IndexBuffer, new ushort[]
        {
            0, 1, 2, 0, 2, 3,
            4, 6, 5, 4, 7, 6,
            4, 5, 1, 4, 1, 0,
            3, 2, 6, 3, 6, 7,
            1, 5, 6, 1, 6, 2,
            4, 0, 3, 4, 3, 7
        });

        var vertexShaderByteCode = ShaderBytecode.CompileFromFile("SimpleShader.hlsl", "VS", "vs_4_0");
        var vertexShader = new VertexShader(device, vertexShaderByteCode);

        var pixelShaderByteCode = ShaderBytecode.CompileFromFile("SimpleShader.hlsl", "PS", "ps_4_0");
        var pixelShader = new PixelShader(device, pixelShaderByteCode);

        var layout = new InputLayout(device, ShaderSignature.GetInputSignature(vertexShaderByteCode), new[]
        {
            new InputElement("SV_Position", 0, Format.R32G32B32A32_Float, 0, 0)
        });

        context.InputAssembler.InputLayout = layout;
        context.InputAssembler.PrimitiveTopology = PrimitiveTopology.TriangleList;
        context.InputAssembler.SetVertexBuffers(0, new VertexBufferBinding(vertices, Utilities.SizeOf<Vector4>(), 0));
        context.InputAssembler.SetIndexBuffer(indices, Format.R16_UInt, 0);

        context.VertexShader.Set(vertexShader);
        context.PixelShader.Set(pixelShader);

        var clock = new System.Diagnostics.Stopwatch();
        clock.Start();

        RenderLoop.Run(form, () =>
        {
            var time = (float)clock.Elapsed.TotalSeconds;

            context.ClearRenderTargetView(renderView, new Color4(0.5f, 0.5f, 0.5f));
            context.ClearDepthStencilView(depthView, DepthStencilClearFlags.Depth, 1.0f, 0);

            var worldViewProj = Matrix.RotationY(time) * Matrix.LookAtLH(new Vector3(0, 2, -5), new Vector3(0, 0, 0), Vector3.UnitY) * Matrix.PerspectiveFovLH((float)Math.PI / 4.0f, 800f / 600f, 0.1f, 100.0f);

            var constantBuffer = new Buffer(device, Utilities.SizeOf<Matrix>(), ResourceUsage.Default, BindFlags.ConstantBuffer, CpuAccessFlags.None, ResourceOptionFlags.None, 0);
            context.UpdateSubresource(ref worldViewProj, constantBuffer);
            context.VertexShader.SetConstantBuffer(0, constantBuffer);

            context.DrawIndexed(36, 0, 0);
            swapChain.Present(1, PresentFlags.None);
        });

        vertexShaderByteCode.Dispose();
        vertexShader.Dispose();
        pixelShaderByteCode.Dispose();
        pixelShader.Dispose();
        layout.Dispose();
        vertices.Dispose();
        indices.Dispose();
        renderView.Dispose();
        depthView.Dispose();
        backBuffer.Dispose();
        depthBuffer.Dispose();
        swapChain.Dispose();
        device.Dispose();
        context.Dispose();
    }
}
