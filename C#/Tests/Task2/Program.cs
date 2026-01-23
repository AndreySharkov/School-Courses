namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FoodQuantity = int.Parse(Console.ReadLine());
            Queue<int> OrderQuantity = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int biggestOrder = 0;
            while(OrderQuantity.Count > 0)
            {
                int current = OrderQuantity.Peek();
                biggestOrder = ManageBiggestOrder(current, biggestOrder);
                if (current > FoodQuantity)
                {
                    Console.WriteLine(biggestOrder);
                    Console.WriteLine($"Orders left: {string.Join(" ", OrderQuantity)}");
                    return;
                }
                FoodQuantity -=current;
                OrderQuantity.Dequeue();
            }
            Console.WriteLine(biggestOrder);
            Console.WriteLine("All orders are completed");
        }
        static int ManageBiggestOrder(int current, int biggestOrder)
        {
            if (current > biggestOrder)
            {
                biggestOrder = current;
            }
            return biggestOrder;
        }
        
    }
}