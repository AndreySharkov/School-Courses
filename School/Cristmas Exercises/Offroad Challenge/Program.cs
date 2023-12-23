namespace Offroad_Challenge
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> initialFuel = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> consumptionIndexes = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> neededFuel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int altitude = 1;

            while (initialFuel.Any() && consumptionIndexes.Any() && neededFuel.Any())
            {
                int currentFuel = initialFuel.Pop();
                int consumptionIndex = consumptionIndexes.Dequeue();
                int requiredFuel = neededFuel.Dequeue();

                int remainingFuel = currentFuel - consumptionIndex;

                if (remainingFuel >= requiredFuel)
                {
                    Console.WriteLine($"John has reached: Altitude {altitude}");
                    altitude++;
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {altitude}");
                    if (altitude > 1)
                    {
                        Console.WriteLine($"John failed to reach the top.\nReached altitudes: Altitude {string.Join(", Altitude ", Enumerable.Range(1, altitude - 1))}");
                    }
                    else
                    {
                        Console.WriteLine("John failed to reach the top.\nJohn didn't reach any altitude.");
                    }
                    return;
                }
            }
            Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
        }
    }
}