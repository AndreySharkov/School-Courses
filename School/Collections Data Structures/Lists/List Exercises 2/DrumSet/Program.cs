namespace DrumSet
{
    internal class Program
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> initialQualities = drumSet.ToList(); 
            string command;

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;

                    if (drumSet[i] <= 0)
                    {
                        if (savings >= initialQualities[i] * 3)
                        {
                            drumSet[i] = initialQualities[i];
                            savings -= initialQualities[i] * 3;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            initialQualities.RemoveAt(i);
                            i--; 
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}