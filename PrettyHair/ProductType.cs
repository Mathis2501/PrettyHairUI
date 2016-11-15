using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair;

namespace PrettyHair
{
    public class ProductType
    {
        public string Description;
        public double Price;
        public double Amount;

        public ProductType(double price, double amount, string description)
        {
            Description = description;
            Price = price;
            Amount = amount;
        }

        public ProductType()
        {
            
        }

    }
}
