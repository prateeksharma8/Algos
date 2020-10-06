using Algorithms._2Pointers;
using Algorithms.BinarySearch;
using Algorithms.DynamicProgramming;
using Algorithms.DynamicProgramming._0_1_Knapsack;
using Algorithms.Graph;
using Algorithms.K_WayMerge;
using Algorithms.LinkedList;
using Algorithms.Maths_Stats;
using Algorithms.Net;
using Algorithms.Strings;
using Algorithms.Subsets;
using Algorithms.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Algorithms
{
    public class Program
    {
        public static void Main()
        {
            NumberValid.Execute();
            Console.ReadKey();
        }

        public static void PrintArrays(int[] arr)
        {
            Array.ForEach(arr, element => Console.Write($" {element.ToString()}"));
        }

        public static void PrintArrays<T>(List<T> arr)
        {
            arr.ForEach(element => Console.Write($" {element.ToString()}"));
        }
    }
}
