using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAX
{
    class VATTAXCalculator
    {
        private readonly List<CountryVATTAX> countries;

        public VATTAXCalculator(List<CountryVATTAX> countries)
        {
            foreach (var item in countries)
            {
                this.countries = countries;
            }
        }

        public double CalculateTax(double itemPrice, string countryID)
        {
            double tax = 0;

            foreach (var country in countries)
            {
                if (countryID == country.CountryID)
                {
                    tax = itemPrice * country.VATTax;
                    return tax;
                }
            }
            throw new NotSupportedCountryException("Cannot find the countryID in the database.");
        }    
    }

    public class NotSupportedCountryException : Exception
    {
        public NotSupportedCountryException()
        { 

        }

        public NotSupportedCountryException(string message) : base(message)
        {

        }
    }
}
