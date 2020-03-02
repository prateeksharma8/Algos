using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Interval
    {
        public int start;
        public int end;

        public Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    };

    public static class MergeInterval
    {
        public static List<Interval> merge(List<Interval> intervals)
        {
            if (intervals.Count < 2)
                return intervals;

            // sort the intervals by start time
            intervals = intervals.OrderBy(x => x.start).ToList();

            List<Interval> mergedIntervals = new List<Interval>();
            Interval interval = intervals.First();
            int start = interval.start;
            int end = interval.end;
            int i = 1;
            while (i<intervals.Count)
            {
                interval = intervals[i];
                if (interval.start <= end)
                { // overlapping intervals, adjust the 'end'
                    end = Math.Max(interval.end, end);
                }
                else
                { // non-overlapping interval, add the previous interval and reset
                    mergedIntervals.Add(new Interval(start, end));
                    start = interval.start;
                    end = interval.end;
                }

                i++;
            }
            // add the last interval
            mergedIntervals.Add(new Interval(start, end));

            return mergedIntervals;
        }

        public static void Execute()
        {
            List<Interval> input = new List<Interval>();
            input.Add(new Interval(1, 4));
            input.Add(new Interval(2, 5));
            input.Add(new Interval(7, 9));
            Console.WriteLine("Merged intervals: (1,4) (2,5) (7,9)");
            foreach (Interval interval in merge(input))
                Console.WriteLine("[" + interval.start + "," + interval.end + "] ");
            Console.WriteLine();


           input = new List<Interval>();
            input.Add(new Interval(6, 7));
            input.Add(new Interval(2, 4));
            input.Add(new Interval(5, 9));
            Console.WriteLine("Merged intervals: (6, 7),(2, 4),(5, 9)");
            foreach (Interval interval in merge(input))
                Console.WriteLine("[" + interval.start + "," + interval.end + "] ");
            Console.WriteLine();
        }
    }
}
