using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class CountUniqueElements
    {
        // Count the number of unique elements
        //public static int countUnique(int[] A)
        //{
        //    int count = 0;
        //    for (int i = 0; i < A.Length - 1; i++)
        //    {
        //        if (A[i] == A[i + 1])
        //        {
        //            count++;
        //        }
        //    }
        //    return (A.Length - count);
        //}

        public static int countUnique(int[] A)
        {
            int count = 1;
            int temp = A[0];
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i]!= A[i+1])
                {
                    count++;
                }
            }
            return count;
        }

        public static void Execute()
        {
            int[] arr = { 1,2,3,4,5,6,6,7,7 };
            int size = countUnique(arr);
            Console.WriteLine(size);
        }
    }
}
