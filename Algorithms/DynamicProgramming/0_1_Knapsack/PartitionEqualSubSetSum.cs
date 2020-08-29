using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming._0_1_Knapsack
{
    public class PartitionEqualSubSetSum
    {
        public static bool canPartition(int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
                sum += num[i];

            // if 'sum' is a an odd number, we can't have two subsets with equal sum
            //if (sum % 2 != 0)
            //    return false;

            return canPartitionRecursive(num, 6, 0);
        }

        private static bool canPartitionRecursive(int[] num, int sum, int currentIndex)
        {
            // base check
            if (sum == 0)
                return true;

            if (num.Length == 0 || currentIndex >= num.Length)
                return false;

            // recursive call after choosing the number at the currentIndex
            // if the number at currentIndex exceeds the sum, we shouldn't process this
            if (num[currentIndex] <= sum)
            {
                return canPartitionRecursive(num, sum - num[currentIndex], currentIndex + 1);
                    //return true;
            }
            // recursive call after excluding the number at the currentIndex
            return canPartitionRecursive(num, sum, currentIndex + 1);

        }

        public static void Execute()
        {
            int[] num = { 1, 2, 3, 7 };
           Console.WriteLine(canPartition(num));
            num = new int[] { 1, 2, 7, 1, 5 };
            Console.WriteLine(canPartition(num));
            num = new int[] { 1, 3, 100, 4 };
            Console.WriteLine(canPartition(num));
        }
    }
}
