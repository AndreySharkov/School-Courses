using System;
using System.Reflection;

namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                switch (action)
                {
                    case "Add":
                        numbers.Add(int.Parse(commandArgs[1]));
                        break;

                    case "Remove":
                        numbers.Remove(int.Parse(commandArgs[1]));
                        break;

                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(commandArgs[1]));
                        break;

                    case "Insert":
                        numbers.Insert(int.Parse(commandArgs[2]), int.Parse(commandArgs[1]));
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}