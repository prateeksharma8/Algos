using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.K_WayMerge
{
    public class MinimumWindowSubstring
    {
        public static String findSubstring(String str, String pattern)
        {
            int windowStart = 0, matched = 0, minLength = str.Length + 1, subStrStart = 0;
            Dictionary<char, int> charFrequencyMap = new Dictionary<char, int>();
            foreach (char chr in pattern.ToCharArray())
                charFrequencyMap.Add(chr, charFrequencyMap.GetValueOrDefault(chr, 0) + 1);

            // try to extend the range [windowStart, windowEnd]
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];
                if (charFrequencyMap.ContainsKey(rightChar))
                {
                    charFrequencyMap[rightChar] = charFrequencyMap[rightChar] - 1;
                    if (charFrequencyMap[rightChar] >= 0) // count every matching of a character
                        matched++;
                }

                // shrink the window if we can, finish as soon as we remove a matched character
                while (matched == pattern.Length)
                {
                    if (minLength > windowEnd - windowStart + 1)
                    {
                        minLength = windowEnd - windowStart + 1;
                        subStrStart = windowStart;
                    }

                    char leftChar = str[windowStart++];
                    if (charFrequencyMap.ContainsKey(leftChar))
                    {
                        // note that we could have redundant matching characters, therefore we'll decrement the
                        // matched count only when a useful occurrence of a matched character is going out of the window
                        if (charFrequencyMap[leftChar] == 0)
                            matched--;
                        charFrequencyMap[leftChar] = charFrequencyMap[leftChar] + 1;
                    }
                }
            }

            return minLength > str.Length ? "" : str.Substring(subStrStart, minLength);
        }

        public static void Execute()
        {
            Console.WriteLine(MinimumWindowSubstring.findSubstring("aabdecabc", "abc"));
            //Console.WriteLine(MinimumWindowSubstring.findSubstring("abdabca", "abc"));
            //Console.WriteLine(MinimumWindowSubstring.findSubstring("adcad", "abc"));
        }
    }
}
