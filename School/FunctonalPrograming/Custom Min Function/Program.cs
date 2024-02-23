namespace Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, int> smallestNum = x => x.OrderBy(x => x).First();
            Console.WriteLine(smallestNum(list));
        }
    }
}