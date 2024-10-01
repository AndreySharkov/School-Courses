namespace Extract_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> upercase = x => x[0] == x.ToUpper()[0];
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(upercase).ToArray();
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}