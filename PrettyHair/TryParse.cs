using System;
using System.Globalization;

namespace PrettyHair
{
    public static class TryParse
    {
        public static double TryParseDouble(string value)
        {
            double productPrice;
            while (double.TryParse(value, out productPrice) == false)
            {
                Console.WriteLine("Try Again!");
                value = Console.ReadLine();
            }
            Console.WriteLine(productPrice);
            Console.ReadLine();
            return productPrice;
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