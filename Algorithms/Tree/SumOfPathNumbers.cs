using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tree
{
    public class SumOfPathNumbers
    {
        public static int SumPaths(TreeNode root)
        {
            int sum = 0;
            return SumOfPath(root, sum);
        }

        private static int SumOfPath(TreeNode currentNode, int sum)
        {
            if (currentNode == null)
            {
                return 0;
            }
            sum = sum * 10 + currentNode.Data;
            if (currentNode.left == null && currentNode.right == null)
            {
                return sum;
            }

            return SumOfPath(currentNode.left, sum) + SumOfPath(currentNode.right, sum);

        }

        public static void Execute()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(1);
            root.left.left = new TreeNode(1);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(5);
            Console.Write("Result Sum: " + SumPaths(root));
        }
    }

}
