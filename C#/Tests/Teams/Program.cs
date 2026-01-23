namespace Teams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] teams = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i] >= 0)
                {
                    while(teams[i] < 4 && people > 0)
                    {
                        teams[i]++;
                        people--;
                    }
                }
                if (people <= 0 && teams[teams.Length - 1] < 4)
                {
                    Console.WriteLine("There are free positions in the teams!");
                    Console.WriteLine(string.Join(" ", teams));
                    return;
                }
                
            }
            if(people > 0)
            {
                Console.WriteLine($"There isn't enough free positions! {people} people are available!");
                Console.WriteLine(string.Join(" ", teams));
                return ;
            }
            Console.WriteLine(string.Join(" ", teams));




        }
    }
}
