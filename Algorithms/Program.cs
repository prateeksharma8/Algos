using Algorithms._2Pointers;
using Algorithms.BinarySearch;
using Algorithms.DynamicProgramming;
using Algorithms.Net;
using System;

using System.Linq;
namespace Algorithms
{
    public class Program
    {
        public static void Main()
        {
            Kaden.Execute();
            //MoveZeros.Execute();
            Console.ReadKey();
        }

        public static void PrintArrays(int[] arr)
        {
            Array.ForEach(arr, element => Console.Write($" {element.ToString()}"));
        }
    }
}
