using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };
            int[] num2 = num.Select(x => x / 2).ToArray();
        }
    }
}