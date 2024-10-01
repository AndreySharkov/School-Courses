namespace ReadAndCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var minerals = new SortedDictionary<string, int>();
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "mineral")
                {
                    if (!minerals.ContainsKey(input[1]))
                    {
                        minerals.Add(input[1], 0);
                        minerals[input[1]]++;
                    }
                    else
                    {
                        minerals[input[1]]++;
                    }
                }
            }
            foreach(string key in minerals.Keys)
            {
                Console.WriteLine($"{key}: {minerals[key]} time/s");
            }
            
        }
    }
}