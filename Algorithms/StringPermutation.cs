using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public static class StringPermutation
    {
        public static bool findPermutation(String str, String pattern)
        {
            int windowStart = 0, matched = 0;
            Dictionary<Char, int> charFrequencyMap = new Dictionary<Char, int>();
            foreach (Char chr in pattern)
            {
                if (charFrequencyMap.ContainsKey(chr))
                {
                    charFrequencyMap[chr]++;
                }
                else
                {
                    charFrequencyMap.Add(chr,1);
                }
            }

            // our goal is to match all the characters from the 'charFrequencyMap' with the current window
            // try to extend the range [windowStart, windowEnd]
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];
                if (charFrequencyMap.ContainsKey(rightChar))
                {
                    // decrement the frequency of the matched character
                    charFrequencyMap[rightChar]--;
                    if (charFrequencyMap[rightChar] == 0)
                    {
                        // character is completely matched
                        matched++;
                    }
                }

                if (matched == (int) charFrequencyMap.Keys.Count())
                {
                    return true;
                }

                if (windowEnd >= pattern.Length - 1)
                {
                    // shrink the window
                    char leftChar = str[windowStart++];
                    if (charFrequencyMap.ContainsKey(leftChar))
                    {
                        if (charFrequencyMap[leftChar] == 0)
                        {
                            matched--; // before putting the character back, decrement the matched count
                        }

                        // put the character back for matching
                        charFrequencyMap[leftChar]++;
                    }
                }
            }

            return false;
        }


        public static void Execute()
        {
            Console.WriteLine("Permutation exist: " + StringPermutation.findPermutation("abfacb", "abc"));
            Console.WriteLine("Permutation exist: " + StringPermutation.findPermutation("oidbcaf", "abc"));
            Console.WriteLine("Permutation exist: " + StringPermutation.findPermutation("odicf", "dc"));
            Console.WriteLine("Permutation exist: " + StringPermutation.findPermutation("bcdxjabcdy", "bcdyabcdx"));
            Console.WriteLine("Permutation exist: " + StringPermutation.findPermutation("aaacb", "abc"));
        }

    }
}
