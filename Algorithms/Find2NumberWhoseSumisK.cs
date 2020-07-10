using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Find2NumberWhoseSumisK
    {
        public static void Execute()
        {

            int[] arr = new int[] { 1, 2, 3, 8, 9, 10 };

            while(true)
            {
                Console.WriteLine("Required sum");
                int number = Convert.ToInt32(Console.ReadLine());

                int i = 0, j = arr.Length - 1;
                int sum = 0;
                while(i<=j)
                {
                    Console.WriteLine("i:"+ i + " j:"+ j);
                    sum = arr[i] + arr[j];
                    if(sum== number)
                    {
                        Console.WriteLine(arr[i] + " "+ arr[j]);
                        break;
                    }
                    else if(sum>number)
                    {
                        j--;
                    }
                    else
                    {
                        i++;
                    }
                }
            }


        }
    }
}
