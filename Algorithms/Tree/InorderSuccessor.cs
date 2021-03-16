using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Tree
{


    public static class InorderSuccessor
    {
        static TreeNode findMin(TreeNode root)
        {
            if (root == null)
                return null;

            while (root.left != null)
            {
                root = root.left;
            }

            return root;
        }

        static TreeNode inorderSuccessorBST(TreeNode root, int d)
        {

            if (root == null)
            {
                return null;
            }

            TreeNode successor = null;

            while (root != null)
            {

                if (root.Data < d)
                {
                    root = root.right;
                }
                else if (root.Data > d)
                {
                    successor = root;
                    root = root.left;
                }
                else
                {
                    if (root.right != null)
                    {
                        successor = findMin(root.right);
                    }
                    break;
                }
            }
            return successor;
        }



        public static void Execute()
        {
            TreeNode root = new TreeNode(100);
            root.left = new TreeNode(50);
            root.right = new TreeNode(200);

            root.left.left = new TreeNode(25);
            root.left.right = new TreeNode(75);

            root.right.left = new TreeNode(125);
            root.right.right = new TreeNode(350);

            InOrder.printInorder(root);
            TreeNode result= inorderSuccessorBST(root, 100);
            Console.WriteLine("");
           Console.WriteLine("100 Result:"+result.Data);

            result = inorderSuccessorBST(root, 75);
            Console.WriteLine("75 Result:" + result.Data);

            result = inorderSuccessorBST(root, 25);
            Console.WriteLine("25 Result:" + result.Data);
        }
    }

}
