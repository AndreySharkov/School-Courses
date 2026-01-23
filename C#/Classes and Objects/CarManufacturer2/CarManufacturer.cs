namespace CarManufacturer
{
    internal class CarManufacturer
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = Console.ReadLine();
            car.Model = Console.ReadLine();
            car.Year = int.Parse(Console.ReadLine());
            car.FuelQuantity = double.Parse(Console.ReadLine());
            car.FuelConsumption = double.Parse(Console.ReadLine());
            car.Drive(double.Parse(Console.ReadLine()));
            Console.WriteLine(car.WhoAmI());
            

        }
    }
}