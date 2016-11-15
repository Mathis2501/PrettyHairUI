using System;

namespace PrettyHair
{
    public static class TryParse
    {
        public static double TryParseDouble(string value)
        {
            double ProductPrice;
            while (double.TryParse(value, out ProductPrice) == false)
            {
                Console.WriteLine("Try Again!");
                value = Console.ReadLine();
            }
            return ProductPrice;
        }

        public static int TryParseInt(string value)
        {
            int productPrice;
            while (int.TryParse(value, out productPrice) == false)
            {
                Console.WriteLine("Try Again!");
                value = Console.ReadLine();
            }
            return productPrice;
        }
    }
}