using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGTCalculator
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int ModelYear { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, int categoryId, int brandId, int modelYear, decimal price) 
        { 
            Id = id;
            Name = name;
            CategoryId = categoryId;
            BrandId = brandId;
            ModelYear = modelYear;
            Price = price;
        }
    }
}
