using Algorithms._2Pointers;
using Algorithms.BinarySearch;
using Algorithms.DynamicProgramming;
using Algorithms.LinkedList;
using Algorithms.Maths_Stats;
using Algorithms.Net;
using Algorithms.Strings;
using System;

using System.Linq;
namespace Algorithms
{
    public class Program
    {
        public static void Main()
        {
            RegularExpressionCheck.Execute();
            //MoveZeros.Execute();
            Console.ReadKey();
        }

        public static void PrintArrays(int[] arr)
        {
            Array.ForEach(arr, element => Console.Write($" {element.ToString()}"));
        }
    }
}
