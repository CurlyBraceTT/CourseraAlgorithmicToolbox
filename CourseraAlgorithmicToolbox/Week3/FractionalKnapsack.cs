using System;
using System.Collections.Generic;
using System.Globalization;

namespace CourseraAlgorithmicToolbox.Week3
{
    public class FractionalKnapsack
    {
        public struct Item
        {
            public ulong Value;
            public ulong Weight;
        }

        public static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');

            uint n = uint.Parse(firstLine[0]);
            ulong w = ulong.Parse(firstLine[1]);

            var items = new List<Item>();

            for (var i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var item = new Item()
                {
                    Value = ulong.Parse(line[0]),
                    Weight = ulong.Parse(line[1])
                };
                items.Add(item);
            }

            items.Sort((a, b) => ((double)b.Value / b.Weight).CompareTo((double)a.Value / a.Weight));

            double sum = 0;
            double wholeValue = 0;
            while(sum < w && items.Count > 0)
            {
                foreach(var item in items)
                {
                    var weight = item.Weight;
                    var value = item.Value;

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

            NumberFormatInfo nfi = new NumberFormatInfo
            {
                NumberDecimalSeparator = ".",
                NumberGroupSeparator = string.Empty
            };
            var x = wholeValue.ToString("N4", nfi);

            Console.WriteLine(x);
        }
    }
}
