using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DynamicProgramming
{
    public class EggDroppDP
    {

        public int getDrops(int eggs, int floors)
        {

            int[,] eggDrops = new int[eggs + 1,floors + 1];
            //base case 1:
            //if floors = 0 then no drops are required // OR floors = 1 then 1 drop is required
            for (int i = 1; i <= eggs; i++)
            {
                eggDrops[i,0] = 0;
                eggDrops[i,1] = 1;
            }
            //base case 2:
            //if only one egg is there then drops = floors
            for (int i = 1; i <= floors; i++)
            {
                eggDrops[1,i] = i;
            }

            for (int egg = 2; egg <= eggs; egg++)
            {
                for (int floor = 2; floor <= floors; floor++)
                {
                    eggDrops[egg,floor] = int.MaxValue;
                    int tempResult;
                    for (int k = 1; k <= floor; k++)
                    {
                        tempResult = 1 + Math.Max(eggDrops[egg - 1,k - 1], eggDrops[egg,floor - k]);
                        eggDrops[egg,floor] = Math.Min(tempResult, eggDrops[egg,floor]);
                    }
                }
            }
            // eggDrops[eggs,floors] will have the result : minimum number of drops required in worst case
            return eggDrops[eggs,floors];
        }

        public static void Execute()
        {
            EggDroppDP eggDP = new EggDroppDP();
            int eggs = 2;
            int floors = 10;
            Console.WriteLine($"(DP) Minimum number of drops required in worst case with eggs: {eggs} and floors: {floors} is : {eggDP.getDrops(eggs, floors)}");
        }
    }
}
