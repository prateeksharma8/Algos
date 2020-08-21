using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.K_WayMerge
{

    public class CharacterReplacement
    {
        public static int findLength(String str, int k)
        {
            int windowStart = 0, maxLength = 0, maxRepeatLetterCount = 0;
            Dictionary<char, int> letterFrequencyMap = new Dictionary<char, int>();
            // try to extend the range [windowStart, windowEnd]
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];
                if(!letterFrequencyMap.ContainsKey(rightChar))
                {
                    letterFrequencyMap.Add(rightChar, 0);
                }
                letterFrequencyMap[rightChar]= letterFrequencyMap.GetValueOrDefault(rightChar, 0) + 1;
                maxRepeatLetterCount = Math.Max(maxRepeatLetterCount, letterFrequencyMap.GetValueOrDefault(rightChar));
                // current window size is from windowStart to windowEnd, overall we have a letter which is
                // repeating 'maxRepeatLetterCount' times, this means we can have a window which has one letter 
                // repeating 'maxRepeatLetterCount' times and the remaining letters we should replace.
                // if the remaining letters are more than 'k', it is the time to shrink the window as we
                // are not allowed to replace more than 'k' letters
                if (windowEnd - windowStart + 1 - maxRepeatLetterCount > k)
                {
                    char leftChar = str[windowStart];
                    letterFrequencyMap[leftChar]= letterFrequencyMap.GetValueOrDefault(leftChar) - 1;
                    windowStart++;
                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }
            return maxLength;
        }
        public static void Execute()
        {
            Console.WriteLine("Length of the longest substring 'aadbbcccccbb': " + findLength("aadbbcccccbb", 2));
            Console.WriteLine("Length of the longest substring 'abbbb': " + findLength("abbbb",2));
            Console.WriteLine("Length of the longest substring 'abccde': " + findLength("abccde",2));
        }
    }
}
