using System;

namespace AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            
            var keyValuePairs = new Dictionary<string, List<decimal>>();
            for(int i = 0; i < input; i++)
            {
                string[] grade = Console.ReadLine().Split();
                if (!keyValuePairs.ContainsKey(grade[0]))
                {
                    keyValuePairs.Add(grade[0], new List<decimal>()) ;
                    keyValuePairs[grade[0]].Add(decimal.Parse(grade[1]));
                }
                else
                {
                    keyValuePairs[grade[0]].Add(decimal.Parse(grade[1]));
                }
            }
            
            foreach (var key in keyValuePairs.Keys)
            {
                Console.Write($"{key} -> ");
                foreach (var value in keyValuePairs[key])
                {
                    Console.Write($"{value:f2} ");
                }
                Console.Write($"(avg: {keyValuePairs[key].Average():f2})");
                Console.WriteLine();
            }
        }
    }
}