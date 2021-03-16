using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Subsets
{
   

    public static class GenerateParenthesesRecursive
    {

        public static List<String> generateValidParentheses(int num)
        {
            List<String> result = new List<String>();
            char[] parenthesesString = new char[2 * num];
            generateValidParenthesesRecursive(num, 0, 0, parenthesesString, 0, result);
            return result;
        }

        private static void generateValidParenthesesRecursive(int num, int openCount, int closeCount,
            char[] parenthesesString, int index, List<String> result)
        {

            // if we've reached the maximum number of open and close parentheses, add to the result
            if (openCount == num && closeCount == num)
            {
                result.Add(new String(parenthesesString));
            }
            else
            {
                if (openCount < num)
                { // if we can add an open parentheses, add it
                    parenthesesString[index] = '(';
                    generateValidParenthesesRecursive(num, openCount + 1, closeCount, parenthesesString, index + 1, result);
                }

                if (openCount > closeCount)
                { // if we can add a close parentheses, add it
                    parenthesesString[index] = ')';
                    generateValidParenthesesRecursive(num, openCount, closeCount + 1, parenthesesString, index + 1, result);
                }
            }
        }

        public static void Execute()
        {
            List<String> result = GenerateParenthesesRecursive.generateValidParentheses(2);
           Console.WriteLine("All combinations of balanced parentheses are: " );
            Program.PrintArrays(result);

            result = GenerateParenthesesRecursive.generateValidParentheses(3);
            Console.WriteLine("All combinations of balanced parentheses are: ");
            Program.PrintArrays(result);

        }
    }
}
