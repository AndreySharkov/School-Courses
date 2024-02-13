namespace FashionBotique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] clothes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<int> stack = new Stack<int>(clothes.Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int racks = 0;
            int currentRack = 0;
            while (stack.Count != 0)
            {
                if(currentRack + stack.Peek() <= capacity)
                {
                    currentRack += stack.Pop();
                }
                else
                {
                    currentRack = stack.Pop();
                    racks++;
                }

            }
            racks++;
            Console.WriteLine(racks);
        }
    }
}