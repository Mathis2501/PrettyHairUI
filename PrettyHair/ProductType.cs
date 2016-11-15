using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair;

namespace PrettyHair
{
    public class ProductType
    {
        public int Id;
        public string Description;
        public double Price;
        public double Amount;

        
        
        public ProductType(double price, double amount, string description)
        {
            Description = description;
            Price = price;
            Amount = amount;
            NextId();
        }

        public ProductType()
        {
            
        }

        public void NextId()
        {
            Id++;
        }

        public override string ToString()
        {
            return "Product [ID = " + Id + ", Description = " + Description + ", Price = " + Price.ToString(CultureInfo.InvariantCulture).Replace("," , ".") + ", Amount = " +
                   Amount + "]";
        }
    }
}
