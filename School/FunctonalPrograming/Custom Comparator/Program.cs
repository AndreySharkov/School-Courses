using System.Security.Authentication;

namespace Custom_Comparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<int, int, int> Comparator = (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                    return -1;
                if (x % 2 != 0 && y % 2 == 0)
                    return 1;
                return x.CompareTo(y);
            };
            list.Sort((x, y) => Comparator(x, y));
            Console.WriteLine(string.Join(" ", list));
        }
    }
}