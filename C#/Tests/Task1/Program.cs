namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = integers[0];
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            Stack<int> stack = new Stack<int>(arr);
                  
            for (int i = 0; i < integers[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(integers[2]))
            {
                Console.WriteLine("found");
            }
            else if (stack.Any())
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine("nothing found");
            }

        }
    }
}


