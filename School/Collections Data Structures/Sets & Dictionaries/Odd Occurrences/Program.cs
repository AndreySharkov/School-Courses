namespace Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (string word in words)
            {
                string lowercaseWord = word.ToLower();
                if (wordCount.ContainsKey(lowercaseWord))
                {
                    wordCount[lowercaseWord]++;
                }
                else
                {
                    wordCount[lowercaseWord] = 1;
                }
            }
            foreach (var entry in wordCount)
            {
                if (entry.Value % 2 != 0)
                {
                    Console.Write(entry.Key + " ");
                }
            }
            Console.WriteLine();
        }
    }
}