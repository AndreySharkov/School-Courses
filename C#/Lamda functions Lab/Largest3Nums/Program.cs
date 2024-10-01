namespace Largest3Nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>  nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sorted = nums.OrderBy(x => x).ToList();
            sorted.Reverse();
            int count = Math.Min(3, sorted.Count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(sorted[i] + " ");
            }
        }
    }
}