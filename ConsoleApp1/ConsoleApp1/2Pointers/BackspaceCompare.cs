using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2Pointers
{
    public static class BackspaceCompare
    {

        public static bool compare(String str1, String str2)
        {
            Console.WriteLine($"str1:{ str1}  str2:{str2}");
            // use two pointer approach to compare the strings
            int index1 = str1.Length - 1, index2 = str2.Length - 1;
            while (index1 >= 0 || index2 >= 0)
            {

                int i1 = getNextValidCharIndex(str1, index1);
                int i2 = getNextValidCharIndex(str2, index2);

                if (i1 < 0 && i2 < 0) // reached the end of both the strings
                    return true;

                if (i1 < 0 || i2 < 0) // reached the end of one of the strings
                    return false;

                if (str1[i1] != str2[i2]) // check if the characters are equal
                    return false;

                index1 = i1 - 1;
                index2 = i2 - 1;
            }

            return true;
        }

        private static int getNextValidCharIndex(String str, int index)
        {
            while (index >= 0)
            {
                if (str[index] == '#') // found a backspace character
                {
                    index = index - 2;
                }
                else
                {
                    return index;
                }
            }

            return index;
        }

        public static void Execute()
        {
           // Console.WriteLine(BackspaceCompare.compare("x#", "z#"));
            Console.WriteLine(BackspaceCompare.compare("xy#z", "xyz#"));
            Console.WriteLine(BackspaceCompare.compare("xp#", "xyz##"));
            Console.WriteLine(BackspaceCompare.compare("xywrrmp", "xywrrmu#p"));
        }
    }
}
