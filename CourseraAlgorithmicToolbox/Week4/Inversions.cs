using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseraAlgorithmicToolbox.Week4
{
    public class Inversions
    {
        public static int InversionsRecursive(List<int> numbers, out List<int> results, int low, int high)
        {
            if(low == high)
            {
                results = new List<int>
                {
                    numbers[low]
                };
                return 0;
            }

            var mid = (int)Math.Round(low + ((double)high - low) / 2, MidpointRounding.AwayFromZero);
            var newHigh = mid - 1;
            var newLow = mid;

            var invList1 = new List<int>();
            var invList2 = new List<int>();

            var inv1 = InversionsRecursive(numbers, out invList1, low, newHigh);
            var inv2 = InversionsRecursive(numbers, out invList2, newLow, high);

            var inv = inv1 + inv2;

            results = new List<int>();

            var i = 0;
            var j = 0;

            while (i < invList1.Count && j < invList2.Count)
            {
                var a = invList1[i];
                var b = invList2[j];

                if(a <= b)
                {
                    results.Add(a);
                    i++;
                }
                else
                {
                    results.Add(b);
                    inv += mid - low - i;
                    j++;
                }
            }

            for(var k = i; k < invList1.Count; k++)
            {
                results.Add(invList1[k]);
            }

            for (var k = j; k < invList2.Count; k++)
            {
                results.Add(invList2[k]);
            }

            return inv;
        }

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();

            var results = new List<int>();
            var result = InversionsRecursive(numbers, out results, 0, numbers.Count - 1);
            Console.WriteLine(result);
        }
    }
}
