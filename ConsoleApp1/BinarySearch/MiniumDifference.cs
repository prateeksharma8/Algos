using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.BinarySearch
{
    public static class MinimumDifference
    {

        public static int searchMinDiffElement(int[] arr, int key)
        {
            if (key < arr[0])
                return arr[0];
            if (key > arr[arr.Length - 1])
                return arr[arr.Length - 1];

            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (key < arr[mid])
                {
                    end = mid - 1;
                }
                else if (key > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    return arr[mid];
                }
            }

            // at the end of the while loop, 'start == end+1'
            // we are not able to find the element in the given array
            // return the element which is closest to the 'key'
            if ((arr[start] - key) < (key - arr[end]))
                return arr[start];
            return arr[end];
        }

        public static void Execute()
        {
            Console.WriteLine(MinimumDifference.searchMinDiffElement(new int[] { 4, 6, 10 }, 7));
            Console.WriteLine(MinimumDifference.searchMinDiffElement(new int[] { 4, 6, 10 }, 4));
            Console.WriteLine(MinimumDifference.searchMinDiffElement(new int[] { 1, 3, 8, 10, 15 }, 12));
            Console.WriteLine(MinimumDifference.searchMinDiffElement(new int[] { 4, 6, 10 }, 17));
        }
    }
}
