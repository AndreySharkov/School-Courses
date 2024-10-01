namespace Value_Seeker_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            int value = 0;
            while (true)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("First set is empty");
                    break;
                }
                else if(stack.Count == 0)
                {
                    Console.WriteLine("Second set is empty");
                    break;
                }
                if((stack.Peek() + queue.Peek()) % 2 != 0)
                {
                    queue.Enqueue(stack.Pop());
                }
                else
                {
                    value += stack.Pop() + queue.Dequeue();
                }

            }
            if(value >= 100)
            {
                Console.WriteLine($"Your bets were amazing! Value: {value}");
            }
            else
            {
                Console.WriteLine($"Your bets were poor. Value: {value}");
            }
        }
    }
}
