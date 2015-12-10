using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAX
{
    class Inventory
    {
        private readonly List<Product> products;

        public Inventory(List<Product> products)
        {
            this.products = new List<Product>(products.Count);
            foreach (var item in products)
            {
                this.products = products;
            }
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }
        }

        public double Audit()
        {
            double earn = 0;

            foreach (var product in products)
            {
                earn += (product.PriceAfter - product.PriceBefore) * product.Quantity; 
            }

            return earn;
        }

        public double RequestOrder(Order order)
        {
            bool productFoundInInvenory = false;
            double amount = 0;

            foreach (var product in Products)
            {
                foreach (var requestedProduct in order.OrderedItems)
                {
                    if (product.ProductID == requestedProduct.Key)
                    {
                        productFoundInInvenory = true;
                        if (product.Quantity >= requestedProduct.Value)
                        {
                            amount += product.PriceAfter * requestedProduct.Value;
                        }
                        else
                        {
                            throw new NotAvailableInInventoryException("The product is not available.");
                        }
                        break;
                    }
                }
            }

            if(!productFoundInInvenory)
            {
                throw new NotAvailableInInventoryException("The product is not present.");
            }

            return amount;
        }
    }

    class NotAvailableInInventoryException : Exception
    {
        public NotAvailableInInventoryException()
        {

        }

        public NotAvailableInInventoryException(string message) : base(message)
        {

        }

    }
}
