using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class CyclicSort
    {

        public static int[] sort(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] == i + 1)
                {
                    i++;
                }
                else
                {
                    swap(nums, i, nums[i]-1);
                }
            }
            return nums;
        }


        private static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void Execute()
        {
            Console.WriteLine("4, 3, 1, 2");
            Console.WriteLine(sort(new int[] { 4, 3, 1, 2 }));

          
        }
    }
}
