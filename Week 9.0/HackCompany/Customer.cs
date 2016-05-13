using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackCompany
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal? Discount { get; set; }

        public Customer(int customerId, string name, string email, string address, decimal? discount)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
            Address = address;
            Discount = discount;
        }
    }
}
