class BombNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] bombParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int bombNumber = bombParameters[0];
        int power = bombParameters[1];

        DetonateBombs(numbers, bombNumber, power);

        int sum = numbers.Sum();
        Console.WriteLine(sum);
    }

    static void DetonateBombs(List<int> numbers, int bombNumber, int power)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombNumber)
            {
                int start = Math.Max(0, i - power);
                int end = Math.Min(i + power, numbers.Count - 1);

                for (int j = end; j >= start; j--)
                {
                    numbers.RemoveAt(j);
                }

                i = start - 1; 
            }
        }
    }
}
