namespace List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = GetList(n);
            products.Sort();
            PrintProducts(products);

            

        }
        static List<string> GetList(int n)
        {
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                products.Add(currentProduct);
            }
            return products;
        }
        static void PrintProducts(List<string> products)
        {

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}