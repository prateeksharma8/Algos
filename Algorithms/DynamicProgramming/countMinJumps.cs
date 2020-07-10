using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class ArrayJump
    {
        public static int CountMinJumps(int[] jumps, int[] dp)
        {
            //initialize with infinity, except the first index which should be zero as we start from there
            for (int i = 1; i < jumps.Length; i++)
                dp[i] = Int32.MaxValue;

            for (int start = 0; start < jumps.Length - 1; start++)
            {
                for (int end = start + 1; end <= start + jumps[start] && end < jumps.Length; end++)
                    dp[end] = Math.Min(dp[end], dp[start] + 1);
            }

            return dp[jumps.Length - 1];
        }


        public static void Execute()
        {
            //Console.WriteLine(sc.CountWays(3, new int[3+1]));
            Console.WriteLine(CountMinJumps(new int[] { 2, 1, 1, 1, 4 }, new int[5 + 1]));
            Console.WriteLine(CountMinJumps(new int[] { 1, 1, 3, 6, 9, 3, 0, 1, 3 }, new int[9 + 1]));
        }
    }
}
