namespace Games
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Squad> squads = new Dictionary<string, Squad>();
            HashSet<string> players = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string player = input[0];
                string squadName = input[1];

                if (squads.ContainsKey(squadName))
                {
                    Console.WriteLine("That squad name is already taken.");
                }
                else if (players.Contains(player))
                {
                    Console.WriteLine($"{player} cannot set up another squad.");
                }
                else
                {
                    squads[squadName] = new Squad { Creator = player };
                    players.Add(player);
                    Console.WriteLine($"{player} has successfully created a new squad: {squadName}");
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split('/');
                string player = input[0];
                string squadName = input[1];

                if (!squads.ContainsKey(squadName))
                {
                    Console.WriteLine("The squad doesn't exist.");
                }
                else if (players.Contains(player))
                {
                    Console.WriteLine("The player is already member of a squad.");
                }
                else
                {
                    squads[squadName].Members.Add(player);
                    players.Add(player);
                }
            }

            var orderedSquads = squads
                .Where(s => s.Value.Members.Count > 0)
                .OrderByDescending(s => s.Value.Members.Count)
                .ThenBy(s => s.Key);

            foreach (var squad in orderedSquads)
            {
                Console.WriteLine($"{squad.Key}");
                Console.WriteLine($"* {squad.Value.Creator}");
                foreach (var member in squad.Value.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"** {member}");
                }
            }

            string[] detachedSquads = squads
                .Where(s => s.Value.Members.Count == 0)
                .OrderBy(s => s.Key)
                .Select(s => s.Key).ToArray();


            Console.WriteLine("Squads to detach:");
            foreach (var squad in detachedSquads)
            {
                Console.WriteLine(squad);
            }

        }
    }

}
