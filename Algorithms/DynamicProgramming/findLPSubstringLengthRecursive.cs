using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class FindLPSubstringLengthRecursive
    {
        public static int findLPSLength(String st)
        {
            return findLPSLengthRecursive(st, 0, st.Length - 1);
        }

        private static int findLPSLengthRecursive(String st, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
                return 0;

            // every sequence with one element is a palindrome of length 1
            if (startIndex == endIndex)
                return 1;

            // case 1: elements at the beginning and the end are the same
            if (st[startIndex] == st[endIndex])
                return 2 + findLPSLengthRecursive(st, startIndex + 1, endIndex - 1);

            // case 2: skip one element either from the beginning or the end
            int c1 = findLPSLengthRecursive(st, startIndex + 1, endIndex);
            int c2 = findLPSLengthRecursive(st, startIndex, endIndex - 1);
            return Math.Max(c1, c2);
        }

        public static void Execute()
        {
            Console.WriteLine(findLPSLength("abdbca"));
            Console.WriteLine(findLPSLength("cddpd"));
            //Console.WriteLine(findLPSLength("pqr"));
        }
    }
}
