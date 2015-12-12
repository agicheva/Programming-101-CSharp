using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class Bill
    {
        private int amount;

        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public Bill(int amount)
        {
            this.amount = amount;
        }

        public override string ToString()
        {
            string format = string.Format("A {0}$ bill.", amount);
            return format;
        }

        public override bool Equals(object obj)
        {
            Bill bill = (Bill)obj;

            if (bill.amount == amount)
            {
                return true;
            }

            return false;
        }

        public static bool operator==(Bill a, Bill b)
        {
            if (a.Equals(b))
            {
                return true;
            }

            return false;
        }

        public static bool operator!=(Bill a, Bill b)
        {
            if (a.Equals(b))
            {
                return false;
            }

            return true;
        }

        //return the amount of the bill
        public int Value()
        {
            return amount; 
        }

        public static explicit operator int(Bill bill)
        {
            return bill.amount;
        }
    }
}
