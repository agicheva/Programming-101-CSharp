using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class CashDesk
    {
        private int money;
        private Dictionary<int, int> bills;

        public CashDesk()
        {
            bills = new Dictionary<int, int>();
            bills.Add(1, 0);
            bills.Add(2, 0);
            bills.Add(5, 0);
            bills.Add(10, 0);
            bills.Add(20, 0);
            bills.Add(50, 0);
            bills.Add(100, 0);
        }

        public int Money
        {
            get
            {
                return money;
            }

            set
            {
                money = value;
            }
        }

        public int TakeMoney(Bill bill)
        {
            money += bill.Value();
            bills[bill.Value()]++;

            return money;
        }

        public int TakeMoney(TheBatchBill batch)
        {
            money += batch.Total();
            foreach (Bill bill in batch)
            {
                bills[bill.Value()]++;
            }

            return money;
        }

        public int Total()
        {
            return money;
        }

        public void Inspect()
        {
            foreach (var item in bills)
            {
                Console.WriteLine("{0}$ bills - {1}", item.Key, item.Value);

            }
        }
    }

    public class NotFoundException : Exception
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string message)
            : base(message)
        {
        }
    }
}
