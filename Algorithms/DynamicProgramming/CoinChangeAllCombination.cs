using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public static class CoinChangeAllCombination
    {
        // Returns the count of ways we can  
        // sum S[0...m-1] coins to get sum n 
        static int count(int[] coins, int len, int amount)
        {
            // If n is 0 then there is 1 solution  
            // (do not include any coin) 
            if (amount == 0)
                return 1;

            // If n is less than 0 then no  
            // solution exists 
            if (amount < 0)
                return 0;

            // If there are no coins and n  
            // is greater than 0, then no 
            // solution exist 
            if (len <= 0 && amount >= 1)
                return 0;

            // count is sum of solutions   
            // (i) including S[len-1] (ii) excluding S[len-1] 
            return count(coins, len - 1, amount) +
                count(coins, len, amount - coins[len - 1]);
        }

        // Driver program 
        public static void Execute()
        {

            int[] coins = { 3, 5, 10 };
            int coinsLength = coins.Length;
            Console.WriteLine(count(coins, coinsLength, 3));
            Console.WriteLine(count(coins, coinsLength, 4));
            Console.WriteLine(count(coins, coinsLength, 5));
            Console.WriteLine(count(coins, coinsLength, 6));
            Console.WriteLine(count(coins, coinsLength, 7));
            Console.WriteLine(count(coins, coinsLength, 8));
            Console.WriteLine(count(coins, coinsLength, 9));

            Console.WriteLine(count(coins, coinsLength, 22));




        }
    }
}
