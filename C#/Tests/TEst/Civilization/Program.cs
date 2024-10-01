using System;
using System.Collections.Generic;
using System.Linq;

class CivilizationGame
{
    static void Main()
    {
        var campuses = new SortedDictionary<string, (int facilities, int scienceScore)>();
        while (true)
        {
            string line = Console.ReadLine().Trim();
            if (line == "Build")
            {
                break;
            }

            var parts = line.Split("---");
            string city = parts[0];
            int facilities = int.Parse(parts[1]);
            int scienceScore = int.Parse(parts[2]);

            if (campuses.ContainsKey(city))
            {
                campuses[city] = (campuses[city].facilities + facilities, campuses[city].scienceScore + scienceScore);
            }
            else
            {
                campuses.Add(city, (facilities, scienceScore));
            }
        }

        while (true)
        {
            string eventLine = Console.ReadLine().Trim();
            if (eventLine == "End")
                break;

            var eventParts = eventLine.Split(">>");
            string action = eventParts[0];
            string city = eventParts[1];

            if (action == "Sabotage")
            {
                int facilities = int.Parse(eventParts[2]);
                int scienceScore = int.Parse(eventParts[3]);

                if (campuses.ContainsKey(city))
                {
                    campuses[city] = (campuses[city].facilities - facilities, campuses[city].scienceScore - scienceScore);

                    Console.WriteLine($"Campus in {city} is sabotaged! You now have {facilities} less functioning facilities and decreased with {scienceScore} science score.");

                    if (campuses[city].facilities <= 0 || campuses[city].scienceScore <= 0)
                    {
                        campuses.Remove(city);
                        Console.WriteLine($"The campus in {city} has been destroyed!");
                    }
                }
            }
            else if (action == "Boost")
            {
                int scienceScore = int.Parse(eventParts[2]);

                if (scienceScore < 0)
                {
                    Console.WriteLine("Score cannot be boosted with a negative amount!");
                }
                else if (campuses.ContainsKey(city))
                {
                    campuses[city] = (campuses[city].facilities, campuses[city].scienceScore + scienceScore);
                    Console.WriteLine($"{scienceScore} science boost added to the Campus in {city}. The Campus now has total science score: {campuses[city].scienceScore}.");
                }
            }
        }

        if (campuses.Count > 0)
        {
            var sortedCampuses = campuses.OrderByDescending(c => c.Value.scienceScore);

            Console.WriteLine($"You have {sortedCampuses.Count()} Campuses discovering science:");
            foreach (var campus in sortedCampuses)
            {
                Console.WriteLine($"{campus.Key} -> Facilities: {campus.Value.facilities}, Science score: {campus.Value.scienceScore}");
            }
        }
        else
        {
            Console.WriteLine("Pity! All Campuses have been sabotaged and destroyed!");
        }
    }
}
