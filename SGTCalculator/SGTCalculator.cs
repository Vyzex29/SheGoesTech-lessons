using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SGTCalculator 
{

    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");

            var datasource = @"WINDOWS-NDJDBML";//your server
            var database = "BicycleShop"; //your database name
            var username = "sa"; //username of server to connect
            var password = "password"; //password

            //your connection string 
            string connString = @$"Server={datasource};Database={database};Trusted_Connection=True;";

            Console.WriteLine(connString);
            string query = $" INSERT INTO [sales].[customers] " +
                $"Values('ValerijsFromConsole2', 'Diks', '27793783', 'email', 'bultu', 'Riga', 'RX', 'LV106')";

            string query2 = $"Select * from [sales].[customers] Where state = 'NY'";
            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();
                SqlCommand cmd = new SqlCommand(query2, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format($"{reader["first_name"]} {reader["last_name"]}"));
                    }
                    Console.WriteLine("Command executed");

                }
                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }
    }
}


