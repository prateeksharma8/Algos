using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class MultipleCombinations
    {
        public static void Execute()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int combinationCount = 3;
            int n = arr.Length;
            printCombination(arr, n, combinationCount);
        }
      
        static void combinationUtil(int[] arr, int[] data,int start, int end,int index, int combinationCount)
        {
            if (index == combinationCount)
            {
                for (int j = 0; j < combinationCount; j++)
                    Console.Write(data[j] + " ");
                Console.WriteLine("");
                return;
            }

            // replace index with all possible elements. The condition "end-i+1 >=   r-index" makes sure that including one element 
            //at index will make a combination with remaining  elements at remaining positions 
            for (int i = start; i <= end && end - i + 1 >= combinationCount - index; i++)
            {
                data[index] = arr[i];
                combinationUtil(arr, data, i + 1,end, index + 1, combinationCount);
            }
        }

      
        static  void printCombination(int[] arr, int length, int combinationCount)
        {
            // A temporary array to store  
            // all combination one by one 
            int[] data = new int[combinationCount];

            // Print all combination  
            // using temprary array 'data[]' 
            combinationUtil(arr, data, 0,length - 1, 0, combinationCount);
        }
    }
}
