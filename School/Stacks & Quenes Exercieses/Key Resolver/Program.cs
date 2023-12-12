namespace Key_Resolver
{
    internal class Program
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int intelligenceValue = int.Parse(Console.ReadLine());

            int barrelSizeCounter = 0;
            int bulletsLeft = bullets.Count;
            int locksLeft = locks.Count;
            int moneyEarned = 0;

            while (bullets.Any() && locks.Any())
            {
                int bullet = bullets.Peek();
                int currentLock = locks.Peek();

                if (bullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    locksLeft--;
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bullets.Pop();
                bulletsLeft--;
                moneyEarned += bulletPrice;


                barrelSizeCounter++;
                if (bulletsLeft > 0 && barrelSizeCounter == gunBarrelSize)
                {
                    Console.WriteLine("Reloading!");
                    barrelSizeCounter = 0;
                }
            }
            
            if (locksLeft == 0)
            {
                int totalEarned = intelligenceValue - moneyEarned;
                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${totalEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
            }
        }
    }
}