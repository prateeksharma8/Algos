using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public static class SubarrayProductLessThanK
    {
        static List<List<int>> result = new List<List<int>>();
        public static void subarrayProductLessThanK(List<int> arr, int index, List<int> tempList, int target)
        {

            for(int item = index; item<arr.Count; item++)
            {
                tempList.Add(arr[item]);

                int product = tempList.Aggregate((int a, int b) => a * b);

                if (product < target)
                {
                    result.Add(tempList.Select(x => x).ToList<int>());
                    subarrayProductLessThanK(arr, item + 1, tempList, target);
                }
                tempList.Remove(arr[item]);
            }
        }


        public static void Execute()
        {
            subarrayProductLessThanK(new List<int> { 2, 5, 3, 10 }, 0, new List<int>(), 30);

            Program.PrintArrays(result);
            result.Clear();
            subarrayProductLessThanK(new List<int> { -5, 2, -1, -2, 3 }, 0, new List<int>(), 10);
            Program.PrintArrays(result);

        }
    }
}
