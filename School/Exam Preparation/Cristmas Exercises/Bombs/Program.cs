namespace Bombs
{
    internal class Program
    {
        static void Main()
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            int cherryBombsCount = 0;
            int daturaBombsCount = 0;
            int smokeDecoyBombsCount = 0;

            while (bombEffects.Count > 0 && bombCasings.Count > 0)
            {
                int sum = bombEffects.Peek() + bombCasings.Peek();

                if (sum == 40)
                {
                    daturaBombsCount++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (sum == 60)
                {
                    cherryBombsCount++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (sum == 120)
                {
                    smokeDecoyBombsCount++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else
                {
                    bombCasings.Push(bombCasings.Pop() - 5);
                }

                if (cherryBombsCount >= 3 && daturaBombsCount >= 3 && smokeDecoyBombsCount >= 3)
                {
                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                    Console.WriteLine($"Bomb Effects: {(bombEffects.Count == 0 ? "empty" : string.Join(", ", bombEffects))}");
                    Console.WriteLine($"Bomb Casings: {(bombCasings.Count == 0 ? "empty" : string.Join(", ", bombCasings))}");
                    Console.WriteLine($"Cherry Bombs: {cherryBombsCount}");
                    Console.WriteLine($"Datura Bombs: {daturaBombsCount}");
                    Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombsCount}");
                    return;
                }
            }

            Console.WriteLine("You don't have enough materials to fill the bomb pouch!");
            Console.WriteLine($"Bomb Effects: {(bombEffects.Count == 0 ? "empty" : string.Join(", ", bombEffects))}");
            Console.WriteLine($"Bomb Casings: {(bombCasings.Count == 0 ? "empty" : string.Join(", ", bombCasings))}");
            Console.WriteLine($"Cherry Bombs: {cherryBombsCount}");
            Console.WriteLine($"Datura Bombs: {daturaBombsCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombsCount}");
        }
    }
}