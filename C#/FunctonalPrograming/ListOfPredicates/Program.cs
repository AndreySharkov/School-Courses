namespace ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int currentNumber = 1; currentNumber <= upperLimit; currentNumber++)
            {
                bool canDivide = true;
                foreach (int divisor in divisors)
                {
                    if (currentNumber % divisor != 0)
                    {
                        canDivide = false;
                        break;
                    }
                }

                if (canDivide)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
    }
}