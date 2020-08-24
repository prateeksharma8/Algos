using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Subsets
{

    public class EvaluateExpression
    {
        public static List<int> diffWaysToEvaluateExpression(String input)
        {
            List<int> result = new List<int>();
            // base case: if the input string is a number, parse and add it to output.
            if (!input.Contains("+") && !input.Contains("-") && !input.Contains("*"))
            {
                result.Add(int.Parse(input));
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char chr = input[i];
                    if (!char.IsDigit(chr))
                    {
                        // break the equation here into two parts and make recursively calls
                        List<int> leftParts = diffWaysToEvaluateExpression(input.Substring(0, i));
                        List<int> rightParts = diffWaysToEvaluateExpression(input.Substring(i + 1));
                        foreach (int part1 in leftParts)
                        {
                            foreach (int part2 in rightParts)
                            {
                                if (chr == '+')
                                    result.Add(part1 + part2);
                                else if (chr == '-')
                                    result.Add(part1 - part2);
                                else if (chr == '*')
                                    result.Add(part1 * part2);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static void Execute()
        {
            List<int> result = EvaluateExpression.diffWaysToEvaluateExpression("1+2*3");
           Console.WriteLine("\nExpression evaluations: ");
            Program.PrintArrays(result);

            result = EvaluateExpression.diffWaysToEvaluateExpression("2*3-4-5");
            Console.WriteLine("\nExpression evaluations: ");
            Program.PrintArrays(result);
        }
    }
}
