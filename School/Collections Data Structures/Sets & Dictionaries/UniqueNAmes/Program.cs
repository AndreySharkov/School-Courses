namespace UniqueNAmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int names = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for(int i = 0; i < names; i++)
            {
                set.Add(Console.ReadLine());
            }
            foreach(string name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}