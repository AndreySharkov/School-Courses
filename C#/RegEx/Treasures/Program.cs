using System.Text.RegularExpressions;

namespace Treasures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex("@(?<metali>[\\w]+)[|]|\\#(?<gem>[\\w]+)\\*");
            Match treasures = regex.Match(input);
            Console.WriteLine($"Found hidden {(treasures.Groups["metali"].Value == "" ? treasures.Groups["gem"].Value : treasures.Groups["metali"].Value)} and {(treasures.Groups["gem"].Value)} in the cave.");
        }
    }
}