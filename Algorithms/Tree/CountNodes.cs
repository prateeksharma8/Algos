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

        public static void Execute()
        {
            TreeNode root = new TreeNode(12);
            root.left = new TreeNode(7);
            root.right = new TreeNode(1);
            root.left.left = new TreeNode(4);
            root.right.left = new TreeNode(10);
            root.right.right = new TreeNode(5);
            Console.Write("Tree has path: " + countPaths(root));
        }
    }

}
