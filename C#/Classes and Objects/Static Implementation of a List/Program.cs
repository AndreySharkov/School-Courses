namespace Static_Implementation_of_a_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList shoppingList = new CustomArrayList();

            shoppingList.Add("Tomato");
            shoppingList.Add("Bread");
            shoppingList.Add("Cheese");
            shoppingList.Add("Cucumbers");
            shoppingList.Add("Chocolate");
            shoppingList.Add(7);
            shoppingList.Add("Coke");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Insert(1, "Lemon");
            Console.WriteLine(shoppingList.IndexOf("Chocolate"));
            Console.WriteLine(shoppingList.Contains("Coke"));
            Console.WriteLine(shoppingList[1]);
            Console.WriteLine(shoppingList.Count);
            shoppingList.Remove(3);
            shoppingList.Remove("Tomato");
            Console.WriteLine(shoppingList.Count);

        }
    }

}
