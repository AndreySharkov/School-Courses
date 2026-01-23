using System.Text;

namespace Find_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Console.WriteLine($"{input.Substring(input.IndexOf('@') + 1, input.IndexOf('|') - input.IndexOf('@') - 1)} is {input.Substring(input.IndexOf('#') + 1, input.IndexOf('*') - input.IndexOf('#') - 1)} years old.");
            }
        }
    }
}