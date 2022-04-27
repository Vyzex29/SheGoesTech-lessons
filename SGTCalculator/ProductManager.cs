using System.Data.SqlClient;

namespace SGTCalculator
{
    public class ProductManager
    {
        private DBConnection Connection;

        public ProductManager(DBConnection connection) 
        { 
            Connection = connection;
        }

        public List<Product> GetProductsByCategoryId(int categoryId) 
        {
            string query2 = $"Select * from production.products Where category_id = '{categoryId}';";
            List<Product> products = new List<Product>();
            try
            {
                SqlCommand cmd = new SqlCommand(query2, Connection.conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product(
                            Convert.ToInt32(reader["product_id"]),
                            reader["product_name"].ToString(),
                            Convert.ToInt32(reader["category_id"]),
                            Convert.ToInt32(reader["brand_id"]),
                            Convert.ToInt32(reader["model_year"]),
                            Convert.ToDecimal(reader["list_price"]));
                        products.Add(product);
                    }
                    Console.WriteLine("GetProductsByCategoryId command executed");
                    reader.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return products;
        }

        public bool UpdateProductBasedOnId(int productId, string name, List<Product> products) 
        {
            string query2 = $"UPDATE production.products SET product_name = '{name}' WHERE product_id = {productId};";
            try
            {
                SqlCommand cmd = new SqlCommand(query2, Connection.conn);
                var number = cmd.ExecuteNonQuery();
                if (number > 0) 
                {
                    var product = products.Where(x => x.Id == productId).First();
                    product.Name = name;
                    return true;
                }
                Console.WriteLine("UpdateProductBasedOnId command executed");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return false;
        }
    }
}
