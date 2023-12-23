using System;

namespace ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string commandString = Console.ReadLine();
            while(commandString != "Retire")
            {
                string[] command = commandString.Split().ToArray();
                
                switch (command[0])
                {
                    case "Fire":
                        int fireIndex = int.Parse(command[1]);
                        int damage = int.Parse(command[2]);

                        if (fireIndex >= 0 && fireIndex < warship.Count)
                        {
                            warship[fireIndex] -= damage;

                            if (warship[fireIndex] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                        break;

                    case "Defend":
                        int defendStartIndex = int.Parse(command[1]);
                        int defendEndIndex = int.Parse(command[2]);
                        damage = int.Parse(command[3]);

                        if (defendStartIndex >= 0 && defendStartIndex < pirateShip.Count &&
                            defendEndIndex >= 0 && defendEndIndex < pirateShip.Count &&
                            defendStartIndex <= defendEndIndex)
                        {
                            for (int i = defendStartIndex; i <= defendEndIndex; i++)
                            {
                                pirateShip[i] -= damage;

                                if (pirateShip[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    return;
                                }
                            }
                        }
                        break;

                    case "Repair":
                        int repairIndex = int.Parse(command[1]);
                        int health = int.Parse(command[2]);

                        if (repairIndex >= 0 && repairIndex < pirateShip.Count)
                        {
                            pirateShip[repairIndex] = Math.Min(pirateShip[repairIndex] + health, maxHealth);
                        }
                        break;

                    case "Status":
                        int count = pirateShip.Count(s => s < maxHealth * 0.2);
                        Console.WriteLine($"{count} sections need repair.");
                        break;

                }
                commandString = Console.ReadLine();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warship.Sum()}");
        }
    }
}