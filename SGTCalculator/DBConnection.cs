using System.Data.SqlClient;

namespace SGTCalculator
{
    public class DBConnection
    {
        string datasource { get; set; }//your server
        string database { get; set; } //your database name
        string connString { get; set; }
        public SqlConnection conn { get; set; }

        public DBConnection() 
        {
            Console.WriteLine("Getting Connection ...");
            datasource = @"LAPTOP-971UE9VO";
            database = "BicycleShop";
            connString = @$"Server={datasource};Database={database};Trusted_Connection=True;";
            conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                Console.WriteLine("Connection created");
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}
