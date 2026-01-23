SimpleCrypto crypto = new SimpleCrypto();

string msg = Console.ReadLine()!;
Console.WriteLine("msg = " + msg);
Console.WriteLine("hash(msg) = " + crypto.Hash(msg).ToString("X8"));
