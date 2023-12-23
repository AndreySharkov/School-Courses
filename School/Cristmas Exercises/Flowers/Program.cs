namespace Flowers
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine()
                .Split(", ")
                .Select(int.Parse));

            Queue<int> roses = new Queue<int>(Console.ReadLine()
                .Split(", ")
                .Select(int.Parse));

            int wreathsCount = 0;
            int storedFlowers = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int sum = lilies.Peek() + roses.Peek();

                if (sum == 15)
                {
                    wreathsCount++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (sum > 15)
                {
                    lilies.Pop();
                    lilies.Push(lilies.Pop() - 2);
                    roses.Dequeue();
                }
                else
                {
                    storedFlowers += sum;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            int additionalWreaths = storedFlowers / 15;

            if (wreathsCount + additionalWreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCount + additionalWreaths} wreaths!");
            }
            else
            {
                int neededWreaths = 5 - (wreathsCount + additionalWreaths);
                Console.WriteLine($"You didn't make it, you need {neededWreaths} wreaths more!");
            }
        }
    }