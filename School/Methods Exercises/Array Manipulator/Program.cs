using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        List<int> array = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split();

            if (command[0] == "exchange")
            {
                int index = int.Parse(command[1]);
                if (index < 0 || index >= array.Count)
                {
                    Console.WriteLine("Invalid index");
                    continue;
                }

                array = Exchange(array, index);
            }
            else if (command[0] == "max" || command[0] == "min")
            {
                string type = command[1];
                int index = GetMaxMinIndex(array, type);
                if (index == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(index);
                }
            }
            else if (command[0] == "first" || command[0] == "last")
            {
                string type = command[2];
                int count = int.Parse(command[1]);

                if (count > array.Count)
                {
                    Console.WriteLine("Invalid count");
                    continue;
                }

                List<int> result = GetFirstLastElements(array, count, type, command[0] == "first");
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

    static List<int> Exchange(List<int> array, int index)
    {
        List<int> firstPart = array.Take(index + 1).ToList();
        List<int> secondPart = array.Skip(index + 1).ToList();
        return secondPart.Concat(firstPart).ToList();
    }

    static int GetMaxMinIndex(List<int> array, string type)
    {
        List<int> filteredArray = type == "even" ? array.Where(x => x % 2 == 0).ToList() : array.Where(x => x % 2 != 0).ToList();

        if (filteredArray.Count == 0)
        {
            return -1;
        }

        int extremum = type == "even" ? filteredArray.Max() : filteredArray.Min();
        return array.LastIndexOf(extremum);
    }

    static List<int> GetFirstLastElements(List<int> array, int count, string type, bool isFirst)
    {
        List<int> filteredArray = isFirst ? array.Where(x => x % 2 == (type == "even" ? 0 : 1)).ToList() : array.Where(x => x % 2 == (type == "even" ? 0 : 1)).ToList();

        if (filteredArray.Count == 0)
        {
            return new List<int>();
        }

        return isFirst ? filteredArray.Take(count).ToList() : filteredArray.Skip(filteredArray.Count - count).ToList();
    }
}
