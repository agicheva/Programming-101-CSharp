using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackCompany
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }

        public Product(int productId, string name, double price, int categoryId)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            CategoryId = categoryId;
        }
    }
}
