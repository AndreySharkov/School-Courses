namespace CashDecks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            int clients = int.Parse(Console.ReadLine());
            int hours = 0;
            while(clients > 0)
            {
                
                clients-=ints.Sum();
                hours++;
                if (hours % 3 == 0 && clients - ints.Sum() >= 0)
                {
                    hours++;
                }
            }
            
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}