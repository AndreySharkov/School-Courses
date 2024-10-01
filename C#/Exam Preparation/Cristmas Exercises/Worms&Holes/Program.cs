using System.Numerics;

namespace Worms_Holes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> worms = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> holes = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int wormsCount = worms.Count();
            int matches = 0;
            while (holes.Any())
            {

                int currentWorm = worms.Pop();
                int currentHole = holes.Peek();

                if (currentWorm == currentHole)
                {
                    matches++;
                    holes.Dequeue();
                }
                else
                {
                    holes.Dequeue();
                    currentWorm -= 3;

                    if (currentWorm > 0)
                    {
                        worms.Push(currentWorm);
                    }
                }
            }

            if (matches > 0)
            {
                Console.WriteLine($"Matches: {matches}");
            }
            else
            {
                Console.WriteLine("There are no matches.");
            }
            if (wormsCount == matches )
            {
                Console.WriteLine("Every worm found a suitable hole!");
            }
            else if (worms.Count == 0)
            {
                Console.WriteLine("Worms left: none");
            }
            else
            {
                Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
            }

            if(holes.Count == 0)
            {
                Console.WriteLine("Holes left: none");
            }
            else
            {
                Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
            }


        }
    }
}