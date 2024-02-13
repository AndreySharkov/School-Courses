namespace Song_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songsStr = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songsStr);
            
            while (queue.Count > 0)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                switch (command[0].ToLower())
                {
                    case "play":
                        queue.Dequeue();
                        break;
                    case "add":
                        command.RemoveAt(0);
                        if (queue.Contains(string.Join(" ", command)))
                        {
                            Console.WriteLine($"{string.Join(" ", command)} is already contained!");
                        }
                        else
                        {
                            queue.Enqueue(string.Join(" ", command));
                        }
                        
                        break;
                    case "show":
                        Console.WriteLine(string.Join(", ", queue));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
        
    }
}