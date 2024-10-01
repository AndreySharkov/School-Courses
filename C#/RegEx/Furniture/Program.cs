using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@">>(?<name>[\w]+)<<(?<price>[\d]+(?:\.\d+)?)!(?<count>[\d]+)");
            double totalPrice = 0;

            Console.WriteLine("Bought furniture:");
            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine(match.Groups["name"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    int count = int.Parse(match.Groups["count"].Value);
                    totalPrice += price * count;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spent: {totalPrice:F2}");
        }
    }
}
