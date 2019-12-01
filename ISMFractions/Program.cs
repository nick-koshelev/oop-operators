using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(3, 2);
            Fraction b = new Fraction(6, -4);
            Fraction c = new Fraction(7, 8);
            Fraction e = new Fraction(4, 1);
            Console.WriteLine("Обычныя дробь - " + a);
            Console.WriteLine("Сокращённая дробь 6/-4 - " + b);
            Fraction d = a + c;
            Console.WriteLine("Сумма 3/2 и 7/8 - " + d);
            d = a - c;
            Console.WriteLine("Разность 3/2 и 7/8 - " + d);
            d = a * c;
            Console.WriteLine("Произвидение 3/2 и 7/8 - " + d);
            d = a / c;
            Console.WriteLine("Частное 3/2 и 7/8 - " + d);
            Console.WriteLine("Сравнения:");
            if (a < c)
            {
                Console.WriteLine("3/2 < 7/8");
            }
            else if (a > c)
            {
                Console.WriteLine("3/2 > 7/8");
            }
            if (a == c)
            {
                Console.WriteLine("1");
            }
            else if (a != c)
            {
                Console.WriteLine("3/2 != 7/8");
            }
            else
            {
                Console.WriteLine("2");
            }
            if (a < 2 && 2 > a)
            {
                Console.WriteLine("3/2 < 2");
            }
            else if (a > 2 && 2 < a)
            {
                Console.WriteLine("3/2 > 2");
            }
            if(e != 4 && 4 != e)
            {
                Console.WriteLine("4/1 != 4");
            }else if(e == 4 && 4 == e)
            {
                Console.WriteLine("4/1 == 4");
            }
        }
    }
}