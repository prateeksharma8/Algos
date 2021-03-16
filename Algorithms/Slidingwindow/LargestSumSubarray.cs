using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class LargestSumSubarray
    {
        static int findMaxSumSubArray(int[] A)
        {
            if (A.Length < 1)
            {
                return 0;
            }

            int currMax = A[0];
            int globalMax = A[0];
            for (int i = 1; i < A.Length; ++i)
            {

                if (currMax < 0)
                {
                    currMax = A[i];
                }
                else
                {
                    currMax += A[i];
                }

                if (globalMax < currMax)
                {
                    globalMax = currMax;
                }
            }

            return globalMax;
        }

        public static void Execute()
        {
            Console.WriteLine("Sum of largest subarray: " + findMaxSumSubArray(new int[] { 50, -1, 30, 1, 2, 3, 6, -5, 1 }));

            Console.WriteLine("Sum of largest subarray: "+ findMaxSumSubArray( new int[] { -4, 2, -5, 1, 2, 3, 6, -5, 1 }));
            Console.WriteLine("Sum of largest subarray:  " + findMaxSumSubArray(new int[] { 2, 3, 4, 1, 5 }));
        }
    }
}
