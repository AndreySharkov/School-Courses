namespace MaximumLenghtOfNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string[], string[]> MaxLenghtOfName = x => x.Where(x => x.Length <= n).ToArray();
            names = MaxLenghtOfName(names);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}