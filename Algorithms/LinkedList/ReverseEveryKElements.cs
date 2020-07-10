namespace Algorithms.LinkedList
{
    //TODO: Write the code, it is an important algo
    public static class ReverseEveryKElements
    {
        public static void Execute()
        {
            Node headNode = new Node(10);
            Node start = headNode;
            Node first = CreateSinglyList.AddNode(20, headNode);
            first = CreateSinglyList.AddNode(30, first);
            first = CreateSinglyList.AddNode(40, first);
            first = CreateSinglyList.AddNode(50, first);
            first = CreateSinglyList.AddNode(60, first);
            first = CreateSinglyList.AddNode(70, first);
            first = CreateSinglyList.AddNode(80, first);
            CreateSinglyList.PrintNodes(headNode);

            Rotate(3,headNode);
        }

        static void Rotate(int count, Node headNode)
        {

            Node currentNode = headNode;
            Node preNode = null;
            Node NextNode = headNode.next;
            bool starting = true;
            Node prevListEndNode = null;
            while (currentNode!=null)
            {
                prevListEndNode = currentNode;

                for (int i = 0; i < 3 && currentNode!=null; i++)
                {
                    currentNode.next = preNode;
                    preNode = currentNode;
                    currentNode = NextNode;
                    NextNode = NextNode.next;
                }

                if (prevListEndNode!=null)
                {
                    prevListEndNode.next = preNode;
                }
               



                if (starting)
                {
                   //Set headNode
                    headNode = preNode;
                    starting = false;
                }
            }
        }
    }
}
