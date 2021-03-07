using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class GameScoring
    {
        public static int scoringOptionsRec(int n, int[] result)
        {
            if (n < 0)
            {
                return 0;
            }
            if (n == 1 || n==0)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
          
            //if (result[n] > 0)
            //{
            //    return result[n];
            //}

            //Memoize
            return scoringOptionsRec(n - 1, result) +
                        scoringOptionsRec(n - 2, result) +
                        scoringOptionsRec(n - 4, result);

            //return result[n];
        }

        public static int scoringOptions(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
           

            int[] result = new int[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                result[i] = -1;
            }
            result[0] = 1;

           Console.WriteLine( scoringOptionsRec(n, result));

            return result[n];
        }
        public static void Execute()
        {
            Console.WriteLine("Number of ways score 5 can be reached = " + scoringOptions(5));
            Console.WriteLine("Number of ways score 5 can be reached = " + scoringOptions(6));
            Console.WriteLine("Number of ways score 5 can be reached = " + scoringOptions(7));
            Console.WriteLine("Number of ways score 5 can be reached = " + scoringOptions(8));


        }
    }
}
