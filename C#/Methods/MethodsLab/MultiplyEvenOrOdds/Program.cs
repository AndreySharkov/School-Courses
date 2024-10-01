namespace MultiplyEvenOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        public static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            return evenSum * oddSum;
        }

        public static int GetSumOfEvenDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }

        public static int GetSumOfOddDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}