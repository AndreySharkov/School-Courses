using System;
using System.Linq;

namespace Work_Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calendar = Console.ReadLine();
            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] commandArr = input.Split(":").ToArray();
                if (commandArr[0].ToLower() == "remove event")
                {
                    int startIndex = int.Parse(commandArr[1]);
                    int endIndex = int.Parse(commandArr[2]);

                    if (startIndex >= 0 && endIndex < calendar.Length && startIndex <= endIndex)
                    {
                        calendar = calendar.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                else if (commandArr[0].ToLower() == "add event")
                {
                    int index = int.Parse(commandArr[1]);
                    string eventToAdd = commandArr[2];

                    if (index >= 0 && index <= calendar.Length)
                    {
                        calendar = calendar.Insert(index, eventToAdd);
                    }
                }
                else if (commandArr[0].ToLower() == "switch")
                {
                    string oldString = commandArr[1];
                    string newString = commandArr[2];

                    if (calendar.Contains(oldString))
                    {
                        calendar = calendar.Replace(oldString, newString);
                    }
                }

                Console.WriteLine(calendar);
                input = Console.ReadLine();
            }
            Console.WriteLine($"Your work calendar for the day is ready: {calendar}");
        }
    }
}
