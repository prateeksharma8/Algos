using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms._2Pointers
{
    public static class MoveZeros
    {
        static void moveZerosToLeft(int[] A)
        {
            if (A.Length < 1)
            {
                return;
            }

            int writeIndex = A.Length - 1;
            int readIndex = A.Length - 1;

            while (readIndex >= 0)
            {
                if (A[readIndex] != 0)
                {
                    A[writeIndex] = A[readIndex];
                    writeIndex--;
                }

                readIndex--;
            }

            while (writeIndex >= 0)
            {
                A[writeIndex] = 0;
                writeIndex--;
            }
        }

        static void moveZerosToLeftA(int[] A)
        {
            int start = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    int temp = A[i];
                    A[i] = A[start];
                    A[start] = temp;
                    start++;
                }
            }
        }

        public static void Execute()
        {
            int[] v = new int[] { 1, 10, 20, 0, 59, 63, 0, 88, 0 };
            Console.WriteLine("\n Original Array: ");
            Program.PrintArrays(v);



            moveZerosToLeft(v);
            Console.WriteLine("\n After Moving Zeroes to Left: ");
            Program.PrintArrays(v);
            v = new int[] { 1, 10, 20, 0, 59, 63, 0, 88, 0 };
            moveZerosToLeftA(v);
            Console.WriteLine("\n After Moving Zeroes to Left: ");
            Program.PrintArrays(v);

            moveZerosToLeftA(v);
            Console.WriteLine("\n After Moving Zeroes to Left: ");
            Program.PrintArrays(v);
        }
    }
}
