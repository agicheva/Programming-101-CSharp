using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Order
    {
        private int orderID;
        private List<int> products;
        private DateTime orderDate;
        private string name;

        public int OrderID
        {
            get
            {
                return orderID;
            }

            set
            {
                orderID = value;
            }
        }

        public List<int> Products
        {
            get
            {
                return products;
            }

            set
            {
                products = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }

            set
            {
                orderDate = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Order(int orderID, List<int> products, DateTime orderDate, string name)
        {
            OrderID = orderID;
            Products = products;
            OrderDate = orderDate;
            Name = name;
        }
    }
}
