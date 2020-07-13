using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public static class NthFromLast
    {
        public static Node findNthFromLast(Node head, int n)
        {
            if (head == null || n < 1)
            {
                return null;
            }

            // We will use two pointers head and tail
            // where head and tail are 'n' nodes apart.
            Node tail = head;

            while (tail != null && n > 0)
            {
                tail = tail.next;
                --n;
            }

            // Check out-of-bounds
            if (n != 0)
            {
                return null;
            }

            // When tail pointer reaches the end of
            // list, head is pointing at nth node.
            while (tail != null)
            {
                tail = tail.next;
                head = head.next;
            }

            return head;
        }

        public static void Execute()
        {
            Node listHead = null;
            int[] arr = { 7, 14, 21, 28, 35, 42 };
            int position = 5;
            listHead = CreateSinglyList.Create(arr);
            Console.WriteLine("List: ");
            CreateSinglyList.PrintNodes(listHead);

            Node temp = findNthFromLast(listHead, position);
            Console.WriteLine($"Element {position} from last:{temp.data}");
        }
    }
}
