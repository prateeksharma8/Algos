using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DynamicProgramming
{
    public class Staircase
    {
        public int CountWays(int n, int[] dp=null )
        {

            if (n == 0)
                return 1; // base case, we don't need to take any step, so there is only one way

            if (n == 1)
                return 1; // we can take one step to reach the end, and that is the only way

            if (n == 2)
                return 2; // we can take one step twice or jump two steps to reach at the top

            // if we take 1 step, we are left with 'n-1' steps;
            int take1Step = CountWays(n - 3);
            // similarly, if we took 2 steps, we are left with 'n-2' steps;
            int take2Step = CountWays(n - 2);
            // if we took 3 steps, we are left with 'n-3' steps;
            int take3Step = CountWays(n - 1);

            return take1Step + take2Step + take3Step;
        }

        public static void Execute()
        {
            Staircase sc = new Staircase();
            //Console.WriteLine(sc.CountWays(3, new int[3+1]));
            Console.WriteLine(sc.CountWays(7, new int[10+1]));
            Console.WriteLine(sc.CountWays(5, new int[5+1]));
        }
    }
}