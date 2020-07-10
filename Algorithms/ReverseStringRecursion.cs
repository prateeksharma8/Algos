using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class ReverseStringRecursion
    {

        public static void Execute()
        {
            Console.Write( ReverseString_Rec("TEST"));
            Console.ReadKey();
        }

        public static string ReverseString_Rec(string str)
        {
            if (str.Length <= 1)
                return str;
            else
                return ReverseString_Rec(str.Substring(1)) + str[0];
        }

    }
}
