using System;

namespace CourseraAlgorithmicToolbox.Week2
{
    public class FibonacciHuge
    {
        private static ulong FindPisanoPeriod(ulong m)
        {
            ulong f0 = 0;
            ulong f1 = 1;
            ulong f = 0;
            ulong i = 0;

            do
            {
                i++;
                f = f0 + f1;
                f = f % m;
                f0 = f1;
                f1 = f;
            }
            while (!(f0 == 0 && f1 == 1));

            return i;
        }

        private static ulong Calculate(ulong n, ulong m)
        {
            if (n <= 1)
            {
                return n;
            }

            var period = FindPisanoPeriod(m);
            var remainder = n % period;

            ulong f0 = 0;
            ulong f1 = 1;
            ulong f = 0;

            if (remainder <= 1)
            {
                return remainder;
            }

            for (uint i = 2; i <= remainder; i++)
            {
                f = f0 + f1;
                f = f % m;
                f0 = f1;
                f1 = f;
            }

            return f;
        }

        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            string[] tokens = numbers.Split(' ');

            var n = ulong.Parse(tokens[0]);
            var m = ulong.Parse(tokens[1]);
            var result = Calculate(n, m);
            Console.WriteLine(result);
        }
    }
}
