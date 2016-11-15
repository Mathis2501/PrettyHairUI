using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PrettyHair;

namespace PrettyHairUI
{
    class UI
    {

        static void Main(string[] args)
        {
            UI myProgram = new UI();
            myProgram.Run();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Choose Your Destiny (Create Product), (Change Price), (EXIT)");
                string userInput = Console.ReadLine();
                RunSwitch(userInput);
            }
        }

        static void RunSwitch(string userInput)
        {
            switch (userInput.ToUpper())
            {
                case "CREATE PRODUCT":
                    UI CreateProduct = new UI();
                    CreateProduct.CreateProduct();
                    break;

                case "CHANGE PRICE":
                    UI ChangePrice = new UI();
                    ChangePrice.ChangePrice();
                    break;

                case "EXIT":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong Input!");
                    break;
            }
        }

        void CreateProduct()
        {
            Console.WriteLine("Enter the Product Price:");
            string Price = Console.ReadLine();
            double ProductPrice = TryParse.TryParseDouble(Price);

            Console.WriteLine("Enter the Product Amount");
            string Amount = Console.ReadLine();
            double ProductAmount = TryParse.TryParseDouble(Amount);

            Console.WriteLine("Enter the Product Description");
            string Description = Console.ReadLine();

            ProductType Product = new ProductType(ProductPrice, ProductAmount, Description);

            ProductTypeRepository.Products.Add(Product);
        }

        void ChangePrice()
        {
            Console.WriteLine("What Product ID do you wish to edit");
            string iD = Console.ReadLine();
            int Id = TryParse.TryParseInt(iD);

            Console.WriteLine("What Should the Product Cost?");
            string NewPrice = Console.ReadLine();
            double ProductPrice = TryParse.TryParseDouble(NewPrice);

            Console.WriteLine(ProductTypeRepository.AdjustPrice(ProductTypeRepository.Products[Id - 1], ProductPrice));
        }

        void Change
    }
}
    
    

