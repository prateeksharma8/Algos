using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Algorithms.Tree
{ 
    public class FindAllTreePaths
    {
        public static List<List<int>> findPaths(TreeNode root, int sum)
        {
            List<List<int>> allPaths = new List<List<int>>();
            List<int> currentPath = new List<int>();
            findPathsRecursive(root, sum, currentPath, allPaths);
            return allPaths;
        }

        private static void findPathsRecursive(TreeNode currentNode, int sum, List<int> currentPath,
            List<List<int>> allPaths)
        {
            if (currentNode == null)
                return;

            // add the current node to the path
            currentPath.Add(currentNode.val);

            // if the current node is a leaf and its value is equal to sum, save the current path
            if (currentNode.val == sum && currentNode.left == null && currentNode.right == null)
            {
                allPaths.Add(new List<int>(currentPath));
                
            }
            else
            {
                // traverse the left sub-tree
                findPathsRecursive(currentNode.left, sum - currentNode.val, currentPath, allPaths);
                // traverse the right sub-tree
                findPathsRecursive(currentNode.right, sum - currentNode.val, currentPath, allPaths);
            }

            // remove the current node from the path to backtrack, 
            // we need to remove the current node while we are going up the recursive call stack.
            currentPath.RemoveAt(currentPath.Count - 1);
        }
        public static void Execute()
        {
            TreeNode root = new TreeNode(12);
            root.left = new TreeNode(7);
            root.right = new TreeNode(1);
            root.left.left = new TreeNode(4);
            root.right.left = new TreeNode(10);
            root.right.right = new TreeNode(5);
            int sum = 23;
            List<List<int>> result = FindAllTreePaths.findPaths(root, sum);
            Console.WriteLine("Tree paths with sum " + sum );
            foreach(List<int> l in result)
            {
                Console.WriteLine("");
                l.ForEach(x => Console.Write(x+" " ));
            }
        }
    }
}
