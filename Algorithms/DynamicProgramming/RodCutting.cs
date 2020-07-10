using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public static class RodCutting
    {

        public static int[][] solveRodCutting(int[] lengths, int[] prices, int n)
        {
            // base checks
            if (n <= 0 || prices.Length == 0 || prices.Length != lengths.Length)
                return null;

            int lengthCount = lengths.Length;
            int[][] dp = new int[lengthCount][];

            // process all rod lengths for all prices
            for (int i = 0; i < lengthCount; i++)
            {
                for (int len = 1; len <= n; len++)
                {
                    int p1 = 0, p2 = 0;
                    if (lengths[i] <= len)
                        p1 = prices[i] + dp[i][len - lengths[i]];
                    if (i > 0)
                        p2 = dp[i - 1][len];
                    dp[i][len] = Math.Max(p1, p2);
                }
            }

            // maximum price will be at the bottom-right corner.
            return dp;
        }

        public static void Execute()
        {
          
            int[] lengths = { 1, 2, 3, 4, 5 };
            int[] prices = { 2, 6, 7, 10, 13 };
            int rodLength = 5;
            var dp = solveRodCutting(lengths, prices, rodLength);
            Console.WriteLine( dp[lengths.Length - 1][rodLength]);
        }
    }
}
