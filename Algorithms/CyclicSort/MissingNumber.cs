using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CyclicSort
{
    public static class MissingNumber
    {

        public static int findMissingNumber(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] < nums.Length && nums[i] != nums[nums[i]])
                    swap(nums, i, nums[i]);
                else
                    i++;
            }

            // find the first number missing from its index, that will be our required number
            for (i = 0; i < nums.Length; i++)
                if (nums[i] != i)
                    return i;

            return nums.Length;
        }

        private static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void Execute()
        {
            Console.WriteLine("4, 0, 3, 1");
            Console.WriteLine(MissingNumber.findMissingNumber(new int[] { 4, 0, 3, 1 }));

            Console.WriteLine("8, 3, 5, 2, 4, 6, 0, 1");
            Console.WriteLine(MissingNumber.findMissingNumber(new int[] { 8, 3, 5, 2, 4, 6, 0, 1 }));
        }
    }
}
