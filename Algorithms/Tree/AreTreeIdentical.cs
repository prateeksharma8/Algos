using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tree
{


    public class AreTreeIdentical
    {
        public static bool areIdentical(TreeNode root1, TreeNode root2)
        {

            if (root1 == null && root2 == null)
            {
                return true;
            }

            if (root1 != null && root2 != null)
            {
                return ((root1.Data == root2.Data) &&
                        areIdentical(root1.left, root2.left) &&
                        areIdentical(root1.right, root2.right));
            }

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

            TreeNode root2 = new TreeNode(12);
            root2.left = new TreeNode(7);
            root2.right = new TreeNode(8);
            root2.left.left = new TreeNode(4);
            root2.left.right = new TreeNode(1);

            root2.right.left = new TreeNode(10);
            root2.right.right = new TreeNode(5);
            Console.Write("Tree has IDentical: " + areIdentical(root, root2));
        }
    }

}
