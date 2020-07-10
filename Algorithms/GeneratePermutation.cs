using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class GeneratePermutation
    {
        public static void Execute()
        {
            Console.Write("Input String>");
            string inputLine = Console.ReadLine();

            Recursion rec = new Recursion();
            rec.InputSet = rec.MakeCharArray(inputLine);
            rec.CalcPermutation(0);

            Console.Write("# of Permutations: " + rec.PermutationCount);
        }
    }
    /// <summary>
    /// Algorithm Source: A. Bogomolny, Counting And Listing 
    /// All Permutations from Interactive Mathematics Miscellany and Puzzles
    /// http://www.cut-the-knot.org/do_you_know/AllPerm.shtml, Accessed 11 June 2009
    /// </summary>
    class Recursion
    {
        private int elementLevel = -1;
        private int numberOfElements;
        private int[] permutationValue = new int[0];
                
        public char[] InputSet { get; set; }
        
        public int PermutationCount { get; set; }

        public char[] MakeCharArray(string InputString)
        {
            char[] charString = InputString.ToCharArray();
            Array.Resize(ref permutationValue, charString.Length);
            numberOfElements = charString.Length;
            return charString;
        }

        public void CalcPermutation(int k)
        {
            elementLevel++;
            permutationValue.SetValue(elementLevel, k);

            if (elementLevel == numberOfElements)
            {
                Console.WriteLine("OutputPermutation:" +string.Join("", permutationValue));
                OutputPermutation(permutationValue);
            }
            else
            {
                Console.WriteLine("elementLevel:" + elementLevel);
                for (int i = 0; i < numberOfElements; i++)
                {
                    if (permutationValue[i] == 0)
                    {
                        CalcPermutation(i);
                    }
                }
            }
            elementLevel--;
            Console.WriteLine("elementLevel--:" + elementLevel);
            Console.WriteLine("permutationValue.SetValue(0, k):0," + k);
            permutationValue.SetValue(0, k);
        }

        private void OutputPermutation(int[] value)
        { 
            foreach (int i in value)
            {
                Console.Write(InputSet.GetValue(i - 1) );
            }

            Console.WriteLine();
            PermutationCount++;
        }
    }
}
