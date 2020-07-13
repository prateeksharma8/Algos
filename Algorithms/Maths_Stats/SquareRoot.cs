using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Maths_Stats
{
    public static class SquareRoot
    {
        private static  double EPSILON = 0.000000000000001;

        public static double squareRoot(double num)
        {
            double low = 0;


            // square root can never be more than 
            // half of number except if number is <= 1
            // so square root of any number always lie
            // between 0 and 1 + (num / 2)
            double high = 1 + num / 2;

            while (low < high)
            {

                double mid = (low + high) / 2;
                double sqr = mid * mid;

                // we can't do a == b for doubles because
                // of rounding errors, so we use error threshold
                // EPSILON. Two doubles a and b are equal if 
                //  abs(a-b) <= EPSILON

                double diff = Math.Abs(num - sqr);

                if (diff <= EPSILON)
                {
                    return mid;
                }

                if (sqr < num)
                {
                    low = mid;
                }
                else
                {
                    high = mid;
                }
            }

            return -1;
        }

        public static void Execute()
        {
            double[] arr = { 16, 17, 2.25 };
            foreach (double i in arr)
               Console.WriteLine("Square root of " + i + " is " + squareRoot(i));
        }
    }
}
