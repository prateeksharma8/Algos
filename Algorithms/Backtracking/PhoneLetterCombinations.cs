using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Backtracking
{
	// C# implementation of the approach
	using System;
	using System.Collections.Generic;

	public class PhoneLetterCombinations
	{
		// Function to return a vector that contains
		// all the generated letter combinations
		static List<String>
		letterCombinationsUtil(int[] number, int n,
							String[] table)
		{
			// To store the generated letter combinations
			List<String> list = new List<String>();

			Queue<String> q = new Queue<String>();
			q.Enqueue("");

			while (q.Count != 0)
			{
				String s = q.Dequeue();

				// If complete word is generated
				// push it in the list
				if (s.Length == n)
					list.Add(s);
				else
				{
					String val = table[number[s.Length]];
					for (int i = 0; i < val.Length; i++)
					{
						q.Enqueue(s + val[i]);
					}
				}
			}
			return list;
		}

		// Function that creates the mapping and
		// calls letterCombinationsUtil
		static void letterCombinations(int[] number, int n)
		{
			// table[i] stores all characters that
			// corresponds to ith digit in phone
			String[] table
				= { "0", "1", "abc", "def", "ghi",
				"jkl", "mno", "pqrs", "tuv", "wxyz" };

			List<String> list
				= letterCombinationsUtil(number, n, table);

			// Print the contents of the list
			for (int i = 0; i < list.Count; i++)
			{
				Console.Write(list[i] + " ");
			}
		}

		// Driver code
		public static void Execute()
		{
			int[] number = { 2, 3 };
			int n = number.Length;

			// Function call
			letterCombinations(number, n);
		}
	}

	// This code is contributed by Princi Singh

}

