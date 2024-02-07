namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NewText(text, n));
        }
        static string NewText(string text, double n)
        { 

            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += text;
            }

            return result;

        }
    }
}