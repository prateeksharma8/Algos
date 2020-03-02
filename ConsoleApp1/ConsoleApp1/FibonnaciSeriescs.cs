using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FibonacciSeries
    {
        public static void Execute()
        {
            int count = 0;
            int num = 4;
            Console.WriteLine($"{num}th Fibonacci is ---> " + CalculateFibonacci(num, ref count));
            //Console.WriteLine("6th Fibonacci is ---> " + fib.CalculateFibonacci(6));
            //Console.WriteLine("7th Fibonacci is ---> " + fib.CalculateFibonacci(7));
            Console.WriteLine($"count {count}");
        }
        private static int CalculateFibonacci(int n, ref int count, string fname = "start")
        {
            count++;

            if (n < 2)
            {
                //Console.WriteLine($"{count}, Data:{n},  return:{n} fname:{fname}");
                return n;
            }
            else
            {
                //Console.WriteLine($"{count}, Data:{n} fname:{fname}");
            }

            int result = CalculateFibonacci(n - 1, ref count, "f1") + CalculateFibonacci(n - 2, ref count, "f2");
            Console.WriteLine($"{count},number {n} result:{result},fname:{fname} ");

            return result;
        }


    }
}
