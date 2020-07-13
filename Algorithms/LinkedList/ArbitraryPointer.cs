using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public static class ArbitraryPointer
    {
        public static Node deepCopyArbitraryPointer(Node head)
        {

            if (head == null)
            {
                return null;
            }

            Node current = head;
            Node newHead = null;
            Node newPrev = null;
            Dictionary<Node, Node> map =
            new Dictionary<Node, Node>();

            // create copy of the linked list, recording the corresponding
            // nodes in hashmap without updating arbitrary pointer
            while (current != null)
            {
                Node newNode = new Node(current.data);

                // copy the old arbitrary pointer in the new node
                newNode.arbitraryPointer = current.arbitraryPointer;

                if (newPrev != null)
                {
                    newPrev.next = newNode;
                }
                else
                {
                    newHead = newNode;
                }

                map.Add(current, newNode);

                newPrev = newNode;
                current = current.next;
            }

            Node newCurrent = newHead;

            // updating arbitraryPointer
            while (newCurrent != null)
            {
                if (newCurrent.arbitraryPointer != null)
                {
                    Node node = map[newCurrent.arbitraryPointer];

                    newCurrent.arbitraryPointer = node;
                }

                newCurrent = newCurrent.next;
            }

            return newHead;
        }

        public static Node createLinkedListWithArbPointers(int length)
        {
            Node head = CreateSinglyList.Create (new int[]{ 7,14,21});
            List<Node> v = new List<Node>();
            Node temp = head;
            while (temp != null)
            {
                v.Add(temp);
                temp = temp.next;
            }

            v[0].arbitraryPointer = v[2];
            v[1].arbitraryPointer =null;
            v[2].arbitraryPointer = v[0];
            return head;
        }

        public static String printWithArbPointers(Node head)
        {
            String printedResult = "";
            while (head != null)
            {
                String temp = "";
                printedResult += head.data;
                if (head.arbitraryPointer != null)
                {
                    temp += head.arbitraryPointer.data;
                }
                printedResult += " (" + temp + ")";
                head = head.next;
                if (head != null)
                    printedResult += ", ";
            }
            return printedResult;
        }

        public static void Execute()
        {
            Node head = createLinkedListWithArbPointers(5);

            Node head2 = deepCopyArbitraryPointer(head);

           Console.WriteLine("Original list: " + printWithArbPointers(head));

            Console.WriteLine("\nDeep copied list: " + printWithArbPointers(head2));

            head = createLinkedListWithArbPointers(3);

            Console.WriteLine("\nChanged original list: " + printWithArbPointers(head));

            Console.WriteLine("\nUnchanged deep copied list: " + printWithArbPointers(head2));
        }
    }
}
