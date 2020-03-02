using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class DivisionWithoutOpertaor
    {
        static int integer_divide(int x, int y)
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

                return q + integer_divide(x - val, y);
            }

            return q;
        }

        public static void Execute()
        {
            int c = 4;
            c <<= 4;
            Console.WriteLine($"30/5:   {c}");

            Console.WriteLine($"30/5:   {integer_divide(30, 5)}");
            Console.WriteLine($"54/2:   {integer_divide(54, 2)}");
            Console.WriteLine($"51/13:   {integer_divide(51, 13)}");
            Console.WriteLine($"55/0:   {integer_divide(55, 0)}");

           
        }
    }
}
