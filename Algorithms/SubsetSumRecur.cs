using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class SubsetSumRecur
    {
        static List<List<int>> result = new List<List<int>>();

        static void getKSumSubsetsRec(List<int> list, int targetSum, List<int> partialList, int index)
        {

            int sum = partialList.Sum(a => a);

            for (int i = index; i < list.Count; ++i)
            {
                if (sum + list[i] > targetSum)
                {
                    continue;
                }
                partialList.Add(list[i]);
                if (sum + list[i] == targetSum)
                {
                    result.Add(partialList.Select(a => a).ToList());
                }
                getKSumSubsetsRec(list, targetSum, partialList, i + 1);
                partialList.Remove(list[i]);
            }
        }


        public static void Execute()
        {
            List<int> list = new List<int> { 1, 3, 4, 2,10 };


            getKSumSubsetsRec(list, 10, new List<int>(), 0);
            Program.PrintArrays(result);
            result.Clear();
            list = new List<int> { 1, 2, 7, 1, 5 };
            getKSumSubsetsRec(list, 10, new List<int>(), 0);
            Program.PrintArrays(result);
        }
    }
}
