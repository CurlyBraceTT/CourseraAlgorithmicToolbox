using System;
using System.Collections.Generic;

namespace CourseraAlgorithmicToolbox.Week6
{
    public class PlacingParentheses
    {
        public struct MinMax
        {
            public long Max;
            public long Min;
        }

        public static long Parentheses(List<char> operations, List<long> values)
        {
            var n = values.Count;
            long[,] maximumValues = new long[n, n];
            long[,] minimumValues = new long[n, n];

            for (var i = 0; i < n; i++)
            {
                maximumValues[i, i] = values[i];
                minimumValues[i, i] = values[i];
            }

            for(var s = 0; s < n - 1; s++)
            {
                for(var i = 0; i < n - s - 1; i++)
                {
                    var j = i + s + 1;
                    var result = MinAndMax(maximumValues, minimumValues, operations, i, j);

                    minimumValues[i, j] = result.Min;
                    maximumValues[i, j] = result.Max;
                }
            }

            return maximumValues[0, n - 1];
        }

        public static MinMax MinAndMax(long[,] maximumValues, long[,] minimumValues, List<Char> operations, int i, int j)
        {
            var min = long.MaxValue;
            var max = long.MinValue;

            for(var k = i; k < j; k++)
            {
                var a = Apply(operations[k], maximumValues[i, k], maximumValues[k + 1, j]);
                var b = Apply(operations[k], maximumValues[i, k], minimumValues[k + 1, j]);
                var c = Apply(operations[k], minimumValues[i, k], maximumValues[k + 1, j]);
                var d = Apply(operations[k], minimumValues[i, k], minimumValues[k + 1, j]);

                min = Math.Min(min, Math.Min(a, Math.Min(b, Math.Min(c, d))));
                max = Math.Max(max, Math.Max(a, Math.Max(b, Math.Max(c, d))));
            }

            return new MinMax
            {
                Max = max,
                Min = min
            };
        }

        public static long Apply(char operation, long first, long second)
        {
            switch(operation)
            {
                case '*':
                    {
                        return first * second;
                    }
                case '-':
                    {
                        return first - second;
                    }
                case '+':
                    {
                        return first + second;
                    }
            }

            throw new InvalidOperationException();
        }

        public static void Main(string[] args)
        {
            var tokens = Console.ReadLine();
            var values = new List<long>();
            var operations = new List<char>();
            for (var i = 0; i < tokens.Length; i++)
            {
                if(i % 2 == 0)
                {
                    values.Add((long)Char.GetNumericValue(tokens[i]));
                }
                else
                {
                    operations.Add(tokens[i]);
                }
            }

            var result = Parentheses(operations, values);
            Console.WriteLine(result);
        }
    }
}
