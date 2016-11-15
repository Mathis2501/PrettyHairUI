using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class ProductTypeRepository
    {
        
        public static List<ProductType> Products = new List<ProductType>();

        public static string AdjustAmount(ProductType productType, int origInt)
        {
            productType.Amount = origInt;
            return "ChangeConfirmed:\n Changed To: " + origInt + "\n";
        }
        
        public static string AdjustPrice(ProductType productType, double origInt)
        {
            productType.Price = origInt;
            return "ChangeConfirmed:\n Changed To: " + origInt + "\n";
        }

        public static string AdjustDescription(ProductType productType, string origString)
        {
            productType.Description = origString;
            return "ChangeConfirmed:\n Changed To: " + origString + "\n";
        }
    }
}
