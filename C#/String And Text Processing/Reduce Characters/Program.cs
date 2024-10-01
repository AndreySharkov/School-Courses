using System.ComponentModel;
using System.Text;

namespace Reduce_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word  = Console.ReadLine();
            string vowels = "aeiou";
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < word.Length; i++)
            {
                if (!vowels.Contains(word[i]))
                {
                    stringBuilder.Append(word[i]);
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}