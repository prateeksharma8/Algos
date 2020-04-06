using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class TestPermute
    {
        public static void Execute()
        {
            string str = "ABC";
            char[] charArry = str.ToCharArray();
            permute(charArry, 0, charArry.Length);
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

        static void permute(char[] arry, int i, int n)
        {
            if(i==n)
                Console.WriteLine(arry);

           for(int j=i; j<n;j++)
            {
                swap(ref arry[i],ref arry[j]);
                permute(arry,i+1,n);
                swap(ref arry[j], ref arry[i]);

            }
        }
    }
}
