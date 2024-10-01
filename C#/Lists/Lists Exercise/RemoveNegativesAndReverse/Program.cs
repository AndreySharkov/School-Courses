namespace RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(num => num < 0);

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        
    }
}