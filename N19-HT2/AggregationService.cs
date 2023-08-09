using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_HT2
{
    internal static class AggregationService
    {
        public static int Sum(params int[] values)
        {
            var sum = 0;
            foreach (var item in values)
                sum += item;
            return sum;
        }

        public static int Average(params int[] values)
        {
            return AggregationService.Sum(values) / values.Length;
        }

        public static int Min(params int[] values)
        {
            var min = values[0];
            foreach (var item in values)
            {
                if (item < min) min = item;
            }
            return min;
        }

        public static int Max(params int[] values)
        {
            var max = 0;
            foreach (var item in values)
            {
                if (item > max) max = item;
            }
            return max;
        }
        public static void Increment(ref int value)
        {
            if (value < int.MaxValue)
                value++;
        }
        public static void Decrement(ref int value)
        {
            if (value > int.MinValue)
                value--;
        }
    }
}
