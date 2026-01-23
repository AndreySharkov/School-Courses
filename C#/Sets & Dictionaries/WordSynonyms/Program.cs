namespace WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonymsDictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonymsDictionary.ContainsKey(word))
                {
                    synonymsDictionary[word] = new List<string>();
                }

                synonymsDictionary[word].Add(synonym);
            }

            foreach (var kvp in synonymsDictionary)
            {
                string word = kvp.Key;
                List<string> synonyms = kvp.Value;

                Console.WriteLine($"{word} - {string.Join(", ", synonyms)}");
            }
        }
    }
}