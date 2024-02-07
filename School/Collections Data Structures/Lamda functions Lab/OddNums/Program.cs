namespace OddNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (int num in nums)
            {
                string Jerry = num % 2 != 0 ? "True" : "False";
                Console.WriteLine($"{num} is odd - {Jerry}");
            }
        }
    }
}