using System;
using System.Collections.Generic;
using System.Linq;

namespace Classification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var candidates = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(":");
                if (input.Contains("the contests are ended"))
                {
                    break;
                }
                contests.Add(input[0], input[1]);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split("=>");
                if (input.Contains("the submissions are ended"))
                {
                    break;
                }

                string contest = input[0];
                string password = input[1];
                string candidateName = input[2];
                int points = int.Parse(input[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!candidates.ContainsKey(candidateName))
                    {
                        candidates.Add(candidateName, new Dictionary<string, int>());
                    }

                    if (!candidates[candidateName].ContainsKey(contest) || candidates[candidateName][contest] < points)
                    {
                        candidates[candidateName][contest] = points;
                    }
                }
            }

            int maxPoints = 0;
            string bestCandidate = "";
            foreach (var candidate in candidates)
            {
                int totalPoints = candidate.Value.Values.Sum();
                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    bestCandidate = candidate.Key;
                }
            }

            
            Console.WriteLine($"Candidate number one is {bestCandidate} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");

            
            foreach (var candidate in candidates.OrderBy(x => x.Key))
            {
                Console.WriteLine(candidate.Key);
                foreach (var contestPoints in candidate.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestPoints.Key} -> {contestPoints.Value}");
                }
            }
        }
    }
}
