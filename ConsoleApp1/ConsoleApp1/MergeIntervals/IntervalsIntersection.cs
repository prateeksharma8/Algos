using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.MergeIntervals
{
    public static class IntervalsIntersection
    {
        public static List<Interval> merge(Interval[] arr1, Interval[] arr2)
        {
            List<Interval> result = new List<Interval>();
            int i = 0, j = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                // check if the interval arr[i] intersects with arr2[j]
                // check if one of the interval's start time lies within the other interval
                if ((arr1[i].start >= arr2[j].start && arr1[i].start <= arr2[j].end)
                    || (arr2[j].start >= arr1[i].start && arr2[j].start <= arr1[i].end))
                {
                    // store the intersection part
                    result.Add(new Interval(Math.Max(arr1[i].start, arr2[j].start), Math.Min(arr1[i].end, arr2[j].end)));
                }

                // move next from the interval which is finishing first
                if (arr1[i].end < arr2[j].end)
                    i++;
                else
                    j++;
            }

            return result;
        }

        public static void Execute()
        {
            Interval[] input1 = new Interval[] { new Interval(1, 3), new Interval(5, 6), new Interval(7, 9) };
            Interval[] input2 = new Interval[] { new Interval(2, 3), new Interval(5, 7) };
            Console.WriteLine("(1, 3), (5, 6), (7, 9) and (2, 3),(5, 7)");
            foreach (Interval interval in merge(input1, input2))
                Console.WriteLine("[" + interval.start + "," + interval.end + "] ");
            Console.WriteLine();

            input1 = new Interval[] { new Interval(1, 3), new Interval(5, 7), new Interval(9, 12) };
            input2 = new Interval[] { new Interval(5, 10) };
            Console.WriteLine("(1, 3),(5, 7), (9, 12) and (5, 10)");

            foreach (Interval interval in merge(input1, input2))
                Console.WriteLine("[" + interval.start + "," + interval.end + "] ");
            Console.WriteLine();

        }

    }
}
