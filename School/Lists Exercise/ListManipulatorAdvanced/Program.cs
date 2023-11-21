namespace ListManipulatorAdvanced
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> OriginalNumbers = numbers;
            string command;
            while ((command = Console.ReadLine())?.ToLower() != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                switch (action?.ToLower())
                {
                    case "contains":
                        int numberToCheck = int.Parse(commandArgs[1]);
                        Console.WriteLine(numbers.Contains(numberToCheck) ? "Yes" : "No such number");
                        break;

                    case "printeven":
                        Console.WriteLine(string.Join(" ", numbers.Where(num => num % 2 == 0)));
                        break;

                    case "printodd":
                        Console.WriteLine(string.Join(" ", numbers.Where(num => num % 2 != 0)));
                        break;

                    case "getsum":
                        Console.WriteLine(numbers.Sum());
                        break;

                    case "filter":
                        string condition = commandArgs[1];
                        int filterNumber = int.Parse(commandArgs[2]);
                        FilterNumbers(numbers, condition, filterNumber);                        
                        break;
                }
            }
            if (numbers != OriginalNumbers)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }


        static List<int> FilterNumbers(List<int> numbers, string condition, int filterNum)
        {
            List<int> result = numbers;
            switch (condition)
            {
                case "<":
                    result.RemoveAll(num => num < filterNum);
                    break;

                case ">":
                    result.RemoveAll(num => num > filterNum);
                    break;

                case ">=":
                    result.RemoveAll(num => num >= filterNum);
                    break;

                case "<=":
                    result.RemoveAll(num => num <= filterNum);
                    break;
            }
            foreach (int number in result)
            {
                numbers.Remove(number);
            }
            return numbers;
        }
    }
}