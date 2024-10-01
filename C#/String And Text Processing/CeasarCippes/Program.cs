using System.Text;

namespace CeasarCippes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < text.Length; i++)
            {
                char ch = (char)(int)text[i];
                sb.Append((char)(ch + 3));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}