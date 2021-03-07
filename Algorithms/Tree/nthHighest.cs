using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tree
{


    public class nthHighest
    {
        static void Highest(TreeNode node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            Highest(node.right);

            /* then print the data of node */
            Console.Write(node.Data + " ");

            /* now recur on right child */
            Highest(node.left);
        }



        public static void Execute()
        {
            TreeNode root = new TreeNode(100);
            root.left = new TreeNode(50);
            root.right = new TreeNode(200);
            root.left.left = new TreeNode(25);
            root.left.right = new TreeNode(75);

            root.right.left = new TreeNode(125);
            root.right.right = new TreeNode(350);


            Highest(root);
        }
    }

}
