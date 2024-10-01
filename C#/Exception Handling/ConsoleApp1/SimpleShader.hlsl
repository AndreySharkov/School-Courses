﻿cbuffer ConstantBuffer : register(b0)
{
    matrix worldViewProj;
};

struct VS_INPUT
{
    float4 Pos : POSITION;
};

struct PS_INPUT
{
    float4 Pos : SV_POSITION;
};

PS_INPUT VS(VS_INPUT input)
{
    PS_INPUT output = (PS_INPUT)0;
    output.Pos = mul(input.Pos, worldViewProj);
    return output;
}

float4 PS(PS_INPUT input) : SV_Target
{
    return float4(1, 1, 1, 1);
}
