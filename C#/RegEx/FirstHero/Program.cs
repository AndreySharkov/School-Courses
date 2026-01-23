using System.Text.RegularExpressions;

namespace FirstHero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, int> HeroPoints = new Dictionary<string, int>();
            foreach (string line in list)
            {
                if (!HeroPoints.ContainsKey(line))
                {
                    HeroPoints.Add(line, 0);
                }
            }
            string input = Console.ReadLine();
            Regex HeroNameRegex = new Regex(@"[a-zA-Z]");
            Regex PointsNumregex = new Regex(@"[\d]");

            while(input != "end")
            {
                MatchCollection heroName = HeroNameRegex.Matches(input);
                MatchCollection pointsNum = PointsNumregex.Matches(input);
                string hero = "";
                foreach (Match h in heroName)
                {
                    hero += h.ToString();
                }
                int points = 0;
                foreach (Match point in pointsNum)
                {
                    points += int.Parse(point.ToString());
                }
                if(HeroPoints.ContainsKey(hero))
                {
                    HeroPoints[hero] += points;
                }
                input = Console.ReadLine();
            }
            int counter = 0;
            foreach (var item in HeroPoints.OrderBy(kvp => kvp.Value).Reverse())
            {
                if(counter == 3)
                {
                    break;
                }
                Console.WriteLine(item.Key);
                counter++;
            }
            
        }
    }
}