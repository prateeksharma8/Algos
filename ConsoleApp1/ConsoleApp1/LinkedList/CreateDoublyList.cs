using System;

namespace ConsoleApp1.LinkedList
{

    public static class CreateDoublyList
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

            DeleteANode(headNode.next.next);
            PrintNodes(headNode);

            AddNodeAfter(45, headNode.next.next);
            PrintNodes(headNode);
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

        static void PrintNodes(Node headNode)
        {
            while (headNode != null)
            {
                Console.WriteLine($"Node {headNode.data} Prev:{headNode.prev?.data}");
                headNode = headNode.next;
            }
        }

        static Node AddNode(int value, Node n)
        {
            Node newNode = new Node(value);
            newNode.prev = n;
            n.next = newNode;
            return newNode;
        }

        static Node AddNodeAfter(int value, Node n)
        {
            Console.WriteLine($"Adding Node {value} after {n.data}");
            Node newNode = new Node(value);
            Node next = n.next;
            n.next = newNode;
            newNode.prev = n;
            newNode.next = next;
            next.prev = newNode;
            return newNode;
        }

        static void DeleteANode(Node delNode)
        {
            Console.WriteLine($"Deleteing Node {delNode.data}");
            delNode.prev.next = delNode.next;
            delNode.next.prev = delNode.prev;
        }
    }
}
