using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{

    public class Matrix
    {
        public int row;
        public int col;

        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    public class KthSmallestInSortedMatrix
    {

        public static int findKthSmallest(int[,] matrix, int k)
        {
            SortedList<int, Matrix> minHeap = new SortedList<int, Matrix>();

            // put the 1st element of each row in the min heap
            // we don't need to push more than 'k' elements in the heap
            for (int i = 0; i < matrix.GetLength(1) && i < k; i++)
                minHeap.Add(matrix[i, 0], new Matrix(i, 0));

            // take the smallest (top) element form the min heap, if the running count is equal to k return the number
            // if the row of the top element has more elements, add the next element to the heap
            int numberCount = 0, result = 0;
            while (minHeap.Count > 0)
            {
                Matrix node = minHeap.Values[0];
                result = matrix[node.row, node.col];
                minHeap.RemoveAt(0);
               
                if (++numberCount == k)
                    break;
                node.col++;
                if (matrix.GetLength(1) > node.col)
                    minHeap.Add(matrix[node.row, node.col], node);
            }
            return result;
        }

        public static void Execute()
        {
            int[,] matrix = new int[,] { { 2, 6, 8 }, { 3, 7, 10 }, { 5, 9, 11 } };
            int result = KthSmallestInSortedMatrix.findKthSmallest(matrix, 5);
            Console.WriteLine("Kth smallest number is: " + result);
        }
    }
}
