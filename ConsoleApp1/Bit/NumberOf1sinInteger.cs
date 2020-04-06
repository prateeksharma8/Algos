using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class NumberOf1sinInteger
    {


        /* Function to get no of set bits in binary
        representation of passed binary no. */
        static int countSetBits(int n)
        {
            int count = 0;
            while (n!=0)
            {               
                n &= (n - 1);                
                count++;                
            }
            return count;
        }

        /* Program to test function countSetBits */
        public static void Execute()
        {
            int i = 8;
            Console.WriteLine( countSetBits(i));            
        }

    }
}
