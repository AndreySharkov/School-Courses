namespace ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            HashSet<string> parking = new HashSet<string>();
            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "IN":
                        parking.Add(input[1]);
                    break;
                    case "OUT":
                        parking.Remove(input[1]);
                        break;
                }
                input = Console.ReadLine().Split(", ");
            }
            if(parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach(var carNumber in parking)
                {
                    Console.WriteLine(carNumber);
                }
            }
        }
    }
}