using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tree
{


    public class PostOrder
    {
        static void printPostOrder(TreeNode node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            printPostOrder(node.left);

            /* now recur on right child */
            printPostOrder(node.right);

            /* then print the data of node */
            Console.Write(node.Data + " ");

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


            printPostOrder(root);
        }
    }

}
