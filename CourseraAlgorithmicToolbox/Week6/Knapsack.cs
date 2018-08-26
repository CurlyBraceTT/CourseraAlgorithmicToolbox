using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseraAlgorithmicToolbox.Week6
{
    public class Knapsack
    {
        public static int Calculate(List<int> bars, int capacity)
        {
            var n = bars.Count + 1;
            var W = capacity + 1;

            var values = new int[W, n];

            for (var i = 0; i < n; i++)
            {
                values[0, i] = 0;
            }
            for (var w = 0; w < W; w++)
            {
                values[w, 0] = 0;
            }

            for(var i = 1; i < n; i++)
            {
                for (var w = 1; w < W; w++)
                {
                    var wi = bars[i - 1];

                    values[w, i] = values[w, i - 1];
                    if(wi <= w)
                    {
                        var value = values[w - wi, i - 1] + wi;

                        if(values[w, i] < value)
                        {
                            values[w, i] = value;
                        }
                    }
                }
            }

            return values[W - 1, n - 1];
        }

        public static void Main(string[] args)
        {
            var capacity = int.Parse(Console.ReadLine().Split(' ')[0]);
            var bars = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var result = Calculate(bars, capacity);
            Console.WriteLine(result);
        }
    }
}
