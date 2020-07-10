using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace Algorithms._2Pointers
{
    public static class SortedArraySquares
    {

        public static void Execute()
        {
            int[] squares = new int[] { 0, 1, 2, 3, 4 };
            int positiveIndex = 0;
            for (int i = 0; i < squares.Length; i++)
            {
                if (squares[i] >= 0)
                {
                    positiveIndex = i;
                    break;
                }
            }

            int[] result = new int[squares.Length];
            int left = positiveIndex - 1, right = positiveIndex + 1;
            result[0] = squares[positiveIndex] * squares[positiveIndex];
            int leftSquare, rightSquare;
            for (int i = 1; i < squares.Length; i++)
            {
                leftSquare = left>=0? squares[left] * squares[left]: int.MaxValue;
                rightSquare = right < squares.Length ? squares[right] * squares[right] : int.MaxValue;

                if (leftSquare < rightSquare)
                {

                    result[i] = leftSquare;
                    left--;
                }

                if (leftSquare >= rightSquare)
                {

                    result[i] = rightSquare;
                    right++;
                }


            }



            Console.WriteLine("\n");

            foreach (var item in result)
            {
                Console.Write(" ");
                Console.Write(item);
            }
        }
    }
}
