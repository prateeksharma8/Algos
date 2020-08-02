using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tree
{


    public class CountSumPath
    {
        public static bool SumPaths(TreeNode root, int desiredSum)
        {
            int sum = desiredSum;
            List<int> lstOfNodes = new List<int>();
            return Count(root, sum, ref lstOfNodes);
        }

        static List<List<int>> result = new List<List<int>>();
        private static bool Count(TreeNode currentNode,  int sum, ref List<int> lstOfNodes)
        {
            if (currentNode == null || sum <= 0) return false;

            lstOfNodes.Add(currentNode.val);
            if (sum == currentNode.val)
            {
                result.Add(lstOfNodes.Select(x => x).ToList());
            }
            Count(currentNode.left,  sum - currentNode.val, ref lstOfNodes);
            Count(currentNode.right,   sum - currentNode.val, ref lstOfNodes);
            
            lstOfNodes.Remove(lstOfNodes[lstOfNodes.Count - 1]);
            return false;
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
            Console.Write("Tree has path: " + SumPaths(root, 20));
        }
    }

}
