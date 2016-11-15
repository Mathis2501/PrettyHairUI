using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PrettyHair;

namespace PrettyHairUI
{
    internal class Ui
    {
        private static void Main(string[] args)
        {
            Ui myProgram = new Ui();
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

        private static void RunSwitch(string userInput)
        {
            switch (userInput.ToUpper())
            {
                case "CREATE PRODUCT":
                    Ui createProduct = new Ui();
                    createProduct.CreateProduct();
                    break;

                case "CHANGE PRICE":
                    Ui changePrice = new Ui();
                    changePrice.ChangePrice();
                    break;

                case "CHANGE AMOUNT":
                    Ui changeAmount = new Ui();
                    changeAmount.ChangeAmount();
                    break;

                case "CHANGE DESCRIPTION":
                    Ui changeDescription = new Ui();
                    changeDescription.ChangeDescription();
                    break;

                case "EXIT":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong Input!");
                    break;
            }
        }

        

        private void CreateProduct()
        {
            Console.WriteLine("Enter the Product Price:");
            string price = Console.ReadLine();
            double productPrice = TryParse.TryParseDouble(price);

            Console.WriteLine("Enter the Product Amount");
            string amount = Console.ReadLine();
            double productAmount = TryParse.TryParseDouble(amount);

            Console.WriteLine("Enter the Product Description");
            string description = Console.ReadLine();

            ProductType product = new ProductType(productPrice, productAmount, description);

            ProductTypeRepository.Products.Add(product);
        }

        private void ChangePrice()
        {
            Console.WriteLine("What product ID do you wish to edit");
            string iD = Console.ReadLine();
            int id = TryParse.TryParseInt(iD);

            Console.WriteLine("What should the product cost?");
            string newPrice = Console.ReadLine();
            double productPrice = TryParse.TryParseDouble(newPrice);

            Console.WriteLine(ProductTypeRepository.AdjustPrice(ProductTypeRepository.Products[id - 1], productPrice));
        }

        private void ChangeAmount()
        {
            Console.WriteLine("What product ID do you wish to edit");
            string iD = Console.ReadLine();
            int id = TryParse.TryParseInt(iD);

            Console.WriteLine("How many of the product is in stock?");
            string newAmount = Console.ReadLine();
            int productAmount = TryParse.TryParseInt(newAmount);

            Console.WriteLine(ProductTypeRepository.AdjustAmount(ProductTypeRepository.Products[id - 1], productAmount));
        }

        private void ChangeDescription()
        {
            Console.WriteLine("What product ID do you wish to edit");
            string iD = Console.ReadLine();
            int id = TryParse.TryParseInt(iD);

            Console.WriteLine("What should the description be");
            string productDescription = Console.ReadLine();

            Console.WriteLine(ProductTypeRepository.AdjustDescription(ProductTypeRepository.Products[id - 1], productDescription));
        }
    }
}
    
    

