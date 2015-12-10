using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAX
{
    class Product
    {
        private readonly string name;
        private readonly double priceBefore;
        private readonly double priceAfter;
        private int quantity;
        private readonly string countryID;
        private readonly int productID;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double PriceBefore
        {
            get
            {
                return priceBefore;
            }
        }

        public double PriceAfter
        {
            get
            {
                return priceAfter;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string CountryID
        {
            get
            {
                return countryID;
            }
        }

        public int ProductID
        {
            get
            {
                return productID;
            }
        }

        public Product(string name, double priceBefore, int quantity, string countryID, int productID, VATTAXCalculator calc)
        {
            this.name = name;
            this.priceBefore = priceBefore;
            this.quantity = quantity;
            this.countryID = countryID;
            this.productID = productID;
            priceAfter = calc.CalculateTax(priceBefore, countryID) + priceBefore;
        }
    }
}
