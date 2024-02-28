namespace PredicateParty
{
    internal class Program
    {
        static string[] command;
        static List<string> people;

        static void Main(string[] args)
        {
            people = Console.ReadLine().Split().ToList();
            command = Console.ReadLine().Split();
            Predicate<string> Check;

            while (!command.Contains("Party!"))
            {
                int PeopleCount = people.Count();

                switch (command[1]?.ToLower())
                {
                    case "startswith":
                        Check = CheckStart;
                        break;
                    case "endswith":
                        Check = CheckEnd;
                        break;
                    case "length":
                        Check = CheckLength;
                        break;
                    default:
                        Check = CheckLength;
                        break;
                }

                if (command[0]?.ToLower() == "remove")
                {
                    for (int i = PeopleCount - 1; i >= 0; i--)
                    {
                        if (Check(people[i]))
                        {
                            people.RemoveAt(i);
                        }
                    }
                }
                else if (command[0]?.ToLower() == "double")
                {
                    for (int i = PeopleCount - 1; i >= 0; i--)
                    {
                        if (Check(people[i]))
                        {
                            people.Insert(i, people[i]);
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(people.Any()
                ? string.Join(", ", people) + " are going to the party!"
                : "Nobody is going to the party!");
        }

        static bool CheckStart(string person)
        {
            for (int i = 0; i < command[2].Length; i++)
            {
                if (!(person[i] == command[2][i]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckEnd(string person)
        {
            int personIndex = person.Length - command[2].Length;
            for (int i = 0; i < command[2].Length; i++)
            {
                if (!(person[personIndex + i] == command[2][i]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckLength(string person)
        {
            return person.Length == int.Parse(command[2]);
        }
    }
}
