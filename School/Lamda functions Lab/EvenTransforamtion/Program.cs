namespace EvenTransforamtion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x % 2 ==0).Select(x=>x + 1).ToList();
            list.Sort();            
            Console.WriteLine(string.Join(" ", list));
        }
    }
}