using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinarySearch
{
    public static class SearchNextLetter
    {

        public static char searchNextLetter(char[] letters, char key)
        {
            int n = letters.Length;
            if (key < letters[0] || key > letters[n - 1])
                return letters[0];

            int start = 0, end = n - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (key < letters[mid])
                {
                    end = mid - 1;
                }
                else
                { //if (key >= letters[mid]) {
                    start = mid + 1;
                }
            }
            // since the loop is running until 'start <= end', so at the end of the while loop, 'start == end+1'
            return letters[start % n];
        }

        public static void Execute()
        {
            Console.WriteLine(searchNextLetter(new char[] { 'a', 'c', 'f', 'h' }, 'f'));
             Console.WriteLine(searchNextLetter(new char[] { 'a', 'c', 'f', 'h' }, 'b'));
             Console.WriteLine(searchNextLetter(new char[] { 'a', 'c', 'f', 'h' }, 'm'));
             Console.WriteLine(searchNextLetter(new char[] { 'a', 'c', 'f', 'h' }, 'h'));
        }
    }
}
