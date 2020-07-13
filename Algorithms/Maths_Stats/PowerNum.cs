using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Maths_Stats
{
    public static class PowerNum
    {
        static double powerRec(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;

            double temp = powerRec(x, n / 2);
            if (n % 2 == 0)
            {
                return temp * temp;
            }
            else
            {
                return x * temp * temp;
            }
        }

        static double power(double x, int n)
        {
            bool isNegative = false;
            if (n < 0)
            {
                isNegative = true;
                n *= -1;
            }

            double result = powerRec(x, n);

            if (isNegative)
            {
                return 1 / result;
            }

            return result;
        }

        public static void Execute()
        {
            Console.WriteLine("Power(0, 0) = " + (power(0, 0)));
            Console.WriteLine("Power(2, 5) = " + (power(2, 5)));
            Console.WriteLine("Power(3, 4) = " + (power(3, 4)));
            Console.WriteLine("Power(1.5, 3) = " +(power(1.5, 3)));
            Console.WriteLine("Power(2, -2) = " + (power(2, -2)));
        }
    }
}
