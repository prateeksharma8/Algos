


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tree
{
    public class FindAllPathExist
    {
        public static bool PathExist(TreeNode root, int[] sequence)
        {
            return Exist(root, sequence, 0);
        }

        private static bool Exist(TreeNode currentNode, int[] sequence, int level)
        {
            if (currentNode == null)
            {
                return false;
            }

            if (currentNode.Data == sequence[level])
            {
                if (level == sequence.Length - 1)
                {
                    Console.WriteLine("found");
                    return true;
                }
            }
            else
            {
                return false;
            }
            return Exist(currentNode.left, sequence, level+1) || Exist(currentNode.right, sequence, level + 1);
        }

        public static void Execute()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(6);
            Console.Write("Path 1,3,5 exist: " + PathExist(root, new int[] { 1, 3, 5 }));
            Console.Write("Path 1,0,7 exist: " + PathExist(root, new int[] { 1, 0, 7 }));
        }
    }

}
