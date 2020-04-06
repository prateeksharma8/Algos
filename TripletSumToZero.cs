using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class TripletSumToZero
    {

        public static List<List<int>> searchTriplets(int[] arr)
        {
            Array.Sort(arr);
            List<List<int>> triplets = new List<List<int>>();
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1]) // skip same element to avoid duplicate triplets
                    continue;
                searchPair(arr, -arr[i], i + 1, triplets);
            }

            return triplets;
        }

        private static void searchPair(int[] arr, int targetSum, int left, List<List<int>> triplets)
        {
            int right = arr.Length - 1;
            while (left < right)
            {
                int currentSum = arr[left] + arr[right];
                if (currentSum == targetSum)
                { // found the triplet
                    triplets.Add(new List<int> { -targetSum, arr[left], arr[right] });
                    left++;
                    right--;
                    while (left < right && arr[left] == arr[left - 1])
                        left++; // skip same element to avoid duplicate triplets
                    while (left < right && arr[right] == arr[right + 1])
                        right--; // skip same element to avoid duplicate triplets
                }
                else if (targetSum > currentSum)
                    left++; // we need a pair with a bigger sum
                else
                    right--; // we need a pair with a smaller sum
            }
        }

        public static void Execute()
        {
            Console.WriteLine(TripletSumToZero.searchTriplets(new int[] { -3, 0, 1, 2, -1, 1, -2 }));
            Console.WriteLine(TripletSumToZero.searchTriplets(new int[] { -5, 2, -1, -2, 3 }));
        }
    }
}
