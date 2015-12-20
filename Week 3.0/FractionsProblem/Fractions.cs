using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsProblem
{
    class Fractions
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get
            {
                return numerator;
            }

            set
            {
                numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }

            set
            {
                denominator = value;
            }
        }

        public Fractions()
        {

        }

        public Fractions(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override string ToString()
        {
            string format = string.Format("{0}/{1}", numerator, denominator);
            return format;
        }

        public override bool Equals(object first)
        {
            Fractions firstFraction = (Fractions)first;
            if (firstFraction.numerator == numerator && firstFraction.denominator == denominator)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool operator ==(Fractions first, Fractions second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(Fractions first, Fractions second)
        {
            return !Equals(first, second);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + numerator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                return hash;
            }
        }

        public static Fractions operator+(Fractions first, Fractions second)
        {
            Fractions sum = new Fractions();
            int xFirst = first.numerator;
            int yFirst = first.denominator;
            int xSecond = second.numerator;
            int ySecond = second.denominator;

            int differenceFirst = 0;
            int differenceSecond = 0;
            int NOK = 0;

            if (yFirst == ySecond)
            {
                sum.numerator = xFirst + xSecond;
                sum.denominator = yFirst;

                return sum;
            }

            else
            {
                NOK = yFirst * ySecond;
                differenceFirst = NOK / yFirst;
                differenceSecond = NOK / ySecond;

                xFirst *= differenceFirst;
                yFirst *= differenceFirst;

                xSecond *= differenceSecond;
                ySecond *= differenceSecond;

                sum.numerator = xFirst + xSecond;
                sum.denominator = ySecond;

                return sum;
            }
        }
        
        public static Fractions operator-(Fractions first, Fractions second)
        {
            Fractions odd = new Fractions();
            int xFirst = first.numerator;
            int yFirst = first.denominator;
            int xSecond = second.numerator;
            int ySecond = second.denominator;

            int differenceFirst = 0;
            int differenceSecond = 0;
            int NOK = 0;

            if (yFirst == ySecond)
            {
                odd.numerator = xFirst - xSecond;
                odd.denominator = yFirst;

                return odd;
            }

            else
            {
                NOK = yFirst * ySecond;
                differenceFirst = NOK / yFirst;
                differenceSecond = NOK / ySecond;

                xFirst *= differenceFirst;
                yFirst *= differenceFirst;

                xSecond *= differenceSecond;
                ySecond *= differenceSecond;

                odd.numerator = xFirst - xSecond;
                odd.denominator = ySecond;

                return odd;
            }
        }

        public static Fractions operator*(Fractions first, Fractions second)
        {
            Fractions mult = new Fractions();

            mult.numerator = first.numerator * second.numerator;
            mult.denominator = first.denominator * second.denominator;

            return mult;
        }

        public static Fractions operator/(Fractions first, Fractions second)
        {
            Fractions devide = new Fractions();

            devide.numerator = first.numerator * second.denominator;
            devide.denominator = first.denominator * second.numerator;

            return devide;
        }

        public static double operator+(Fractions first, double second)
        {
           double sum = 0;
           double doubleFirst = (double)first;

            sum = doubleFirst + second;
            return sum;
        }

        public static double operator-(Fractions first, double second)
        {
            double odd = 0;
            double doubleFirst = (double)first;

            odd = doubleFirst - second;
            return odd;
        }

        public static double operator*(Fractions first, double second)
        {
            double mult = 0;
            double doubleFirst = (double)first;

            mult = doubleFirst * second;
            return mult;
        }

        public static double operator/(Fractions first, double second)
        {
            double devide = 0;
            double doubleFirst = (double)first;

            devide = doubleFirst / second;
            return devide;
        }

        public static explicit operator double (Fractions fraction)
        {
            double doubleFraction = (double)fraction.numerator / (double)fraction.denominator;
            return doubleFraction;
        }
    }
}
