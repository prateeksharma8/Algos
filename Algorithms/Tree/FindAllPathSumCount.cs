using System;
using System.Collections.Generic;

namespace Algorithms.Tree
{
    public class FindAllPathSumCount
    {
        public static int PathExist(TreeNode root, int sum)
        {
            List<int> currentPath = new List<int>();
            return CountPathsRec(root, sum, currentPath);
        }

        private static int CountPathsRec(TreeNode currentNode, int S, List<int> currentPath)
        {
            if (currentNode == null)
                return 0;

            // add the current node to the path
            currentPath.Add(currentNode.val);
            int pathCount = 0, pathSum = 0;
            // find the sums of all sub-paths in the current path list
            //List<int> pathIterator = currentPath.listIterator(currentPath.Count);
            for(int i=currentPath.Count-1;i>=0; i--)
             {
                 pathSum += currentPath[i];
                // if the sum of any sub-path is equal to 'S' we increment our path count.
                if (pathSum == S)
                 {
                     pathCount++;
                 }
             }

            // traverse the left sub-tree
            pathCount += CountPathsRec(currentNode.left, S, currentPath);
            // traverse the right sub-tree
            pathCount += CountPathsRec(currentNode.right, S, currentPath);

            // remove the current node from the path to backtrack, 
            // we need to remove the current node while we are going up the recursive call stack.
            currentPath.RemoveAt (currentPath.Count - 1);

            return pathCount;
        }

        public static void Execute()
        {
            TreeNode root = new TreeNode(12);
            root.left = new TreeNode(7);
            root.right = new TreeNode(1);
            root.left.left = new TreeNode(4);
            root.right.left = new TreeNode(10);
            root.right.right = new TreeNode(5);
            Console.Write("Sum 11: " +  PathExist(root, 11));
        }
    }

}
