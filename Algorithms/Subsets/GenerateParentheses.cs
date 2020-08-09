using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Subsets
{
   
    public class GenerateParentheses
    {
        class ParenthesesString
        {
            public String str;
            public int openCount; // open parentheses count
            public int closeCount; // close parentheses count

            public ParenthesesString(String s, int openCount, int closeCount)
            {
                str = s;
                this.openCount = openCount;
                this.closeCount = closeCount;
            }
        }


        public static List<String> generateValidParentheses(int num)
        {
            List<String> result = new List<String>();
            Queue<ParenthesesString> queue = new Queue<ParenthesesString>();
            queue.Enqueue(new ParenthesesString("", 0, 0));
            while (queue.Count>0)
            {
                ParenthesesString ps = queue.Dequeue();
                // if we've reached the maximum number of open and close parentheses, add to the result
                if (ps.openCount == num && ps.closeCount == num)
                {
                    result.Add(ps.str);
                }
                else
                {
                    if (ps.openCount < num) // if we can add an open parentheses, add it
                        queue.Enqueue(new ParenthesesString(ps.str + "(", ps.openCount + 1, ps.closeCount));

                    if (ps.openCount > ps.closeCount) // if we can add a close parentheses, add it
                        queue.Enqueue(new ParenthesesString(ps.str + ")", ps.openCount, ps.closeCount + 1));
                }
            }
            return result;
        }

        public static void Execute()
        {
            List<String> result = GenerateParentheses.generateValidParentheses(2);
            Console.WriteLine("All combinations of balanced parentheses are: " );
            Program.PrintArrays(result);

            Console.WriteLine();
           result = GenerateParentheses.generateValidParentheses(3);
            Console.WriteLine("All combinations of balanced parentheses are: " );
            Program.PrintArrays(result);

        }
    }

}
