using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAX
{
    class CountryVATTAX
    {
        private readonly string countryID;
        private readonly double vatTax;
        private readonly bool isDefault;

        public string CountryID
        {
            get
            {
                return countryID;
            }
        }

        public double VATTax
        {
            get
            {
                return vatTax;
            }
        }

        public bool IsDefault
        {
            get
            {
                return isDefault;
            }
        }

        public CountryVATTAX(string countryID, double vatTax, bool isDefault)
        {
            this.countryID = countryID;
            this.vatTax = vatTax;
            this.isDefault = isDefault;
        }
    }
}
