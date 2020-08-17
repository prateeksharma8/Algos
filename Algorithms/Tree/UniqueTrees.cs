using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tree
{
    public class UniqueTrees
    {
        public static List<TreeNode> findUniqueTrees(int n)
        {
            if (n <= 0)
                return new List<TreeNode>();
            return findUniqueTreesRecursive(1, n);
        }

        public static List<TreeNode> findUniqueTreesRecursive(int start, int end)
        {
            List<TreeNode> result = new List<TreeNode>();
            // base condition, return 'null' for an empty sub-tree
            // consider n=1, in this case we will have start=end=1, this means we should have only one tree
            // we will have two recursive calls, findUniqueTreesRecursive(1, 0) & (2, 1)
            // both of these should return 'null' for the left and the right child
            if (start > end)
            {
                result.Add(null);
                return result;
            }

            for (int i = start; i <= end; i++)
            {
                // making 'i' root of the tree
                List<TreeNode> leftSubtrees = findUniqueTreesRecursive(start, i - 1);
                List<TreeNode> rightSubtrees = findUniqueTreesRecursive(i + 1, end);
                foreach (TreeNode leftTree in leftSubtrees)
                {
                    foreach (TreeNode rightTree in rightSubtrees)
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = leftTree;
                        root.right = rightTree;
                        result.Add(root);
                    }
                }
            }
            return result;
        }

        public static void Execute()
        {
            List<TreeNode> result = UniqueTrees.findUniqueTrees(2);
            Console.WriteLine("Total trees: " + result.Count);
        }
    }
}
