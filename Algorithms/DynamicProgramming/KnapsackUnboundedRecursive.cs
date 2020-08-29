using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
        //Denominations: {1,2,3}
        //Total amount: 5
        //Output: 5
        //Explanation: There are five ways to make the change for '5', here are those ways:
        //  1. { 1,1,1,1,1}
        //2. { 1,1,1,2}
        //3. { 1,2,2}
        //4. { 1,1,3}
        //5. { 2,3}
public class KnapsackUnboundedRecursive
    {
        public static int solveKnapsack(int[] profits, int[] weights, int capacity)
        {
            return knapsackRecursive(profits, weights, capacity, 0);
        }
        private static int knapsackRecursive(int[] profits, int[] weights, int capacity, int currentIndex)
        {
            // base checkshny6kj,j
            if (capacity <= 0 || profits.Length == 0 || weights.Length != profits.Length ||
            currentIndex < 0 || currentIndex >= profits.Length)
                return 0;
            // recursive call after choosing the items at the currentIndex, note that we recursive call on all
            // items as we did not increment currentIndex
            int profit1 = 0;
            if (weights[currentIndex] <= capacity)
                profit1 = profits[currentIndex] + knapsackRecursive(profits, weights,capacity - weights[currentIndex], currentIndex);
            // recursive call after excluding the element at the currentIndex
            int profit2 = knapsackRecursive(profits, weights, capacity, currentIndex + 1);
            return Math.Max(profit1, profit2);
        }
        public static void Execute()
        {
           
            int[] profits = { 2, 6, 7, 10,13 };
            int[] weights = { 1, 2,3, 4, 5 };
            int maxProfit = solveKnapsack(profits, weights, 5);
           Console.WriteLine(maxProfit);
        }
    }
}
