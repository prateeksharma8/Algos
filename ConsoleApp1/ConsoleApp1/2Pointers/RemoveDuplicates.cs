using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2Pointers
{
    public static class RemoveDuplicates
    {

        public static void Execute()
        {
            int[] arr = new int[] { 2, 3, 3, 3, 6, 9, 9 };
            Console.WriteLine("\n2, 3, 3, 3, 6, 9, 9");
            print(arr,Remove(arr));

            arr = new int[] { 2, 2, 2, 11 };
            Console.WriteLine("\n2, 2, 2, 11");

            print(arr,Remove(arr));


            arr = new int[] { 2, 2, 2, 11,12 };
            Console.WriteLine("\n2, 2, 2, 11, 12");
            print(arr, Remove(arr));
        }

        public static int Remove(int[] arr)
        {
            int prev=arr[0], next=arr[0];
            int start = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[start-1] != arr[i])
                {
                    arr[start] = arr[i];
                    start++;
                }

            }
            return start;
        }

        static void print(int[] result, int last)
        {
            Console.WriteLine("\n");

            for (int i=0;i<last;i++)
            {
                Console.Write(" ");
                Console.Write(result[i]);
            }
        }
    }

}
