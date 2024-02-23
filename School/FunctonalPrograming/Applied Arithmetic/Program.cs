using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Action<List<int>> apply = null;

            while (true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        apply = Add;
                        break;
                    case "subtract":
                        apply = Subtract;
                        break;
                    case "multiply":
                        apply = Multiply;
                        break;
                    case "print":
                        apply = Print;
                        break;
                }

                if (command == "end")
                {
                    break;
                }

                apply?.Invoke(list);
            }
        }

        private static void Add(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += 1;
            }
        }

        private static void Subtract(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] -= 1;
            }
        }

        private static void Multiply(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] *= 2;
            }
        }

        private static void Print(List<int> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
