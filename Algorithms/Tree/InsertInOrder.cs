// C# program to construct binary tree from
// given array in level order fashion
using System;

public static class InsertInOrder
{
	static Node root;

	// Tree Node
	public class Node
	{
		public int data;
		public Node left, right;
		public Node(int data)
		{
			this.data = data;
			this.left = null;
			this.right = null;
		}
	}

	// Function to insert nodes in level order
	public static Node insertLevelOrder(int[] arr,
							Node root, int i)
	{
		int[] arr1 = new int[2];
		
		// Base case for recursion
		if (i < arr.Length)
		{
			//Node temp = 
			root = new Node(arr[i]); ;

			// insert left child
			root.left = insertLevelOrder(arr,
							root.left, 2 * i + 1);

			// insert right child
			root.right = insertLevelOrder(arr,
							root.right, 2 * i + 2);
		}
		return root;
	}

	// Function to print tree
	// nodes in InOrder fashion
	public static void inOrder(Node root)
	{
		if (root != null)
		{
			inOrder(root.left);
			Console.Write(root.data + " ");
			inOrder(root.right);
		}
	}

	// Driver code
	public static void Execute()
	{
		int[] arr = { 1, 2, 3, 4, 5, 6,7 };
		Node newNode = insertLevelOrder(arr, root, 0);
		inOrder(newNode);
	}
}

// This code is contributed Rajput-Ji
