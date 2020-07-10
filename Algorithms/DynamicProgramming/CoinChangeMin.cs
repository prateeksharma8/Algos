using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public static class CoinChangeMin
    {



        public static int CountWaysRecursive(int[] denominations, int total)
        {
            int n = denominations.Length;
            int[][] dp = new int[n] [];

            for (int i = 0; i < n; i++)
                for (int j = 0; j <= total; j++)
                    dp[i][j] = Int32.MaxValue;

            // populate the total=0 columns, as we don't need any coin to make zero total
            for (int i = 0; i < n; i++)
                dp[i][0] = 0;

            for (int i = 0; i < n; i++)
            {
                for (int t = 1; t <= total; t++)
                {
                    if (i > 0)
                        dp[i][t] = dp[i - 1][t]; //exclude the coin
                    if (t >= denominations[i])
                    {
                        if (dp[i][t - denominations[i]] != Int32.MaxValue)
                            dp[i][t] = Math.Min(dp[i][t], dp[i][t - denominations[i]] + 1); // include the coin
                    }
                }
            }

            // total combinations will be at the bottom-right corner.
            return (dp[n - 1][total] == Int32.MaxValue ? -1 : dp[n - 1][total]);
        }

        

        public static void Execute()
        {
            int amount = 3;
            int[] denominations = new[] { 1, 2, 3 };
             int ways = CountWaysRecursive(denominations, amount);
        }
    }
}
