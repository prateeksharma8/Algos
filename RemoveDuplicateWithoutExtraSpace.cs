using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class RemoveDuplicateWithoutExtraSpace
    {
        public static int remove(int[] arr)
        {
            int startPosition=1;
            for (int i = 1;i < arr.Length; i++)
            {
                if (arr[startPosition-1] != arr[i])
                {
                    arr[startPosition++] = arr[i];
                }
            }
            return startPosition;
        }

        public static void Execute()
        {
            int[] arr = new int[] { 1,2, 3, 3, 3,3,3,5, 6,6, 9, 9,10 };
            Console.WriteLine(remove(arr));

            arr = new int[] { 2, 2, 2, 11 };
            Console.WriteLine(remove(arr));
        }
    }
}
