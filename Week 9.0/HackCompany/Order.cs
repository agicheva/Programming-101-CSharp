using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackCompany
{
    class Order
    {
        public int OrderId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public int CustomerId { get; set; }
        public double TotalPrice { get; set; }
        
        public Order(int orderId, DateTime dateOfOrder, int customerId, double totalPrice)
        {
            OrderId = orderId;
            DateOfOrder = dateOfOrder;
            CustomerId = customerId;
            TotalPrice = totalPrice;
        } 
    }
}
