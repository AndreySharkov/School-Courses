namespace PizzaCaloriews
{
    class Program
    {
        static void Main()
        {
            try
            {
                string[] pizzaInput = Console.ReadLine().Split();
                string pizzaName = pizzaInput[1];

                string[] doughInput = Console.ReadLine().Split();
                Dough dough = new Dough(doughInput[1], doughInput[2], double.Parse(doughInput[3]));

                Pizza pizza = new Pizza(pizzaName);
                pizza.Dough = dough;

                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] toppingInput = input.Split();
                    Topping topping = new Topping(toppingInput[1], double.Parse(toppingInput[2]));
                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():F2} Calories.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
