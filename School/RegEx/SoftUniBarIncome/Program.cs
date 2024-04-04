using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalIncome = 0;
            Regex orderRegex = new Regex(@"%([A-Z][a-z]+)%|<(\w+)>|\|(\d+)\||(\d+\.\d+)\$|\w+?(\d+)\$");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    Console.WriteLine($"Total income: {totalIncome:f2}");
                    break;
                }

                MatchCollection matches = orderRegex.Matches(input);

                
                string customerName = matches[0].Groups[1].Value;
                string product = matches[1].Groups[2].Value;
                int count = int.Parse(matches[2].Groups[3].Value);
                double price = 0;
                try
                {
                    price = double.Parse(matches[3].Groups[4].Value);
                }
                catch
                {
                    price = double.Parse(matches[3].Groups[5].Value);
                }

                    double totalPrice = count * price;
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                
            }

        }
    }
}