using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class PriorityQueue
    {
        /// <summary>
        /// Lowest number always comes on the top
        /// </summary>
        public static void Execute()
        {
            List<int> data = new List<int> { 2, 5, 8, 9, 35, 48 };
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                data.Add(number);

                for (int i = data.Count() - 1; i >= 0; i--)
                {
                    if (data[i] <= data[i-1])
                    {
                        data[i ] = data[i-1];
                        data[i-1] = number;
                    }
                    else { break; }
                }

                Console.WriteLine("");
                data.ForEach(w => Console.WriteLine(w));
            }
            

        }
    }
}
