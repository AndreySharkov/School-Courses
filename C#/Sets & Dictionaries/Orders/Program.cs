namespace Orders
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Tuple<double, int>> products = new Dictionary<string, Tuple<double, int>>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "buy")
                    break;

                string[] input = inputLine.Split();
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!products.ContainsKey(name))
                {
                    products[name] = new Tuple<double, int>(price, quantity);
                }
                else
                {
                    int existingQuantity = products[name].Item2;
                    products[name] = new Tuple<double, int>(price, existingQuantity + quantity);
                }
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value.Item1 * product.Value.Item2;
                Console.WriteLine($"{product.Key} -> {totalPrice:F2}");
            }
        }
    }
}