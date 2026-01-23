using System;
using Wintellect.PowerCollections;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        OrderedBag<string> wordsBag = new OrderedBag<string>();

        for (int i = 0; i < n; i++)
        {
            wordsBag.Add(Console.ReadLine());
        }

        foreach (string word in wordsBag)
        {
            Console.WriteLine(word);
        }
    }
}

