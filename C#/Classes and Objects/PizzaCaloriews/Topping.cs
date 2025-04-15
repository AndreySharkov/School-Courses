using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCaloriews
{
    public class Topping
    {
        private string toppingType;
        private double weight;

        private static readonly Dictionary<string, double> ToppingModifiers = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
    {
        { "Meat", 1.2 },
        { "Veggies", 0.8 },
        { "Cheese", 1.1 },
        { "Sauce", 0.9 }
    };

        public Topping(string toppingType, double weight)
        {
            ToppingType = toppingType;
            Weight = weight;
        }

        public string ToppingType
        {
            get => toppingType;
            private set
            {
                if (!ToppingModifiers.ContainsKey(value))
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                toppingType = value;
            }
        }

        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 50)
                    throw new ArgumentException($"{ToppingType} weight should be in the range [1..50].");
                weight = value;
            }
        }

        public double GetCalories()
        {
            return 2 * Weight * ToppingModifiers[ToppingType];
        }
    }

}
