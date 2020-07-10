using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Bit
{
    public static class TwoSingleNumbers
    {

        public static int[] findSingleNumbers(int[] nums)
        {
            // get the XOR of the all the numbers
            int n1xn2 = 0;
            foreach (int num in nums)
            {
                n1xn2 ^= num;
            }

            // get the rightmost bit that is '1'
            int rightmostSetBit = 1;
            while ((rightmostSetBit & n1xn2) == 0)
            {
                rightmostSetBit = rightmostSetBit << 1;
            }
            int num1 = 0, num2 = 0;
            foreach (int num in nums)
            {
                if ((num & rightmostSetBit) != 0) // the bit is set
                {
                    num1 ^= num;
                    Console.WriteLine($"num:{num}, num1:{num1}");

                }
                else // the bit is not set
                {
                    num2 ^= num;
                    Console.WriteLine($"num:{num}, num2:{num2}");
                }
            }
            return new int[] { num1, num2 }; 
        }

        public static void Execute()
        {
            int[] arr = new int[] { 1, 7, 5, 1, 3, 6, 6, 2, 3, 5 };
            int[] result = TwoSingleNumbers.findSingleNumbers(arr);
           Console.WriteLine("Single numbers are: " + result[0] + ", " + result[1]);

            //arr = new int[] { 2, 1, 3, 2 };
            //result = TwoSingleNumbers.findSingleNumbers(arr);
            //Console.WriteLine("Single numbers are: " + result[0] + ", " + result[1]);
        }
    }
}
