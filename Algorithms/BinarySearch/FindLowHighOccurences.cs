using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearch
{
   public class FindLowHighOccurences
    { 
        static int findLowIndex(List<int> arr, int key)
        {
            int low = 0;
            int high = arr.Count - 1;
            int mid = high / 2;

            while (low <= high)
            {

                int midElem = arr[mid];

                if (midElem < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

                mid = low + (high - low) / 2;
            }

            if (low < arr.Count && arr[low] == key)
            {
                return low;
            }

            return -1;
        }

        static int findHighIndex(List<int> arr, int key)
        {
            int low = 0;
            int high = arr.Count - 1;
            int mid = high / 2;

            while (low <= high)
            {

                int midElem = arr[mid];

                if (midElem <= key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

                mid = low + (high - low) / 2;
            }

            if (high == -1)
            {
                return high;
            }

            if (high < arr.Count && arr[high] == key)
            {
                return high;
            }

            return -1;
        }
        public static void Execute()
        {
            List<int> array = new List<int> { 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 6, 6, 6, 6, 6, 6 };
            int key = 5;
            int low = findLowIndex(array, key);
            int high = findHighIndex(array, key);
            Console.WriteLine("Low Index of " + key + ": " + low);
            Console.WriteLine("High Index of " + key + ": " + high);

            key = -2;
            low = findLowIndex(array, key);
            high = findHighIndex(array, key);
             Console.WriteLine("Low Index of " + key + ": " + low);
            Console.WriteLine("High Index of " + key + ": " + high);
        }
    }
}
