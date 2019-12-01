using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMFractions
{
    class Fraction
    {
        protected long Numerator;
        protected long Denominator;

        public Fraction(long x, long y)
        {
            Numerator = x;
            Denominator = y;
            Reduction(Numerator, Denominator);
        }

        public Fraction(double x)
        {
            long i = 1;
            while (x != (long)x)
            {
                x = x * 10;
                Numerator = (long)x;
                Denominator = (long)Math.Pow(10, i);
                i++;
            }
            Reduction(Numerator, Denominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            long CNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            long CDenominator = a.Denominator * b.Denominator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator +(Fraction a, long b)
        {
            long CNumerator = a.Numerator + b * a.Denominator;
            long CDenominator = a.Denominator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator +(long a, Fraction b)
        {
            a = a * b.Denominator;
            long CNumenator = a + b.Numerator;
            long CDenominator = b.Denominator;
            Fraction c = new Fraction(CNumenator, CDenominator);
            return c;
        }

        public static Fraction operator -(Fraction a)
        {
            long CNumerator = -a.Numerator;
            long CDenominator = a.Denominator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            long CNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            long CDenominator = a.Denominator * b.Denominator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator -(Fraction a, long b)
        {
            long CNumerator = a.Numerator - b * a.Denominator;
            long CDenominator = a.Denominator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator -(long a, Fraction b)
        {
            long CNumerator = a * b.Denominator - b.Numerator;
            long CDenominator = b.Denominator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            long CNumerator = a.Numerator * b.Numerator;
            long CDenominator = a.Denominator * b.Denominator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator *(Fraction a, long b)
        {
            long CNumerator = a.Numerator * b;
            long CDenominator = a.Denominator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator *(long a, Fraction b)
        {
            long CNumerator = b.Numerator * a;
            long CDenominator = b.Denominator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            long CNumerator = a.Numerator * b.Denominator;
            long CDenominator = a.Denominator * b.Numerator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator /(Fraction a, long b)
        {
            long CNumerator = a.Numerator;
            long CDenominator = a.Denominator * b;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static Fraction operator /(long a, Fraction b)
        {
            long CNumerator = b.Numerator;
            long CDenominator = a * b.Numerator;
            Fraction c = new Fraction(CNumerator, CDenominator);
            return c;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            long temp = a.Denominator;
            a.Numerator *= b.Denominator;
            b.Numerator *= temp;
            if(a.Numerator > b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            long temp = a.Denominator;
            a.Numerator *= b.Denominator;
            b.Numerator *= temp;
            if (a.Numerator < b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Fraction a, long b)
        {
            b = b * a.Denominator;
            if (a.Numerator > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Fraction a, long b)
        {
            b = b * a.Denominator;
            if (a.Numerator < b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(long a, Fraction b)
        {
            a = a * b.Denominator;
            if (a > b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(long a, Fraction b)
        {
            a = a * b.Denominator;
            if (a < b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(Fraction a, Fraction b)
        {
            long temp = a.Denominator;
            a.Numerator *= b.Denominator;
            b.Numerator *= temp;
            if (a.Numerator >= b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            long temp = a.Denominator;
            a.Numerator *= b.Denominator;
            b.Numerator *= temp;
            if (a.Numerator <= b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(Fraction a, long b)
        {
            b = b * a.Denominator;
            if (a.Numerator >= b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Fraction a, long b)
        {
            b = b * a.Denominator;
            if (a.Numerator <= b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(long a, Fraction b)
        {
            a = a * b.Denominator;
            if (a >= b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(long a, Fraction b)
        {
            a = a * b.Denominator;
            if (a <= b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            a.Numerator *= b.Denominator;
            b.Numerator *= a.Denominator;
            if(a.Numerator == b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            a.Numerator *= b.Denominator;
            b.Numerator *= a.Denominator;
            if (a.Numerator != b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Fraction a, long b)
        {
            b *= a.Denominator;
            if (a.Numerator == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Fraction a, long b)
        {
            b *= a.Denominator;
            if (a.Numerator != b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(long a, Fraction b)
        {
            a *= b.Denominator;
            if(a == b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(long a, Fraction b)
        {
            a *= b.Denominator;
            if (a != b.Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static implicit operator double(Fraction a)
        {
            double c = a.Numerator / a.Denominator;
            return c;
        }

        public override string ToString()
        {
            if (Numerator == 0)
            {
                return "0";
            }
            else
            {
                return Numerator + "/" + Denominator;
            }
        }

        public void Reduction(long x, long y)
        {
            int nsd = 1;
            for (int i = 1; i < (Math.Abs(x) * Math.Abs(y) + 1); i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    nsd = i;
                }
            }
            Numerator = Numerator / nsd;
            Denominator = Denominator / nsd;
            if(Denominator < 0 && Numerator > 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

    }
}
