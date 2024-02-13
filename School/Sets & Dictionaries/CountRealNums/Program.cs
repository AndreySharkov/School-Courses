namespace CountRealNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubles = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var counts = new SortedDictionary<int, double>();
            foreach (int i in doubles)
            {
                if(counts.ContainsKey(i))
                {
                    counts[i]++;
                }
                else
                {
                    counts.Add(i, 1);
                }
            }
            foreach (var i in counts)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }
        }
    }
}