namespace Mid_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetMidChar(Console.ReadLine());
        }
        static void GetMidChar(string input)
        {
            if (input.Length % 2 == 0) Console.WriteLine(input[(input.Length / 2) - 1].ToString() + input[input.Length / 2].ToString());
            else Console.WriteLine(input[input.Length / 2]);           
        }
    }
}