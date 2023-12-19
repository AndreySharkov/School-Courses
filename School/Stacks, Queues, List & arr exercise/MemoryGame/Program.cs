namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();
            string CommandArray = Console.ReadLine();
            int moves = 1;
            while (CommandArray != "end")
            {
                int[] commandArray = CommandArray.Split().Select(int.Parse).ToArray();
                if (commandArray[1] == commandArray[0] ||  commandArray[0] < 0 || commandArray[1] < 0)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    nums.Insert(nums.Count / 2, "-" + moves + "a");
                    nums.Insert(nums.Count / 2, "-" + moves + "a");
                    
                }
                else if (nums[commandArray[0]] == nums[commandArray[1]])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {nums[commandArray[0]]}!");
                    
                    nums.RemoveAt(Math.Max(commandArray[1], commandArray[0]));
                    nums.RemoveAt(Math.Min(commandArray[1], commandArray[0]));
                    
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
                moves++;
                CommandArray = Console.ReadLine();

            }
            if (nums.Any())
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", nums));
            }
            else
            {
                Console.WriteLine($"You have won in {moves} turns!");
            }
        }
    }
}