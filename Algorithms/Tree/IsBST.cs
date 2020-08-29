using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tree
{
    public class IsBST
    {
        
            //Root of the Binary Tree  
            public static TreeNode root;

            /* can give min and max value according to your code or  
            can write a function to find min and max value of tree. */

            /* returns true if given search tree is binary  
             search tree (efficient version) */
        

            /* Returns true if the given tree is a BST and its  
              values are >= min and <= max. */
            public static  bool isBSTUtil(TreeNode node)
            {
                /* an empty tree is BST */
                if (node == null)
                {
                    return true;
                }

                /* false if this node violates the min/max constraints */
                if ((node.right!=null && node.right.val < node.val) || (node.left != null && node.left.val > node.val))
                {
                    return false;
                }

                /* otherwise check the subtrees recursively  
                tightening the min/max constraints */
                // Allow only distinct values  
                return isBSTUtil(node.left) && isBSTUtil(node.right);
            }

            /* Driver program to test above functions */
            public static void Execute()
            {
                TreeNode root = new TreeNode(6);
                root.left = new TreeNode(5);
                root.right = new TreeNode(7);
                root.left.left = new TreeNode(3);
                root.right.right = new TreeNode(8);

                if (isBSTUtil(root))
                {
                    Console.WriteLine("IS BST");
                }
                else
                {
                    Console.WriteLine("Not a BST");
                }
            }
        }
}
