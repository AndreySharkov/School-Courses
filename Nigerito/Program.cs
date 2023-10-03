using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Dobre doshul v Jerry Joke mashinata ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("3000");

        string[] jokes = new string[]
        {
            "Joke 1: Zashto jerry otide do magazina? Da kupi kompot s JERRESHY",
            "Joke 2: Koi e lubimiat film na Jerry? Jerrasic PARK!!!!",
            "Joke 3: Kakuv sladolet obicha Jerry? Gelatto!!!!!",
            "Joke 4: S kakvo si podpravq kafeto Jerry? Jerrinjifil!!!",
            "Joke 5: Koi sa lubimite promenlivi na Jerry? Intejerry!",
            "Joke 6: Ako Jerry beshe v star wars, koi shteshe da bude? Jedai!11",
            "Joke 7: Kakvi obuvki nosi Jerry? Jordanki!1",
            "Joke 8: Kak se kazva gajeto na Jerry? JENNIFER!!!",
            "Joke 9: Kakva e rolqta na Jerry v armiqta? JENERAL",
            "Joke 10: Kak shteshe da se kazva Jerry, ako beshe nisak? JUJERRY",
            "Joke 11: V kakvo Jerry si durzhi priborite? V CHEKMEJERRY!",
            "Joke 12: Kak se kazva bashtata na Jerry? JOSEPPE",
            "Joke 13: Jerry kakvo durji pod legloto si? TENJERRY!!1",
            "Joke 14: Kak se kazva zliqt bratovchet na Jerry? Valeri!",
            "Joke 15: Zashto vsichki momicheta si padat po Jerry? Zashtoto e mnogo Jentle s tqh!",
            "Joke 16: Koj e lubimiq Brawl stars mod na jerry Gem GRab",
        };

        List<int> usedIndexes = new List<int>();
        Random random = new Random();

        Console.WriteLine("\n\nNapishi 'jerry' za mazna shega (ili 'end' za izhod):");

        while (true)
        {
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "jerry")
            {
                int randomIndex;
                do
                {
                    randomIndex = random.Next(jokes.Length);
                } while (usedIndexes.Contains(randomIndex));

                usedIndexes.Add(randomIndex);

                string randomJoke = jokes[randomIndex];

                Console.WriteLine("\n" + randomJoke);
            }
            else if (userInput == "end")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. You must enter 'jerry' to get a joke or 'end' to quit.");
            }
        }
    }
}
