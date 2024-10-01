using System.Linq;

namespace WordCoiunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textPath = @"..\..\..\Files\text.txt";
            string wordsPath = @"..\..\..\Files\words.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(textPath, wordsPath, outputPath);
        }
        static void CalculateWordCounts(string text, string wordsFilePath,
        string outputFilePath)
        {
            using (var wordsReader = new StreamReader(wordsFilePath))
            {
                using (var reader = new StreamReader(text))
                {
                    string[] words = wordsReader.ReadToEnd().Split().ToArray();                    
                    foreach (string word in words)
                    {
                        string[] textWords = reader.ReadToEnd().Split();
                        int counter = 0;
                        foreach (string wordReader in textWords)
                        {
                            
                            if (word == wordReader)
                            {
                                counter++;
                            }
                        }
                        Console.WriteLine($"{word} - {counter}");
                    }
                }
            }
            
        }
    }
    
}
