using System.Data.SqlClient;

namespace SGTCalculator
{
    public class CategoryManager
    {
        private DBConnection Connection;
        private ProductManager ProductManager;

        public CategoryManager(DBConnection connection, ProductManager productManager)
        {
            Connection = connection;
            ProductManager = productManager;
        }

        public List<Category> GetCategories()
        {
            string query2 = $"Select * from production.categories;";
            List<Category> categories = new List<Category>();
            try
            {
                SqlCommand cmd = new SqlCommand(query2, Connection.conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["category_id"]);
                        var category = new Category(id, reader["category_name"].ToString());
                        categories.Add(category);
                    }
                    Console.WriteLine("GetCategories command executed");
                    reader.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return categories;
        }

        public void SetCategoryProducts(List<Category> categories)
        {
            foreach (Category category in categories) 
            { 
                var products = ProductManager.GetProductsByCategoryId(category.ID);
                category.Products = products;
            }
        }
    }
}
