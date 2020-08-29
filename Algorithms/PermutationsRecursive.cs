using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{

    public class PermutationsRecursive
    {

        public static List<List<int>> generatePermutations(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            generatePermutationsRecursive(nums, 0, new List<int>(), result);
            return result;
        }

        private static void generatePermutationsRecursive(int[] nums, int index, List<int> currentPermutation,
            List<List<int>> result)
        {
            if (index == nums.Length)
            {
                result.Add(currentPermutation);
            }
            else
            {
                // create a new permutation by adding the current number at every position
                for (int i = 0; i <= currentPermutation.Count; i++)
                {
                    List<int> newPermutation = new List<int>(currentPermutation);
                    newPermutation.Insert(i, nums[index]);
                    generatePermutationsRecursive(nums, index + 1, newPermutation, result);
                }
            }
        }

        public static void Execute()
        {
            List<List<int>> result = PermutationsRecursive.generatePermutations(new int[] { 1, 3, 5 });
            Console.WriteLine("Here are all the permutations: " + result);
        }
    }
}
