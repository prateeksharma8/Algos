using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Maths_Stats
{
    public static class RegularExpressionCheck
    {
        public static bool isMatch(String text, String pattern)
        {
            bool[,] dp = new bool[text.Length + 1,pattern.Length + 1];
            dp[text.Length,pattern.Length] = true;

            for (int i = text.Length; i >= 0; i--)
            {
                for (int j = pattern.Length - 1; j >= 0; j--)
                {
                    bool first_match = (i < text.Length &&
                                           (pattern[j] == text[i] ||
                                            pattern[j] == '.'));
                    if (j + 1 < pattern.Length && pattern[j + 1] == '*')
                    {
                        dp[i,j] = dp[i,j + 2] || first_match && dp[i + 1,j];
                    }
                    else
                    {
                        dp[i,j] = first_match && dp[i + 1,j + 1];
                    }
                }
            }
            return dp[0,0];
        }

        public static void Execute()
        {
            Console.WriteLine(isMatch("aabbbbbcdda", "a*bb*cdda"));
        }
    }
}
