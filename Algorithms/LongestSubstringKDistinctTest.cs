using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class LongestSubstringKDistinctTest
    {

        public static int findLength(String str, int k)
        {
            if (string.IsNullOrEmpty(str) || str.Length < k)
                throw new ArgumentException();

            int windowStart = 0,end=0, maxLength = 0;
            Dictionary<char, int> charFrequencyMap = new Dictionary<char, int>();
            // in the following loop we'll try to extend the range [windowStart, windowEnd]
          
            while(end<str.Length)
            {
                if(charFrequencyMap.Count>2)
                {
                    charFrequencyMap[str[end]] = charFrequencyMap[str[end]] - 1;
                    maxLength = Math.Max(maxLength, end - windowStart);
                    windowStart++;
                }
                else
                {
                    if ( charFrequencyMap.ContainsKey(str[end]) )
                    {
                        charFrequencyMap[str[end]] = charFrequencyMap[str[end]] + 1;
                    }
                    else
                    {
                        charFrequencyMap.Add(str[end], 1);
                    }
                    end++;
                }
            }

            return maxLength;
        }

        public static void Execute()
        {
           Console.WriteLine("Length of the longest substring: " + findLength("araaci", 2));
            Console.WriteLine("Length of the longest substring: " +findLength("araaci", 1));
            Console.WriteLine("Length of the longest substring: " +findLength("cbbebi", 3));
        }

    }
}
