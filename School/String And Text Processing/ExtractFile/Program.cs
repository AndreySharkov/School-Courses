namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] FilePath = Console.ReadLine().Split("\\");
            string[] files = FilePath[FilePath.Length - 1].Split(".");
            Console.WriteLine($"File name: {files[0]}");
            Console.WriteLine($"File extension: {files[1]}");
        }
    }
}