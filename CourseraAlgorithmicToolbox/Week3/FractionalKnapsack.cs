using System;
using System.Collections.Generic;

namespace CourseraAlgorithmicToolbox.Week3
{
    public class FractionalKnapsack
    {
        public static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');

            uint n = uint.Parse(firstLine[0]);
            ulong w = ulong.Parse(firstLine[1]);

            var items = new List<(ulong value, ulong weight)>();

            for(var i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var item = ( value: ulong.Parse(line[0]), weight: ulong.Parse(line[1]));
                items.Add(item);
            }

            items.Sort((a, b) => ((double)b.value / b.weight).CompareTo((double)a.value / a.weight));

            double sum = 0;
            double wholeValue = 0;
            while(sum < w && items.Count > 0)
            {
                foreach(var (value, weight) in items)
                {
                    if(sum + weight <= w)
                    {
                        sum += weight;
                        wholeValue += value;
                        break;
                    }
                    else if(sum + weight > w)
                    {
                        wholeValue += value / (weight / (w - sum));
                        sum = w;
                    }
                }
                items.RemoveAt(0);
            }

            Console.WriteLine($"{wholeValue:N4}");
        }
    }
}
