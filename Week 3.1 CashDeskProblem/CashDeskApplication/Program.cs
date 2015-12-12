using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashDesk;

namespace CashDeskApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new Bill(10);
            var b = new Bill(5);
            var c = new Bill(10);

            Console.WriteLine((int)a);
            Console.WriteLine(a);
            Console.WriteLine(a == b);
            Console.WriteLine(a == c);

            List<Bill> bills = new List<Bill> { new Bill(10), new Bill(20), new Bill(50), new Bill(100) };
            TheBatchBill batch = new TheBatchBill(bills);

            foreach (var bill in batch)
            {
                Console.WriteLine(bill);
            }

            List<Bill> bills1 = new List<Bill> { new Bill(10), new Bill(20), new Bill(50), new Bill(100), new Bill(100) };
            TheBatchBill batch1 = new TheBatchBill(bills);

            CashDesk.CashDesk desk = new CashDesk.CashDesk();

            desk.TakeMoney(new Bill(100));
            desk.TakeMoney(batch1);
            desk.TakeMoney(new Bill(10));

            Console.WriteLine(desk.Total()); 
            desk.Inspect();

        }
    }
}
