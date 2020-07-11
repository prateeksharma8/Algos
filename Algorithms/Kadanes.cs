using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class Kaden
    {
        public static void Execute()
        {
            int[] array = new int[] { 1, 5, -1, 0, 10 };
            int n = array.Length;
            int[] dp = new int[n];

            //base condition
            dp[0] = array[0];

            int answer = 0;
            for (int i = 1; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], 0) + array[i];
                answer = Math.Max(answer, dp[i]);
            }
            Console.WriteLine( answer);
        }
    }
}
