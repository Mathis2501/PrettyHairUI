using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class SearchDatabase
    {
        private static string connectionString =
            "Data Source=ealdb1.eal.local;Persist Security Info=True;User ID=ejl60_usr;Password=Baz1nga60";

        public void ShowProducts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand showAllProducts = new SqlCommand("spGetPrettyHairProducts", con);
                    showAllProducts.CommandType = CommandType.StoredProcedure;


                    SqlDataReader reader = showAllProducts.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string id = reader["ProductID"].ToString();
                            string name = reader["ProductName"].ToString();
                            string description = reader["ProductDescription"].ToString();
                            string price = reader["ProductPrice"].ToString();
                            string amount = reader["ProductAmount"].ToString();
                            Console.WriteLine("ID: " + id + " | Name: " + name + " | Description: " + description + " | Price: " + price + " | Amount: " + amount);
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No Data was Found");
                        Console.ReadLine();
                        Console.Clear();
                    }

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

        public void SearchById()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand searchById = new SqlCommand("spGetPrettyHairByProductID", con);
                    searchById.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product ID");
                    searchById.Parameters.Add(new SqlParameter("@ProductID", TryParse.TryParseInt(Console.ReadLine())));

                    SqlDataReader reader = searchById.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string id = reader["ProductID"].ToString();
                            string name = reader["ProductName"].ToString();
                            string description = reader["ProductDescription"].ToString();
                            string price = reader["ProductPrice"].ToString();
                            string amount = reader["ProductAmount"].ToString();
                            Console.WriteLine("ID: " + id + " | Name: " + name + " | Description: " + description + " | Price: " + price + " | Amount: " + amount);
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No Data was Found");
                        Console.ReadLine();
                        Console.Clear();
                    }

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

        public void SearchByName()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand searchById = new SqlCommand("spGetPrettyHairByProductName", con);
                    searchById.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product Name");
                    searchById.Parameters.Add(new SqlParameter("@ProductName", Console.ReadLine()));

                    SqlDataReader reader = searchById.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string id = reader["ProductID"].ToString();
                            string name = reader["ProductName"].ToString();
                            string description = reader["ProductDescription"].ToString();
                            string price = reader["ProductPrice"].ToString();
                            string amount = reader["ProductAmount"].ToString();
                            Console.WriteLine("ID: " + id + " | Name: " + name + " | Description: " + description + " | Price: " + price + " | Amount: " + amount);
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No Data was Found");
                        Console.ReadLine();
                        Console.Clear();
                    }

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

        public void SearchByDescription()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand searchById = new SqlCommand("spGetPrettyHairByProductDesciption", con);
                    searchById.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product Description");
                    searchById.Parameters.Add(new SqlParameter("@ProductDescription", Console.ReadLine()));

                    SqlDataReader reader = searchById.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string id = reader["ProductID"].ToString();
                            string name = reader["ProductName"].ToString();
                            string description = reader["ProductDescription"].ToString();
                            string price = reader["ProductPrice"].ToString();
                            string amount = reader["ProductAmount"].ToString();
                            Console.WriteLine("ID: " + id + " | Name: " + name + " | Description: " + description + " | Price: " + price + " | Amount: " + amount);
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No Data was Found");
                        Console.ReadLine();
                        Console.Clear();
                    }

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

        public void SearchByPrice()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand searchById = new SqlCommand("spGetPrettyHairByProductPrice", con);
                    searchById.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product Price");
                    searchById.Parameters.Add(new SqlParameter("@ProductPrice", TryParse.TryParseDouble(Console.ReadLine())));

                    SqlDataReader reader = searchById.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string id = reader["ProductID"].ToString();
                            string name = reader["ProductName"].ToString();
                            string description = reader["ProductDescription"].ToString();
                            string price = reader["ProductPrice"].ToString();
                            string amount = reader["ProductAmount"].ToString();
                            Console.WriteLine("ID: " + id + " | Name: " + name + " | Description: " + description + " | Price: " + price + " | Amount: " + amount);
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No Data was Found");
                        Console.ReadLine();
                        Console.Clear();
                    }

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

        public void SearchByAmount()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand searchById = new SqlCommand("spGetPrettyHairByProductName", con);
                    searchById.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("Enter Product Name");
                    searchById.Parameters.Add(new SqlParameter("@ProductName", TryParse.TryParseInt(Console.ReadLine())));

                    SqlDataReader reader = searchById.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string id = reader["ProductID"].ToString();
                            string name = reader["ProductName"].ToString();
                            string description = reader["ProductDescription"].ToString();
                            string price = reader["ProductPrice"].ToString();
                            string amount = reader["ProductAmount"].ToString();
                            Console.WriteLine("ID: " + id + " | Name: " + name + " | Description: " + description + " | Price: " + price + " | Amount: " + amount);
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No Data was Found");
                        Console.ReadLine();
                        Console.Clear();
                    }

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
