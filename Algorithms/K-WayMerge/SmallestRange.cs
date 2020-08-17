using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{

    public class SmallestRange
    {
        public class Node
        {
            public int elementIndex;
            public int arrayIndex;

            public Node(int elementIndex, int arrayIndex)
            {
                this.elementIndex = elementIndex;
                this.arrayIndex = arrayIndex;
            }
        }


        public static int[] findSmallestRange(List<int[]> lists)
        {

            SortedList<int, Node> minHeap = new SortedList<int, Node>();

            int rangeStart = 0, rangeEnd = int.MaxValue, currentMaxNumber = int.MinValue;
            // put the 1st element of each array in the min heap
            for (int i = 0; i < lists.Count; i++)
                if (lists[i] != null)
                {
                  
                    minHeap.Add(lists[i][0], new Node(i, 0));
                    currentMaxNumber = Math.Max(currentMaxNumber, lists[i][0]);
                }

            // take the smallest (top) element form the min heap, if it gives us smaller range, update the ranges
            // if the array of the top element has more elements, insert the next element in the heap
            while (minHeap.Count == lists.Count)
            {
                Node node = minHeap.Values[0];
                if (rangeEnd - rangeStart > currentMaxNumber - lists[node.arrayIndex][node.elementIndex])
                {
                    rangeStart = lists[node.arrayIndex][node.elementIndex];
                    rangeEnd = currentMaxNumber;
                }
                node.elementIndex++;
                if (lists[node.arrayIndex].Length > node.elementIndex)
                {
                    minHeap.Add(lists[node.arrayIndex][node.elementIndex], new Node(node.elementIndex, node.arrayIndex)); // insert the next element in the heap
                    currentMaxNumber = Math.Max(currentMaxNumber, lists[node.arrayIndex][node.elementIndex]);
                }
            }
            return new int[] { rangeStart, rangeEnd };
        }

        public static void Execute()
        {
            int[] l1 = new int[] { 1, 5, 8 };
            int[] l2 = new int[] { 4, 12 };
            int[] l3 = new int[] { 7, 9, 10 };
            List<int[]> lists = new List<int[]>();
            lists.Add(l1);
            lists.Add(l2);
            lists.Add(l3);
            int[] result = findSmallestRange(lists);
            Console.WriteLine("Kth smallest number is: " + result);
        }
    }
}
