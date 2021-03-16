using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming._0_1_Knapsack
{
    public class PartitionEqualSubSetSumRecursive
    {
        public static bool canPartition(int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
                sum += num[i];

            //if 'sum' is a an odd number, we can't have two subsets with equal sum
            if (sum % 2 != 0)
                return false;

            return canPartitionRecursive(num, sum/2, 0);
        }

        private static bool canPartitionRecursive(int[] num, int sum, int currentIndex)
        {
            if (sum < 0)
                return false;

            if (sum == 0)
                return true;

            for (int i= currentIndex; i<num.Length;i++)
            {
                return canPartitionRecursive(num, sum - num[i], currentIndex + 1) || canPartitionRecursive(num, sum , currentIndex + 1);
            }
            return false;

        }

        public static void Execute()
        {
            int[] num = { 2, 3, 4, 5 };
           Console.WriteLine(canPartition(num));
            num = new int[] { 1, 2, 7, 1, 5 };
            Console.WriteLine(canPartition(num));
            num = new int[] { 1, 3, 100, 4 };
            Console.WriteLine(canPartition(num));
        }
    }
}
