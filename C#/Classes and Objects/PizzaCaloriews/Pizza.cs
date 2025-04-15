using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCaloriews
{
    

    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name)
        {
            Name = name;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                name = value;
            }
        }

        public Dough Dough
        {
            set => dough = value;
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count >= 10)
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            toppings.Add(topping);
        }

        public double GetTotalCalories()
        {
            double totalCalories = dough.GetCalories();
            totalCalories += toppings.Sum(t => t.GetCalories());
            return totalCalories;
        }
    }

}
