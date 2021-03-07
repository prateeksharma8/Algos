using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class SumCombinations
    {
        static String print(List<List<int>> arr)
        {
            String result = "";
            //for (int i = 0; i < arr.Count(); i++)
            //{
            //    result += "[";
            //    for (int j = 0; j < arr[i].size(); j++)
            //    {
            //        result += int.ToString(arr.get(i).get(j)) + ",";
            //    }
            //    result = result.replaceAll(",$", "");
            //    result += "]";
            //}
            return result;
        }


        static void printAllSumRec(int target, int currentSum, int start,
          List<List<int>> output, List<int> result)
        {

            if (target == currentSum)
            {
                output.Add(result.Select(x=>x).ToList());
            }

            for (int i = start; i < target; ++i)
            {
                int tempSum = currentSum + i;
                if (tempSum <= target)
                {

                    result.Add(i);
                    printAllSumRec(target, tempSum, i, output, result);
                    bool res=result.Remove(result[result.Count() - 1]);
                }
                else
                {
                    return;
                }
            }
        }
        static List<List<int>> printAllSum(int target)
        {
            List<List<int>> output = new List<List<int>>();
            List<int> result = new List<int>();
            printAllSumRec(target, 0, 1, output, result);
            return output;
        }

        public static void Execute()
        {
            int n = 4;
            List<List<int>> result = printAllSum(n);
            Console.WriteLine("All sum combinations of " + n);
            Console.WriteLine(print(result));
        }
    }
}
