using System;
using System.Net.Http.Headers;

namespace Algorithms.LinkedList
{
    public class Node
    {
        public Node next;
        public Node prev;
        public Node arbitraryPointer;
        public int data;

        public Node(int value)
        {
            data = value;
            next = null;
            prev = null;
        }
    }
    public static class CreateSinglyList
    {
        public static void Execute()
        {
            Node headNode = new Node(10);
            Node first = AddNode(20, headNode);
            Node start = headNode;
            first = AddNode(30, first);
            first = AddNode(40, first);
            first = AddNode(50, first);
            PrintNodes(headNode);

            DeleteANode(headNode.next.next, headNode.next);
            PrintNodes(headNode);

            AddNodeAfter(45, headNode.next.next);
            PrintNodes(headNode);

            //CreateCirclularList(first, headNode);

            headNode = ReverseTheList(headNode);
            Console.WriteLine("Reversing");
            PrintNodes(headNode);

        }

        public static Node Create(int[] arr)
        {
            Node head = new Node(arr[0]);
            Node prev = head;
            for(int i=1;i<arr.Length;i++)
            {
                Node n = new Node(arr[i]);
                prev.next = n;
                prev = prev.next;

            }
            return head;
        }

        static void CreateCirclularList(Node last, Node startNode)
        {
            Console.WriteLine($"Creating circluare list");

            Node first = startNode;
            last.next = startNode;
            do
            {
                Console.WriteLine($"{startNode.data}");
                startNode = startNode.next;
            } while (startNode != first);
        }

        public static void PrintNodes(Node headNode)
        {
            while (headNode != null)
            {
                Console.WriteLine($"{headNode.data}");
                headNode = headNode.next;
            }
        }

        public static Node AddNode(int value, Node n)
        {
            Node newNode = new Node(value);
            n.next = newNode;
            return newNode;
        }

        static Node AddNodeAfter(int value, Node n)
        {
            Console.WriteLine($"Adding Node {value} after {n.data}");
            Node newNode = new Node(value);
            newNode.next = n.next;
            n.next = newNode;
            return newNode;
        }

        static void DeleteANode(Node delNode, Node prevNode)
        {
            Console.WriteLine($"Deleteing Node {delNode.data}");
            prevNode.next = delNode.next;
        }

        static Node ReverseTheList(Node current)
        {
            Node previous = null;
            Node next = current.next;

            while (next!= null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;

                next = current.next; // temporarily store the next node
                current.next = previous; // reverse the current node
                previous = current; // before we move to the next node, point previous to the current node
                current = next; // move on the next node
            }

            return previous;
        }

        static Node SwitchNodes(Node first, Node second)
        {
            Console.WriteLine($" Switching {first?.data} and {second.data}");
            Node n = second.next;

            second.next = first;
             if(first?.next!=null)
                 first.next = n;

            Console.WriteLine($" Switched {second?.data} and {first?.data}");

            return second;
        }

    }
}
