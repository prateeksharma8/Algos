using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bit
{
    public static class FindDuplicatecs
    {
        public static int findSingleNumber(int[] arr)
        {
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                num = num ^ arr[i];
                Console.WriteLine($"i:{i}, arr[{i}]:{arr[i]}, num:{num}");
            }
            return num;
        }

        public static void Execute( )
        {
            Console.WriteLine(findSingleNumber(new int[] { 1, 4, 2, 1, 3, 2, 3 }));
        }
    }
}
