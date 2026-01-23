
namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person { Name = "Pesho", Age = 20 };
            Person gosho = new Person();
            gosho.Name = "Gosho";
            gosho.Age = 18;
            Person stamat = new Person { Name = "Stamat", Age = 43 };
            Console.WriteLine($"Name: {pesho.Name}, Age: {pesho.Age}");
            Console.WriteLine($"Name: {gosho.Name}, Age: {gosho.Age}");
            Console.WriteLine($"Name: {stamat.Name}, Age: {stamat.Age}");
        }
    }
}