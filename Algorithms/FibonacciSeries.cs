using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class FibonacciSeries
    {
        public static void Execute()
        {
            int number = 10;

            //int[] result = new int[10];
            //result[0] = 0;
            //result[1] = 1;
            int prev = 0, start = 1, result=0;
            int i = 1;
            Console.Write(prev + " " + start);
            //Console.WriteLine(result[0] + result[1]);
            while (i< number-1)
            {
                //result[i+1] = result[i] + result[i - 1];
                //Console.WriteLine(result[i+1]);

                
                result = start + prev;
                Console.Write(" " +result);
                prev = start;
                start = result;
                
                
                i++;
            }

            //Console.WriteLine(String.Join(" ", result));
        }
    }
}
