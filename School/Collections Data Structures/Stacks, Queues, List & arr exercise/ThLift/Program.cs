
namespace ThLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lifts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i = 0; i < lifts.Length; i++)
            {
                while(lifts[i] < 4 && people > 0)
                {
                    lifts[i]++;
                    people--;
                }
            }
            if(people > 0 && lifts[lifts.Length - 1] == 4)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lifts));
            }
            else if(people >= 0 && lifts[lifts.Length -1] != 4)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lifts));
            }
            else if (people == 0)
            {
                Console.WriteLine(string.Join(" ", lifts));
            }
        }
    }
}