namespace FashionBotique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse) as Stack<int>;
            int capacity = int.Parse(Console.ReadLine());
            int racks = 0;
            int currentRack = 0;
            while (stack.Count != 0)
            {
                if(currentRack + stack.Peek() <= capacity)
                {
                    currentRack += stack.Pop();
                }
                
            }
        }
    }
}