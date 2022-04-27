using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SGTCalculator 
{

    public class SGTCalculator
    {
        static void Main(string[] args)
        {
            DBConnection dBConnection = new DBConnection();
            ProductManager productManager = new ProductManager(dBConnection);
            CategoryManager categoryManager = new CategoryManager(dBConnection, productManager);

            var categories = categoryManager.GetCategories();
            categoryManager.SetCategoryProducts(categories);

            foreach (var category in categories) { 
                Console.WriteLine("Category name : " + category.Name);
            }

            foreach (var products in categories[0].Products)
            {
                Console.WriteLine("Product name : " + products.Name);
            }

            productManager.UpdateProductBasedOnId(21, "New Name", categories[0].Products);
            Console.WriteLine("Product name with id: " + categories[0].Products.Where(x => x.Id == 21).First().Name);

            Console.Read();
        }
    }
}


