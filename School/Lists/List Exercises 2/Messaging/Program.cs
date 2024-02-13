class Messaging
{
    static int CalculateSumOfDigits(int num)
    {
        return num.ToString().Sum(c => c - '0');
    }

    static string ProcessMessage(List<int> numbers, string message)
    {
        List<char> result = new List<char>();

        foreach (int num in numbers)
        {

            int digitSum = CalculateSumOfDigits(num);
            int index = digitSum % message.Length;
            result.Add(message[index]);

            message = message.Remove(index, 1);
        }

        return new string(result.ToArray());
    }

    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        string text = Console.ReadLine();
        Console.WriteLine(ProcessMessage(numbers, text));
        
    }
}
