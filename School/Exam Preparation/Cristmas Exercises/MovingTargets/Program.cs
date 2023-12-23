namespace MovingTargets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commandSTR;
            while((commandSTR = Console.ReadLine()) != "End")
            {
                string[] command = commandSTR.Split().ToArray();
                switch (command[0])
                {
                    case "Shoot":
                        Shoot(targets, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Add":
                        Add(targets, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Strike":
                        Strike(targets, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                }
            }
            Console.WriteLine(string.Join("|", targets));
        }
        static void Shoot(List<int> targets, int index, int power)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= power;

                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }
        }

        static void Add(List<int> targets, int index, int value)
        {
            if (index >= 0 && index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        static void Strike(List<int> targets, int index, int radius)
        {
            int startIndex = index - radius;
            int endIndex = index + radius;

            if (startIndex >= 0 && endIndex < targets.Count)
            {
                targets.RemoveRange(startIndex, endIndex - startIndex + 1);
            }
            else
            {
                Console.WriteLine("Strike missed!");
            }
        }
    }
}