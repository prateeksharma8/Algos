using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MaxSumSubArrayOfSizeK
    {
        public static int findMaxSumSubArray(int k, int[] arr)
        {
            int windowSum = arr[0] + arr[1], maxSum = 0;
            int windowStart = 0;
            for (int windowEnd = 2; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];
                maxSum = Math.Max(windowSum, maxSum);
                windowSum -= arr[windowStart++];

            }

            return maxSum;
        }

        public static void Execute()
        {
            Console.WriteLine("Maximum sum of a subarray of size K: "
                               + MaxSumSubArrayOfSizeK.findMaxSumSubArray(3, new int[] { 2, 1, 5, 1, 3, 10 }));
            Console.WriteLine("Maximum sum of a subarray of size K: " + MaxSumSubArrayOfSizeK.findMaxSumSubArray(2, new int[] { 2, 3, 4, 1, 5 }));
        }
    }
}
