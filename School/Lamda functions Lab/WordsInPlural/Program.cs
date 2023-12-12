namespace WordsInPlural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            list.RemoveAt(0);
            list = list.Where(x => x.Length < 5).ToList();
            list = list.OrderBy(x => x).ToList() ;
            list = list.OrderBy(x => x.Length).ToList();
            
            foreach(string s in list)
            {
                Console.WriteLine(s + "s");
            }
        }
    }
}