namespace Names
{
    internal class Program
    {
        static bool IsValidName(string name)
        {
            return name.Length >= 3 && char.IsUpper(name[0]) && !name.Any(char.IsDigit);
        }

        static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void PrintAsciiValues(string name)
        {
            foreach (char c in name)
            {
                Console.WriteLine((int)c + 10);
            }
        }

        static void PrintInvalidMessage()
        {
            Console.WriteLine("Invalid name!");
        }

        static void Main()
        {
            
            string userInput = Console.ReadLine();

            if (IsValidName(userInput))
            {
                PrintGreeting(userInput);
                PrintAsciiValues(userInput);
            }
            else
            {
                PrintInvalidMessage();
            }
        }
    }
}