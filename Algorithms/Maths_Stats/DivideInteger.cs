using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Maths_Stats
{
    public static class DivideInteger
    {
        public static int integerDivide(int x, int y)
        {

            // We will return -1 if the
            // divisor is '0'.
            if (y == 0)
            {
                return -1;
            }

            if (x < y)
            {
                return 0;
            }
            else if (x == y)
            {
                return 1;
            }
            else if (y == 1)
            {
                return x;
            }

            int q = 1;
            int val = y;

            while (val < x)
            {
                val <<= 1;
                // we can also use 'val = val + val;'
                q <<= 1;
                // we can also use 'q = q + q;'
            }

            if (val > x)
            {
                val >>= 1;
                q >>= 1;

                return q + integerDivide(x - val, y);
            }

            return q;
        }

        public static void Execute()
        {
            Console.WriteLine("7/2 = " + integerDivide(7, 2));
            Console.WriteLine("5/4 = " + integerDivide(5, 4));
            Console.WriteLine("1/3 = " + integerDivide(1, 3));
            Console.WriteLine("40/5 = " + integerDivide(40, 5));
            Console.WriteLine("40/4 = " + integerDivide(40, 4));
        }
    }
}
