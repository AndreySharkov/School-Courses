namespace Mu_Online
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> moves = Console.ReadLine().Split("|").ToList();
            int health = 100;
            int bitcoins = 0;
            int rooms = 0;
            int WeirdHEalth;
            foreach (string move in moves)
            {
                string[] moveArr = move.Split().ToArray();
                rooms++;
                if (moveArr[0] == "potion")
                {
                    health += int.Parse(moveArr[1]);
                    WeirdHEalth = health;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    


                    Console.WriteLine($"You healed for {int.Parse(moveArr[1]) - (WeirdHEalth - health)} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (moveArr[0] == "chest")
                {
                    bitcoins  += int.Parse(moveArr[1]);
                    Console.WriteLine($"You found {int.Parse(moveArr[1])} bitcoins.");
                }
                else
                {
                    health -= int.Parse(moveArr[1]);
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {moveArr[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {moveArr[0]}.");
                        Console.WriteLine($"Best room: {rooms}");
                        return;
                    }
                }
                

            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");

        }
    }
}