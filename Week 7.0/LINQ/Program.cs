using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStore datastore = new DataStore();

            datastore.AddCategory(new Category(105, "clothes"));
            datastore.AddCategory(new Category(111, "shoes"));
            datastore.AddCategory(new Category(120, "vegetables"));
            datastore.AddCategory(new Category(121, "fruits"));
            datastore.AddCategory(new Category(160, "sweet"));
            datastore.AddCategory(new Category(190, "beer"));
            datastore.AddCategory(new Category(115, "books"));

            datastore.AddProduct(new Product("Tshirt", 15, 105));
            datastore.AddProduct(new Product("Skirt", 12, 105));
            datastore.AddProduct(new Product("Jeans", 60, 105));
            datastore.AddProduct(new Product("Jacket", 89, 105));
            datastore.AddProduct(new Product("High-heels", 3, 111));
            datastore.AddProduct(new Product("Boots", 7, 111));
            datastore.AddProduct(new Product("Flipflops", 16, 111));
            datastore.AddProduct(new Product("Cabbage", 57, 120));
            datastore.AddProduct(new Product("Lettuce", 58, 120));
            datastore.AddProduct(new Product("Carrot", 67, 120));
            datastore.AddProduct(new Product("Watermelon", 25, 121));
            datastore.AddProduct(new Product("Apple", 90, 121));
            datastore.AddProduct(new Product("Chocolate", 66, 160));
            datastore.AddProduct(new Product("Cheesecake", 91, 160));
            datastore.AddProduct(new Product("Heineken", 13, 190));
            datastore.AddProduct(new Product("Zagorka", 63, 190));
            datastore.AddProduct(new Product("The Little Prince", 50, 115));
            datastore.AddProduct(new Product("East of Eden", 51, 115));

            datastore.AddOrder(
                new Order(201, new List<int>() { 15, 63, 91 }, DateTime.Now.AddDays(-7).AddHours(3), "firstOrder"));
            datastore.AddOrder(
                new Order(208, new List<int>() { 57, 7, 60, 90 }, DateTime.Now.AddDays(-3).AddHours(-4), "secondOrder"));
            datastore.AddOrder(
                new Order(299, new List<int>() { 13, 66, 3, 25, 51 }, DateTime.Now.AddDays(-1).AddDays(-10), "thirdOrder"));
            datastore.AddOrder(
                new Order(250, new List<int>() { 15, 58, 66, 91, 50 }, DateTime.Now.AddDays(-9).AddHours(5), "fourthOrder"));
            datastore.AddOrder(
                new Order(284, new List<int>() { 15, 51, 89, 3, 90 }, DateTime.Now.AddDays(-14).AddHours(-6), "fifthOrder"));
            datastore.AddOrder(
                new Order(260, new List<int>() { 91, 51, 89, 3, 90 }, DateTime.Now.AddDays(-5).AddHours(7), "sixthOrder"));

            //Products with ID [15,35]
            var queryP = from products in datastore.GetProducts()
                        where products.ProductID >= 15 && products.ProductID <= 35
                        select products;

            Console.WriteLine("Products with ID between 15 and 35");
            Console.WriteLine("|{0,15}|{1,15}|{2,15}","Name", "ProductID", "CategoryID");
            foreach (var item in queryP)
            {
                Console.WriteLine("|{0,15}|{1,15}|{2,15}", item.Name, item.ProductID, item.CategoryID);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            //Categories with ID [105,125]
            var queryC = from categories in datastore.GetCategories()
                         where categories.CategoryID >= 105 && categories.CategoryID <= 125
                         select categories;
            Console.WriteLine("Categories with ID between 105 and 125");
            Console.WriteLine("|{0,15}|{1,15}", "CategoryName", "CategoryID");
            foreach (var item in queryC)
            {
                Console.WriteLine("|{0,15}|{1,15}", item.CategoryName, item.CategoryID);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            //First 3 orders containing product with id 15
            var queryO = from orders in datastore.GetOrders()
                         where orders.Products.Contains(15)
                         orderby orders.OrderDate
                         select orders;
            Console.WriteLine("First three orders containing product with ID 15 sorted by order date");
            Console.WriteLine("|{0,30}|{1,15}|{2,15}","OrderDate", "OrderName", "OrderID");
            foreach (var item in queryO)
            {
                Console.WriteLine("|{0,30}|{1,15}|{2,15}", item.OrderDate, item.Name, item.OrderID);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            //Products sorted by name
            var querySortedProduts = from products in datastore.GetProducts()
                                       join categories in datastore.GetCategories() on products.CategoryID equals categories.CategoryID
                                       orderby products.Name
                                       select new { ProductName = products.Name, CategoryName = categories.CategoryName};
            Console.WriteLine("Products from all categories ordered by product name");
            Console.WriteLine("|{0,30}|{1,30}", "ProductName", "CategoryName");
            foreach (var item in querySortedProduts)
            {
                Console.WriteLine("|{0,30}|{1,30}", item.ProductName, item.CategoryName);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            //Products sorted by category
            var querySortedCategory = from products in datastore.GetProducts()
                                       join categories in datastore.GetCategories() on products.CategoryID equals categories.CategoryID
                                       orderby categories.CategoryName
                                       select new { ProductName = products.Name, CategoryName = categories.CategoryName };
            Console.WriteLine("Products from all categories ordered by name of category");
            Console.WriteLine("|{0,30}|{1,30}", "CategoryName", "ProductName");
            foreach (var item in querySortedCategory)
            {
                Console.WriteLine("|{0,30}|{1,30}", item.CategoryName, item.ProductName);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            //All categories with their products
            var queryAllCategories = from categories in datastore.GetCategories()
                                     join products in datastore.GetProducts() on categories.CategoryID equals products.CategoryID into productsList
                                     let productNames = (from product in productsList
                                                        select product.Name)
                                     select new CategoryWithProduct(categories.CategoryName, productNames.ToList(), categories.CategoryID);
            Console.WriteLine("All categories with their products");
            foreach (var item in queryAllCategories)
            {
                Console.Write("Category {0} with ID {1} has:", item.CategoryName, item.CategoryID);
                Console.WriteLine(string.Join(", ", item.ProductsName));
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            //Orders sorted by order date
            var queryAllOrders = from orders in datastore.GetOrders()
                                 let productsWithCategories = (from productID in orders.Products
                                                               join products in datastore.GetProducts() on productID equals products.ProductID
                                                               join categories in datastore.GetCategories() on products.CategoryID equals categories.CategoryID
                                                               select new { ProdctName = products.Name, CategoryName = categories.CategoryName })
                                 orderby orders.OrderDate
                                 select new {
                                     OrderID = orders.OrderID,
                                     OrderName = orders.Name,
                                     ProductsWithCategories = productsWithCategories,
                                     OrderDate = orders.OrderDate
                                 };
            Console.WriteLine("Orders with all products sorted by order date");
            foreach (var item in queryAllOrders)
            {
                Console.WriteLine("{0}  ----> OrderName: {1}", item.OrderDate, item.OrderName);
                foreach (var product in item.ProductsWithCategories)
                {
                    Console.WriteLine("{0,30}", string.Format("Product {0} - Category {1}", product.ProdctName, product.CategoryName));
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
