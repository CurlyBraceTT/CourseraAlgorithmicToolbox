using System;
using System.Collections.Generic;

namespace CourseraAlgorithmicToolbox.Week2
{
    public class FibonacciPartialSum
    {
        private static List<ulong> FindPisanoPeriodFull(ulong period = 10)
        {
            ulong f0 = 0;
            ulong f1 = 1;
            ulong f = 0;

            var numbers = new List<ulong>();
            numbers.Add(f0);
            numbers.Add(f1);

            do
            {
                f = f0 + f1;
                f = f % period;
                numbers.Add(f);
                f0 = f1;
                f1 = f;
            }
            while (!(f0 == 0 && f1 == 1));

            numbers.RemoveAt(numbers.Count - 1);
            numbers.RemoveAt(numbers.Count - 1);

            return numbers;
        }

        private static ulong Calculate(ulong m, ulong n)
        {
            var period = FindPisanoPeriodFull();

            var remainderFrom = (int)(n % (ulong)period.Count);
            var remainderTo = (int)(m % (ulong)period.Count);

            if(remainderFrom == remainderTo)
            {
                return period[remainderFrom];
            }

            ulong sum = 0;
            for (var i = remainderFrom; i <= remainderTo; i++)
            {
                sum += period[i];
            }

            return sum % 10;
        }

        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            string[] tokens = numbers.Split(' ');

            var n = ulong.Parse(tokens[0]);
            var m = ulong.Parse(tokens[1]);
            var result = Calculate(m, n);
            Console.WriteLine(result);
        }
    }
}
