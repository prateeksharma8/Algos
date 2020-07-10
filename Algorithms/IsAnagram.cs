using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class IsAnagram
    {
        static bool AreAnagram(string s1, string s2)
        {
            s1 = s1.ToLower();

            s2 = s2.ToLower();

            if (s1.Length != s2.Length)
                return false;

            foreach (char c in s1)
            {
                int ix = s2.IndexOf(c);

                if (ix == -1)
                    return false;
            }

            return true;
        }

        public static void Execute()
        {
            Console.WriteLine("Test, ESfT" + AreAnagram("Test", "ESTT"));

            Console.WriteLine("Army, Mary" + AreAnagram("Army", "Mary"));

            Console.WriteLine("ABCD, DCBA" + AreAnagram("ABCD", "DCBA"));

            Console.ReadLine();
        }
    }
}
