    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    namespace Reflections
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Regex regex = new Regex(@"([@#])([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1");
                string input = Console.ReadLine();
                MatchCollection matches = regex.Matches(input);
                if (matches.Count == 0)
                {
                    Console.WriteLine("No word pairs found!");
                    
                }
                else
                {
                    Console.WriteLine($"{matches.Count} word pairs found!");
                }
                List<string> mirrorWords = new List<string>();
                foreach (Match match in matches)
                {
                    string word1 = match.Groups[2].Value;
                    string word2 = match.Groups[3].Value;

                    char[] wordArray = word1.ToCharArray();
                    Array.Reverse(wordArray);
                    string reversedWord1 = new string(wordArray);
                    if (reversedWord1 == word2)
                    {
                        mirrorWords.Add($"{word1} <=> {word2}");
                    }
                }
                if (mirrorWords.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
            }
        }
    }
