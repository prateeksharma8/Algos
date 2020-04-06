using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class BinarySearch
    {
        public static void Execute()
        {
            while (true)
            {
                Console.WriteLine("Enter Number:");
                int number = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[] { 1, 3, 6, 8, 10, 12, 16, 18 };
                int right = 0, left = arr.Length-1;
                int mid = 0;
                while (right <= left)
                {
                    mid = (right + left) / 2;
                    if (arr[mid] == number)
                    {
                        Console.WriteLine("Number found");
                    }
                    if (arr[mid] < number)
                    {
                        left = mid - 1;
                    }
                    else
                    {
                        right = mid + 1;
                    }

                }
            }
        }
    }
}
