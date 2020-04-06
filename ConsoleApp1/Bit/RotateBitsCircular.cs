using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    public static class RotateBitsCircular
    {
        static int INT_BITS = 32;

        /* Function to left rotate n by d bits*/
        static int leftRotate(int n, int d)
        {

            /* In n<<d, last d bits are 0.  
            To put first 3 bits of n at 
            last, do bitwise or of n<<d with 
            n >>(INT_BITS - d) */
            return (n << d) | (n >> (INT_BITS - d));
        }

        /*Function to right rotate n by d bits*/
        static int rightRotate(int n, int d)
        {

            /* In n>>d, first d bits are 0.  
            To put last 3 bits of at 
            first, do bitwise or of n>>d  
            with n <<(INT_BITS - d) */
            return (n >> d) | (n << (INT_BITS - d));
        }

        // Driver code 
        public static void Execute()
        {
            int n = 16;
            int d = 5;

            Console.Write("Left Rotation of " + n
                                              + " by " + d + " is ");
            Console.Write(leftRotate(n, d));

            Console.Write("\nRight Rotation of " + n
                                                 + " by " + d + " is ");
            Console.Write(rightRotate(n, d));
        }
    }
}
