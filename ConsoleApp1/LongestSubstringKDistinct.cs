using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class LongestSubstringKDistinct
    {

        public static int findLength(String str, int k)
        {
            if (string.IsNullOrEmpty(str) || str.Length < k)
                throw new ArgumentException();

            int windowStart = 0, maxLength = 0;
            Dictionary<char, int> charFrequencyMap = new Dictionary<char, int>();
            // in the following loop we'll try to extend the range [windowStart, windowEnd]
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                int value;
                char rightChar = str[windowEnd];
                charFrequencyMap.TryGetValue(rightChar, out value);
                charFrequencyMap.Add(rightChar, value + 1);
                // shrink the sliding window, until we are left with 'k' distinct characters in the frequency map
                while (charFrequencyMap.Count > k)
                {
                    char leftChar = str[windowStart];

                    charFrequencyMap.TryGetValue(leftChar, out value);

                    charFrequencyMap[leftChar] = value - 1;
                    charFrequencyMap.TryGetValue(leftChar, out value);

                    if (value == 0)
                    {
                        charFrequencyMap.Remove(leftChar);
                    }
                    windowStart++; // shrink the window
                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1); // remember the maximum length so far
            }

            return maxLength;
        }

        public static void Execute()
        {
           Console.WriteLine("Length of the longest substring: " + LongestSubstringKDistinct.findLength("araaci", 2));
            Console.WriteLine("Length of the longest substring: " + LongestSubstringKDistinct.findLength("araaci", 1));
            Console.WriteLine("Length of the longest substring: " + LongestSubstringKDistinct.findLength("cbbebi", 3));
        }

    }
}
