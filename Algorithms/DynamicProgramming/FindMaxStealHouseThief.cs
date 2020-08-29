using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class FindMaxStealHouseThief
    {
        public static int findMaxSteal(int[] wealth)
        {
            return findMaxStealRecursive(wealth, 0);
        }

        private static int findMaxStealRecursive(int[] wealth, int currentIndex)
        {
            if (currentIndex >= wealth.Length)
                return 0;

            // steal from current house and skip one to steal from the next house
            int stealCurrent = wealth[currentIndex] + findMaxStealRecursive(wealth, currentIndex + 2);
            // skip current house to steel from the adjacent house
            int skipCurrent = findMaxStealRecursive(wealth, currentIndex + 1);

            return Math.Max(stealCurrent, skipCurrent);
        }

        public static void Execute()
        {
        
            int[] wealth = { 2, 5, 1, 3, 6, 2, 4 };
           Console.WriteLine(findMaxSteal(wealth));
            wealth = new int[] { 2, 10, 14, 8, 1 };
            Console.WriteLine(findMaxSteal(wealth));
        }
    }
}
