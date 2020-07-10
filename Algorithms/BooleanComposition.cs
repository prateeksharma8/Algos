using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class BooleanComposition
    {
        public static void Execute()
        {
            CompositionBooleans(string.Empty, 3);
        }
        private static void CompositionBooleans(string result, int counter)
        {
            if (counter == 0)
                return;

            bool[] booleans = new bool[2] { true, false };

            for (int j = 0; j < 2; j++)
            {
                StringBuilder stringBuilder = new StringBuilder(result);
                stringBuilder.Append(string.Format("{0} ", booleans[j].ToString())).ToString();
                Console.WriteLine($"j:{j}, counter:{counter}stringBuilder:{stringBuilder.ToString()}");
                if (counter == 1)
                    Console.WriteLine(stringBuilder.ToString());

                CompositionBooleans(stringBuilder.ToString(), counter - 1);
                //pp

            }
        }
    }
}
