using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class EditDatabase
    {
        private static string connectionString =
            "Data Source=ealdb1.eal.local;Persist Security Info=True;User ID=ejl60_usr;Password=Baz1nga60";

        public void CreateProduct()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand insertProduct = new SqlCommand("spInsertPrettyHairProduct", con);
                    insertProduct.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product Name:");
                    insertProduct.Parameters.Add(new SqlParameter("@ProductName", Console.ReadLine()));
                    Console.Clear();

                    Console.WriteLine("Enter Product Description");
                    insertProduct.Parameters.Add(new SqlParameter("@ProductDescription", Console.ReadLine()));
                    Console.Clear();

                    Console.WriteLine("Enter Product Price:");
                    insertProduct.Parameters.Add(new SqlParameter("@ProductPrice", TryParse.TryParseDouble(Console.ReadLine())));
                    Console.Clear();

                    Console.WriteLine("Enter Product Amount:");
                    insertProduct.Parameters.Add(new SqlParameter("@ProductAmount", TryParse.TryParseInt(Console.ReadLine())));
                    Console.Clear();

                    insertProduct.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("UPS " + e.Message);
                Console.ReadLine();
                Console.Clear();
            }
        }


        public void ChangeName()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand editName = new SqlCommand("spEditPrettyHairProductName", con);
                    editName.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product ID:");
                    editName.Parameters.Add(new SqlParameter("@ProductID", TryParse.TryParseInt(Console.ReadLine())));
                    Console.Clear();

                    Console.WriteLine("Enter New Product Name");
                    editName.Parameters.Add(new SqlParameter("@NewName", Console.ReadLine()));
                    Console.Clear();

                    editName.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("UPS " + e.Message);
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void ChangeDescription()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand editDescription = new SqlCommand("spEditPrettyHairProductDescription", con);
                    editDescription.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product ID:");
                    editDescription.Parameters.Add(new SqlParameter("@ProductID", TryParse.TryParseInt(Console.ReadLine())));
                    Console.Clear();

                    Console.WriteLine("Enter New Product Desciption");
                    editDescription.Parameters.Add(new SqlParameter("@NewDescription", Console.ReadLine()));
                    Console.Clear();

                    editDescription.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("UPS " + e.Message);
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void ChangePrice()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand editPrice = new SqlCommand("spEditPrettyHairProductPrice", con);
                    editPrice.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product ID:");
                    editPrice.Parameters.Add(new SqlParameter("@ProductID", TryParse.TryParseInt(Console.ReadLine())));
                    Console.Clear();

                    Console.WriteLine("Enter New Product Price");
                    editPrice.Parameters.Add(new SqlParameter("@NewPrice", TryParse.TryParseDouble(Console.ReadLine())));
                    Console.Clear();

                    editPrice.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("UPS " + e.Message);
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void ChangeAmount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand editAmount = new SqlCommand("spEditPrettyHairProductAmount", con);
                    editAmount.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product ID:");
                    editAmount.Parameters.Add(new SqlParameter("@ProductID", TryParse.TryParseInt(Console.ReadLine())));
                    Console.Clear();

                    Console.WriteLine("Enter New Product Amount");
                    editAmount.Parameters.Add(new SqlParameter("@NewAmount", TryParse.TryParseInt(Console.ReadLine())));
                    Console.Clear();

                    editAmount.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("UPS " + e.Message);
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void DeleteProductById()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand DeleteProduct = new SqlCommand("spDeletePrettyHairByProductID", con);
                    DeleteProduct.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product ID:");
                    DeleteProduct.Parameters.Add(new SqlParameter("@ProductID", TryParse.TryParseInt(Console.ReadLine())));
                    Console.Clear();

                    DeleteProduct.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("UPS " + e.Message);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
