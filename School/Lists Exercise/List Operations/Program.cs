
class ListOperations
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command;
        while ((command = Console.ReadLine()?.ToLower()) != "end")
        {
            string[] tokens = command.Split();
            string action = tokens[0];

            switch (action?.ToLower())
            {
                case "add":
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd);
                    break;

                case "insert":
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    if (IsValidIndex(indexToInsert, numbers.Count))
                    {
                        numbers.Insert(indexToInsert, numberToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case "remove":
                    int indexToRemove = int.Parse(tokens[1]);
                    if (IsValidIndex(indexToRemove, numbers.Count))
                    {
                        numbers.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case "shift":
                    int count = int.Parse(tokens[2]);
                    if (tokens[1] == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (tokens[1] == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }

    static void ShiftLeft(List<int> numbers, int count)
    {
        for (int i = 0; i < count % numbers.Count; i++)
        {
            int firstNumber = numbers[0];
            numbers.RemoveAt(0);
            numbers.Add(firstNumber);
        }
    }

    static void ShiftRight(List<int> numbers, int count)
    {
        for (int i = 0; i < count % numbers.Count; i++)
        {
            int lastNumber = numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
            numbers.Insert(0, lastNumber);
        }
    }

    static bool IsValidIndex(int index, int count)
    {
        return index >= 0 && index < count;
    }
}
