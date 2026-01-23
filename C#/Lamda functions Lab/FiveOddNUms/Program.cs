namespace FiveOddNUms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 != 0).ToList();
            list.Sort();
            list.Reverse();
            for (int i = 0; i < Math.Min(5, list.Count); i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
//Math.Min(5, list.Count)
//69, 7, 8, 12, 17, 70, 80, 15, 10, 19