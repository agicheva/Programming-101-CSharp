using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAX
{
    class VATTAX
    {
        static void Main(string[] args)
        {
            CountryVATTAX[] countryList = new CountryVATTAX[]
            {
                new CountryVATTAX("Bulgaria", 0.2, true),
                new CountryVATTAX("Germany", 0.19, false),
                new CountryVATTAX("France", 0.2, false),
                new CountryVATTAX("Finland", 0.24, false),
                new CountryVATTAX("Hungary", 0.27, false),
                new CountryVATTAX("Ireland", 0.23, false),
                new CountryVATTAX("Denmark", 0.25, false),
                new CountryVATTAX("Italy", 0.22, false),
                new CountryVATTAX("Spain", 0.21, false),
                new CountryVATTAX("Sweden", 0.25, false),
                new CountryVATTAX("United Kingdom", 0.20, false)
            };

            VATTAXCalculator calc = new VATTAXCalculator(countryList.ToList());

            Product[] products = new Product[]
            {
                new Product("Hlqb"  , 0.8, 10, "Bulgaria", 1, calc),
                new Product("Sirene", 4.5, 10, "Denmark", 2, calc),
                new Product("Voda"  , 0.4, 10, "Spain", 3, calc),
                new Product("Qica"  , 0.1, 10, "United Kingdom", 4, calc),
                new Product("Emeka" , 2.5, 10, "Ireland", 5, calc),
                new Product("Sok"   , 2.2, 10, "Italy", 6, calc)
            };
           
            Inventory shop = new Inventory(products.ToList());

            Dictionary<int, int> items1 = new Dictionary<int, int>();
            items1.Add(2, 2);
            items1.Add(3, 3);
            items1.Add(1, 2);
            Order order1 = new Order(items1);

            Dictionary<int, int> items2 = new Dictionary<int, int>();
            items2.Add(4, 5);
            items2.Add(5, 1);
            items2.Add(3, 1);
            Order order2 = new Order(items2);

            Dictionary<int, int> items3 = new Dictionary<int, int>();
            items3.Add(2, 1);
            items3.Add(5, 1);
            items3.Add(3, 2);
            Order order3 = new Order(items3);

            Console.WriteLine("Audit: {0}", shop.Audit());
            Console.WriteLine("Order 1 value: {0}", shop.RequestOrder(order1));
            Console.WriteLine("Audit: {0}", shop.Audit());
            Console.WriteLine("Order 2 value: {0}", shop.RequestOrder(order2));
            Console.WriteLine("Audit: {0}", shop.Audit());
            Console.WriteLine("Order 3 value: {0}", shop.RequestOrder(order3));
        }
    }
}
