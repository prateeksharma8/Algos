using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tree
{
    public class TreeNode
    {
        public int Data;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            Data = x;
        }
    };

    public class MaxHeight
    {
        public static int Diameter(TreeNode root)
        {
            return MaxDiameter(root);
        }

        public static int diameter = 0;
        private static int MaxDiameter(TreeNode currentNode)
        {
            if (currentNode == null)
                return 0;

            int left = MaxDiameter(currentNode.left);
            int right = MaxDiameter(currentNode.right);
            diameter = Math.Max(diameter, currentNode.Data + left + right);
            return currentNode.Data + Math.Max(left, right);
        }

        public static void Execute()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.left.right.right = new TreeNode(50);

            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);
            root.right.left.left = new TreeNode(8);
            root.right.left.right = new TreeNode(9);
            root.right.right.left = new TreeNode(10);
            Diameter(root);
            Console.Write("Diameter of Tree: " +diameter );
        }
    }

}
