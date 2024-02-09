namespace ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] tokens = input.Split(", ");
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }

                shops[shop][product] = price;
            }

            foreach (var shop in shops.OrderBy(s => s.Key))
            {
                string shopName = shop.Key;
                Dictionary<string, double> products = shop.Value;

                Console.WriteLine($"{shopName}->");

                foreach (var product in products)
                {
                    string productName = product.Key;
                    double productPrice = product.Value;

                    Console.WriteLine($"Product: {productName}, Price: {productPrice:f1}");
                }
            }
        }
    }
}