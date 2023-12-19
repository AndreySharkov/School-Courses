namespace CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command;
            int battlesWon = 0;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                int commandInt = int.Parse(command);
                
                
                if(energy < commandInt)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and 0 energy");
                    return;
                }
                energy -= commandInt;
                battlesWon++;
                if (battlesWon % 3 == 0)
                {
                    energy += battlesWon;
                }


            }
            Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");

        }
    }
}