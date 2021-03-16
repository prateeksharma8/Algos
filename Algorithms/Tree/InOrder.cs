using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tree
{


    public class InOrder
    {
        public static void printInorder(TreeNode node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            printInorder(node.left);

            /* then print the data of node */
            Console.Write(node.Data + " ");

            /* now recur on right child */
            printInorder(node.right);


        }

        public static void iterativeInorder(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (stack.Count() > 0 || root != null)
            {
                if (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                    continue;
                }


                TreeNode n = stack.Pop();
                Console.WriteLine(" " + n.Data);
                root = n.right;
            }
        }



        public static void Execute()
        {
            TreeNode root = new TreeNode(12);
            root.left = new TreeNode(7);
            root.right = new TreeNode(8);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(1);

            root.right.left = new TreeNode(10);
            root.right.right = new TreeNode(5);


            printInorder(root);
            Console.WriteLine("iterativeInorder");
            iterativeInorder(root);
        }
    }

}
