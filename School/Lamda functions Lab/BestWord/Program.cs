namespace BestWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();

            string[] filteredWords = inputArray
                .Where(word => word.Contains("est"))
                .Select(word => word.ToUpper())
                .ToArray();

            string firstBWord = filteredWords.FirstOrDefault(word => word.Contains("B"));
            string lastBWord = filteredWords.LastOrDefault(word => word.Contains("B"));

            Console.WriteLine("First best word: " + (firstBWord ?? "No word containing 'B'"));
            Console.WriteLine("Last best word: " + (lastBWord ?? "No word containing 'B'"));
        }
    }
}