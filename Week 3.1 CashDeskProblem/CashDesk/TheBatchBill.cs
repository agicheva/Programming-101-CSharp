using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class TheBatchBill : IEnumerable
    {
        private List<Bill> listOfBills;

        public List<Bill> ListOfBills
        {
            get
            {
                return listOfBills;
            }

            set
            {
                listOfBills = value;
            }
        }

        public TheBatchBill(List<Bill> listOfBills)
        {
            this.listOfBills = listOfBills;
        }

        public int Count()
        {
            return listOfBills.Count;
        }

        public int Total()
        {
            int total = 0;

            for (int i = 0; i < listOfBills.Count; i++)
            {
                total += listOfBills[i].Value();
            }

            return total;
        }

        public override string ToString()
        {
            string format = string.Format("The {0} have {1} amount", listOfBills.Count, Total());
            return format;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in listOfBills)
            {
                yield return item;
            }
        }
    }
}
