using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public static class NoRepeatSubstring
    {
        public static void findLength(String str)
        {
            int start = 0;
            char locValue;

            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            int maxLength = 0;
            int location = 0;
            for (location = 0; location < str.Length ; location++)
            {
                locValue = str[location];
                if (dictionary.ContainsKey(locValue))
                {
                    dictionary[locValue]++;
                }
                else
                {
                    dictionary.Add(locValue, 1);
                }
                maxLength = Math.Max(maxLength, location - start+1);

                if (dictionary.Count > 2)
                {
                    dictionary.Remove(str[start++]);
                }
            }



            Console.WriteLine($"MaxLength: {maxLength} ");
            foreach (KeyValuePair<char, int> pair in dictionary)
            {
                Console.WriteLine(pair);
            }
        }

        public static void Execute()
        {
            findLength("abccdddde");
        }
    }
}


