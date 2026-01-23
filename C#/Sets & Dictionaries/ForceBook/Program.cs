using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> dictionary = new SortedDictionary<string, List<string>>();
            string inputString;

            while ((inputString = Console.ReadLine()) != "Lumpawaroo")
            {
                if (inputString.Contains("|"))
                {
                    string side = inputString.Split('|')[0].Trim();
                    string user = inputString.Split('|')[1].Trim();

                    if (!dictionary.ContainsKey(side))
                    {
                        dictionary.Add(side, new List<string>());
                    }

                    dictionary[side].Add(user);
                }
                else if (inputString.Contains("->"))
                {
                    string side = inputString.Split("->")[1].Trim();
                    string user = inputString.Split("->")[0].Trim();

                    Console.WriteLine($"{user} joins the {side} side!");

                    foreach (var key in dictionary.Keys)
                    {
                        dictionary[key].Remove(user);
                    }

                    if (!dictionary.ContainsKey(side))
                    {
                        dictionary.Add(side, new List<string>());
                    }

                    dictionary[side].Add(user);
                }
            }

            foreach (var key in dictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (key.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {key.Key}, Members: {key.Value.Count}");
                    foreach (var value in key.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {value}");
                    }
                }
            }
        }
    }
}
