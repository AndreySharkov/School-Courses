namespace BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            double totalBonus = 0;
            double attendance = 0;
            double maxAttendance = 0;
            double maxBonus = 0;
            for (int i = 0; i < students; i++)
            {
                attendance = double.Parse(Console.ReadLine());
                if (attendance > maxAttendance)
                {
                    totalBonus = (attendance / lectures) * (5 + bonus);
                    maxBonus = Math.Ceiling(totalBonus);
                    maxAttendance = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");

        }
    }
}