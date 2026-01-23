using System;
using System.Collections.Generic;
using System.Linq;

namespace Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> movieProfits = new Dictionary<string, double>();
            HashSet<string> canceledMovies = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArr = input.Split(":");
                if (commandArr[0] == "Canceled")
                {
                    string movieName = commandArr[1];
                    canceledMovies.Add(movieName);
                }
                else
                {
                    string movieName = commandArr[0];
                    double screeningProfit = double.Parse(commandArr[1]);
                    if (!canceledMovies.Contains(movieName))
                    {
                        if (!movieProfits.ContainsKey(movieName))
                        {
                            movieProfits[movieName] = 0;
                        }
                        movieProfits[movieName] += screeningProfit;
                    }
                }
            }
            foreach (var movie in movieProfits.OrderByDescending(m => m.Value))
            {
                Console.WriteLine($"{movie.Key} -> {movie.Value:F2}");
            }
        }
    }
}
