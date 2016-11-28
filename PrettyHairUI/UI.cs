using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using PrettyHair;

namespace PrettyHairUI
{
    internal class Ui
    {
        private static void Main()
        {
            Ui myProgram = new Ui();
            myProgram.Run();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Choose Your Destiny\n" +
                                  "(1) Edit Database\n" +
                                  "(2) Search Database\n\n" +
                                  "(0) EXIT");
                string userInput = Console.ReadLine();
                Console.Clear();
                //Test.Main();
                RunSwitch(userInput);
            }
        }

        private static void RunSwitch(string userInput)
        {
            Ui uI = new Ui();
            switch (userInput.ToUpper())
            {
                case "1":
                    uI.EditDatabase();
                    break;

                case "2":
                    uI.SearchSwitch();
                    break;
                
                case "0":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong Input!");
                    break;
            }
        }

        private void EditDatabase()
        {
            Ui ui = new Ui();
            EditDatabase edit = new EditDatabase();
            Console.WriteLine("Choose Your Destiny\n" +
                              "(1) Create Product\n" +
                              "(2) Change Name\n" +
                              "(3) Change Description\n" +
                              "(4) Change Price\n" +
                              "(5) Change Amount\n" +
                              "(6) Delete Product\n\n" + 
                              "(0) BACK"
                              );
            string userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    edit.CreateProduct();
                    break;

                case "2":
                    edit.ChangeName();
                    break;

                case "3":
                    edit.ChangeDescription();
                    break;

                case "4":
                    edit.ChangePrice();
                    break;

                case "5":
                    edit.ChangeAmount();
                    break;

                case "6":
                    edit.DeleteProductById();
                    break;

                case "0":
                    ui.Run();
                    break;
            }
        }

        private void SearchSwitch()
        {
            Ui ui = new Ui();
            SearchDatabase Search = new SearchDatabase();
            Console.WriteLine("Choose Your Destiny\n" +
                                  "(1) Show All\n" + 
                                  "(2) Search by Id\n" +
                                  "(3) Search by Name\n" + 
                                  "(4) Search by Description\n" + 
                                  "(5) Search by Price\n" + 
                                  "(6) Search by Amount\n\n" + 
                                  "(0) BACK");
            string userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    Search.ShowProducts();
                    break;

                case "2":
                    Search.SearchById();
                    break;

                case "3":
                    Search.SearchByName();
                    break;

                case "4":
                    Search.SearchByDescription();
                    break;

                case "5":
                    Search.SearchByPrice();
                    break;

                case "6":
                    Search.SearchByAmount();
                    break;

                case "0":
                    ui.Run();
                    break;
            }
        }
    }
}