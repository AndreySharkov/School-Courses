using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCaloriews
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        private static readonly Dictionary<string, double> FlourModifiers = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
    {
        { "White", 1.5 },
        { "Wholegrain", 1.0 }
    };

        private static readonly Dictionary<string, double> TechniqueModifiers = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
    {
        { "Crispy", 0.9 },
        { "Chewy", 1.1 },
        { "Homemade", 1.0 }
    };

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => flourType;
            private set
            {
                if (!FlourModifiers.ContainsKey(value))
                    throw new ArgumentException("Invalid type of dough.");
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (!TechniqueModifiers.ContainsKey(value))
                    throw new ArgumentException("Invalid type of dough.");
                bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 200)
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                weight = value;
            }
        }

        public double GetCalories()
        {
            return 2 * Weight * FlourModifiers[FlourType] * TechniqueModifiers[BakingTechnique];
        }
    }


}
