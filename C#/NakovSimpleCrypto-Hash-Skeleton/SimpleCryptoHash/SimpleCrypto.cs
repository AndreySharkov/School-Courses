using System.Text;

/// <summary>
/// Simple 32-bit crypto hashing and symmetric encryption algorithms,
/// based on a simple Merkle–Damgård construction with 32-bit blocks:
/// https://en.wikipedia.org/wiki/Merkle%E2%80%93Damg%C3%A5rd_construction
/// https://justcryptography.com/merkle-damgard-construction/?utm_content=cmp-true
/// 
/// Note: This library is not cryptographically secure. Don't use in production!
/// For educational purposes only: to demonstrate some ideas about
/// how hashing and symmetric encryption algorithms may be designed.
/// </summary>
public class SimpleCrypto : IHash
{
    // Calculates a hash code by a simple 32-bit Merkle–Damgård construction
    public uint Hash(string msg)
    {
        throw new NotImplementedException();
    }

    public string PadMsg(string msg, int blockSize = sizeof(uint), char padLetter = '*')
    {
        throw new NotImplementedException();
    }

    public uint RotateLeft(uint value, int bits)
    {
        throw new NotImplementedException();
    }

    public uint RotateRight(uint value, int bits)
    {
        throw new NotImplementedException();
    }

    // Compressions function
    public uint MixBlocks(uint block, uint state)
    {
        throw new NotImplementedException();
    }
}
