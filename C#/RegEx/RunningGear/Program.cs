using System.Text.RegularExpressions;

namespace RunningGear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(<>)(?<name>\w+)(<>)(?<count>\d+)(--)(?<price>\d+.\d+)");
            Console.WriteLine("Gear bought:");
            double price = 0;
            while(input != "Run!")
            {
                Match match = regex.Match(input);
                string count = match.Groups["count"].Value;
                string price2 = match.Groups["price"].Value;
                if (count != "" || price2 != "")
                {
                    price += double.Parse(count) * double.Parse(price2);
                    Console.WriteLine(match.Groups["name"].Value.ToString());
                }               
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total cost: {price:f2}");
        }
    }
}