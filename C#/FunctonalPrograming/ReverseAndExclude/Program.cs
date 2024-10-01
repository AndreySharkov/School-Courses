namespace ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int divider = int.Parse(Console.ReadLine());
            Func<List<int>, List<int>> ReverseAndEx = x => x.Where(x=> x % divider != 0).ToList();
            list = ReverseAndEx(list);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}