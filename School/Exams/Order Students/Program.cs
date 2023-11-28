namespace Order_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|", StringSplitOptions.TrimEntries).ToList();

            Console.WriteLine(string.Join(" ", ProcessedList(list)));
        }
        static List<int> ProcessedList(List<string> list)
        {
            list.Reverse();
            List<int> result = new List<int>();
            foreach (string s in list)
            {
                result.AddRange(s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            return result;
            
        }
    }
}