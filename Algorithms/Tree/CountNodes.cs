using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tree
{
    public class CountNodes
    {
        public static int countPaths(TreeNode root)
        {
            return Count(root);
        }

        private static int Count(TreeNode currentNode)
        {
            if (currentNode == null)
                return 0;

            return 1 + Count(currentNode.left) + Count(currentNode.right);

        }

        static bool PrintLeftTree(TreeNode root)
        {
            if (root == null)
                return false;
            Console.WriteLine(root.Data + " ");
            if(root.left !=null)
            {
                return PrintLeftTree(root.left);
            }

            if (root.right != null)
            {
                return PrintLeftTree(root.right);
            }
            return false;
        }

        static void PrintLeafNodes(TreeNode root)
        {
            if (root == null)
                return;

            PrintLeafNodes(root.left);
            PrintLeafNodes(root.right);


            if ((root.left ==null) && (root.right==null))
            {
                Console.WriteLine(root.Data);
            }
           
        }
        public static void Execute()
        {
            TreeNode root = new TreeNode(12);
            root.left = new TreeNode(7);
            root.right = new TreeNode(1);
            root.left.left = new TreeNode(4);
            root.left.left.right = new TreeNode(8);

            root.right.left = new TreeNode(10);
            root.right.right = new TreeNode(5);
            Console.Write("Tree has path: " + countPaths(root));
            Console.WriteLine();
            PrintLeftTree(root);
            Console.WriteLine("Leaf nodes");
            PrintLeafNodes(root);
        }
    }

}
