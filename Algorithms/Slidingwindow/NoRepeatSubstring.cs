using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Slidingwindow
{

    public static class NoRepeatSubstring
    {
        public static int findLength(String str)
        {
            int windowStart = 0, maxLength = 0;
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            // try to extend the range [windowStart, windowEnd]
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];
                // if the map already contains the 'rightChar', shrink the window from the beginning so that
                // we have only one occurrence of 'rightChar'
                if (charIndexMap.ContainsKey(rightChar))
                {
                    // this is tricky; in the current window, we will not have any 'rightChar' after its previous index
                    // and if 'windowStart' is already ahead of the last index of 'rightChar', we'll keep 'windowStart'
                    windowStart = Math.Max(windowStart, charIndexMap[rightChar] + 1);
                }
                charIndexMap[rightChar]= windowEnd; // insert the 'rightChar' into the map
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1); // remember the maximum length so far
            }

            return maxLength;
        }

        public static void Execute()
        {
           Console.WriteLine("Length of the longest substring: " + NoRepeatSubstring.findLength("aabccbb"));
           Console.WriteLine("Length of the longest substring: " + NoRepeatSubstring.findLength("abbbb"));
           Console.WriteLine("Length of the longest substring: " + NoRepeatSubstring.findLength("abccde"));
        }
    }
}
