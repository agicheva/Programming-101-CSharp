using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class DataStore
    {
        private List<Product> products;
        private List<Category> categories;
        private List<Order> orders;

        public DataStore()
        {
            products = new List<Product>();
            categories = new List<Category>();
            orders = new List<Order>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public List<Category> GetCategories()
        {
            return categories;
        }

        public List<Order> GetOrders()
        {
            return orders;
        }
    }
}
