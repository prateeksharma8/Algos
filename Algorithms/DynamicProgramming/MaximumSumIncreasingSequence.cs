using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class MaximumSumIncreasingSequence
    {
        public static int findMSIS(int[] nums)
        {
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];

            //int maxSum = nums[0];
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    dp[i] = nums[i];
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (nums[i] > nums[j] && dp[i] < dp[j] + nums[i])
            //            dp[i] = dp[j] + nums[i];
            //    }
            //    maxSum = Math.Max(maxSum, dp[i]);
            //}

            int maxSum = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                int start = i;
                int sum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[start] < nums[j])
                    {
                        sum += nums[j];
                        start = j;
                    }
                }
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum;
        }

        public static void Execute()
        {

            int[] nums = { 4, 1, 2, 6, 10, 1, 12 };
            Console.WriteLine(findMSIS(nums));
            nums = new int[] { -4, 10, 3, 7, 15 };
            Console.WriteLine(findMSIS(nums));
            nums = new int[] { 1, 3, 8, 4, 14, 6, 14, 1, 9, 4, 13, 3, 11, 17, 29 };
            Console.WriteLine(findMSIS(nums));
        }
    }
}
