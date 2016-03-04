using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void AverageChange(object sender, decimal oldAverage, decimal newAverage);

    class AverageAggregator
    {
        private decimal average;
        private decimal sum;
        private int count;
        private List<decimal> list;
        public static event AverageChange AverageChanged;

        public decimal Average
        {
            get
            {
                return average;
            }
        }

        public AverageAggregator(AverageChange averageChangeDelegate)
        {
            sum = 0;
            average = 0;
            AverageChanged += averageChangeDelegate;
        }

        public void AddNumber(decimal number)
        {   
            decimal currAverage = average;
            sum += number;
            average = sum / ++count;
            if (currAverage != average)
            {
                AverageChanged(this, currAverage, average);
            }
        }
    }
}
