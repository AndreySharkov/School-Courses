namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int GreenLightSec = int.Parse(Console.ReadLine());
            int FreeWindowSeconds = int.Parse(Console.ReadLine());
            int[] time = { GreenLightSec, FreeWindowSeconds };
            string command = Console.ReadLine();
            int passedCars = 0;
            Queue<string> cars = new Queue<string>();
            while (command != "END")
            {
                if(command == "green")
                {
                    while(cars.Count > 0)
                    {
                        string current = cars.Dequeue().Trim();
                        if (current.Length > time[1] + time[0])
                        {
                            //crash
                            Console.WriteLine("Crash on the crossroad!");
                            char hittedChar = (char)(current.Length - (time[1] + time[0]));
                            Console.WriteLine($"{current} was hit at {hittedChar}");
                            return;
                        }
                        else if (current.Length > time[0])
                        {
                            //last car
                            break;
                        }
                        else
                        {
                            passedCars++;
                            //no crash
                        }
                        
                        time[0] -= current.Length;
                    }
                    time[0] = GreenLightSec;
                    time[1] = FreeWindowSeconds;                    
                }
                else
                {
                    cars.Enqueue(command);
                    
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No crash happened.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}