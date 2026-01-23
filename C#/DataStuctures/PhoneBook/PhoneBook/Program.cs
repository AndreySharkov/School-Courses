using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        OrderedMultiDictionary<string, string> phoneBook = 
            new OrderedMultiDictionary<string, string>(true); // true for allow duplicate values

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            string[] parts = line.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            string name = parts[0];
            string phoneNumber = parts[1];

            phoneBook.Add(name, phoneNumber);
        }

        foreach (var entry in phoneBook)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}