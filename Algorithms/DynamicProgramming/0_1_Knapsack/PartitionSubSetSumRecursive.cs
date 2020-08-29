using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming._0_1_Knapsack
{
    public class PartitionSubSetSumRecursive
    {
        //Input: {1, 2, 3, 9}
        //Output: 3
        //Explanation: We can partition the given set into two subsets where minimum absolute difference
        //between the sum of numbers is '3'. Following are the two subsets: {1, 2, 3} & {9}.
        public static int canPartition(int[] num)
        {
            return canPartitionRecursive(num, 0, 0, 0);
        }

        private static int canPartitionRecursive(int[] num, int currentIndex, int sum1, int sum2)
        {
            // base check
            if (currentIndex == num.Length)
                return Math.Abs(sum1 - sum2);

            // recursive call after including the number at the currentIndex in the first set
            int diff1 = canPartitionRecursive(num, currentIndex + 1, sum1 + num[currentIndex], sum2);

            // recursive call after including the number at the currentIndex in the second set
            int diff2 = canPartitionRecursive(num, currentIndex + 1, sum1, sum2 + num[currentIndex]);

            return Math.Min(diff1, diff2);
        }

        public static void Execute()
        {
            int[] num = { 1, 2, 3, 9 };
           Console.WriteLine(canPartition(num));
            num = new int[] { 1, 2, 7, 1, 5 };
            Console.WriteLine(canPartition(num));
            num = new int[] { 1, 3, 100, 4 };
            Console.WriteLine(canPartition(num));
        }
    }
}
