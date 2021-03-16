using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class permuteString
    {
        public static void Execute()
        {
            string str = "BAD";
            char[] charArry = str.ToCharArray();
            permute(charArry, 0);
            Console.ReadKey();
        }

        static void swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
            //Console.WriteLine($"Swapping {a} with {b}");
        }

        static void permute(char[] arry, int left)
        {
            if (left == arry.Length)
            {
                Console.WriteLine(string.Join("", arry) + "       Done");
            }

            for (int j=left; j< arry.Length; j++)
            {

                swap(ref arry[left],ref arry[j]);
                Console.WriteLine($"j:{j}  left:{left}  ");
                permute(arry,left+1);
                swap(ref arry[j], ref arry[left]);
                Console.WriteLine($"BKT j:{j}  left:{left}");
            }
        }
    }
}
