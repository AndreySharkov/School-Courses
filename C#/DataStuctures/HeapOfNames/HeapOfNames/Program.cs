using System;
using MoreComplexDataStructures;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of names:");
        int n = int.Parse(Console.ReadLine());

        MaxHeap<string> nameHeap = new MaxHeap<string>();

        Console.WriteLine($"Enter {n} names:");
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            nameHeap.Insert(name);
        }

        Console.WriteLine("\nNames in descending order:");
        while (nameHeap.Count > 0)
        {
            Console.WriteLine(nameHeap.ExtractMax());
        }
    }
}
