using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public static class StringSegmentation
    {

        public static bool canSegmentString(String s, Dictionary<string, string> dictionary)
        {
            for (int i = 1; i <= s.Length; ++i)
            {
                String first = s.Substring(0, i);
                if (dictionary.ContainsKey(first))
                {
                    String second = s.Substring(i);

                    if (second == null || second.Length == 0 || dictionary.ContainsKey(second) || canSegmentString(second, dictionary))
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public static void Execute()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            String s = "hellonow";

            dictionary.Add("hello","");
            dictionary.Add("hell", "");
            dictionary.Add("on", "");
            dictionary.Add("now", "");
            if (canSegmentString(s, dictionary))
            {
                Console.WriteLine("String Can be Segmented");
            }
            else
            {
                Console.WriteLine("String Can NOT be Segmented");
            }
        }
    }
}
