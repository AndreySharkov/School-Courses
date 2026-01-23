using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopingSpree
{
    public class Product
    {
        private decimal cost;
        private string productName;

        public decimal Cost { get => cost; set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                cost = value;

            }
        }
        public string ProductName
        {
            get => productName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                productName = value;
            }
        }
        public Product (decimal cost, string productName)
        {
            Cost = cost;
            ProductName = productName;
        }
    }

}
