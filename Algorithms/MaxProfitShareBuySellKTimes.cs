using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class MaxProfitShareBuySellKTimes
    {
        static int maxProfit(int[] price, int n, int k)
        {
            // table to store results of subproblems 
            // profit[t][i] stores maximum profit using atmost 
            // t transactions up to day i (including day i) 
            int[,] profit = new int[k + 1, n + 1];

            // For day 0, you can't earn money 
            // irrespective of how many times you trade 
            for (int i = 0; i <= k; i++)
                profit[i, 0] = 0;

            // profit is 0 if we don't do any transation 
            // (i.e. k =0) 
            for (int j = 0; j <= n; j++)
                profit[0, j] = 0;

            // fill the table in bottom-up fashion 
            for (int i = 1; i <= k; i++)
            {
                int prevDiff = int.MinValue;
                for (int j = 1; j < n; j++)
                {
                    prevDiff = Math.Max(prevDiff,
                                    profit[i - 1, j - 1] - price[j - 1]);
                    profit[i, j] = Math.Max(profit[i, j - 1],
                                        price[j] + prevDiff);
                }
            }

            return profit[k, n - 1];
        }

        // Driver code to test above 
        public static void Execute()
        {
            int k = 2;
            int[] price = { 10, 22, 5, 75, 65, 80 };

            int n = price.Length;

            Console.Write("Maximum profit is: " +
                         maxProfit(price, n, k));
        }
    }
}
