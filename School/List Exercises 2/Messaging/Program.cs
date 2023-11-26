using System;

namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<string> text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(ProcessMessage(numbers, text));
        }
        static string ProcessMessage(List<int> numbers, List<string> text)
        {
            
            List<int> result = new List<int>();
            string messages = "";
            foreach (int number in numbers)
            {
                int sum = 0;
                int num = number;
                num = Math.Abs(num);
                while (num > 0)
                { 
                    sum += num % 10;
                    num /= 10;
                }
                result.Add(num);
            }
            foreach (int n in result)
            {
                messages += messages + text[n];
            }


            return messages;
        }
    }
}