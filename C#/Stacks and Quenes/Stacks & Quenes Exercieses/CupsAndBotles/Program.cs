namespace CupsAndBotles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            
            int wastedLittersOfWater = 0;

            while (cups.Any() && bottles.Any())
            {
                int currentCup = cups.Peek();
                int currentBottle = bottles.Pop();

                if (currentBottle >= currentCup)
                {
                    wastedLittersOfWater += currentBottle - currentCup;
                    cups.Dequeue();
                }
                else
                {
                    
                    while (currentCup <= bottles.Peek())
                    {
                        
                        if (currentBottle >= currentCup)
                        {
                            wastedLittersOfWater += currentBottle - currentCup;
                            cups.Dequeue();
                            break;
                        }
                        currentCup -= bottles.Pop();

                    }
                }
                
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles.Count)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
        }
    }
}