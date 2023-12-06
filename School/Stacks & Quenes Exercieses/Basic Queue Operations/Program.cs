namespace Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] command = Console.ReadLine().Split(separator:" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for (int i = 0; i < command[0]; i++)
            {
                queue.Enqueue(list[i]);
            }
            for (int i = 1; i <= command[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(command[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                try
                {
                    Console.WriteLine(queue.Min());
                }
                catch
                {
                    Console.WriteLine(0);
                    return;
                }
            }

        }
    }
}