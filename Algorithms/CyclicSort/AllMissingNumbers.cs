using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class AllMissingNumbers
    {

        public static void findMissingNumber(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                //if (nums[i] < nums.Length && nums[i] != nums[nums[i]])
                //    swap(nums, i, nums[i]);
                //else
                //    i++;

                if (nums[i] ==nums[nums[i]] || nums[i] == i)
                    i++;
                else
                    swap(nums, i, nums[i]);

            }

            // find the first number missing from its index, that will be our required number
            Program.PrintArrays(nums);
            Console.WriteLine("");
            for (i = 0; i < nums.Length; i++)
             
            if (nums[i] != i)
                    Console.Write( i +",");

        }

        private static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void Execute()
        {
            Console.WriteLine("2,3,1,7,2,3,5,0");
            findMissingNumber(new int[] { 2,3,1, 7, 2, 3, 5, 0 });

           
        }
    }
}
