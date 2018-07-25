using System;

namespace CourseraAlgorithmicToolbox.Week2
{
    public class FibonacciSumLastDigit
    {
        private static ulong FindPisanoPeriod(ulong m = 10)
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

        private static ulong Calculate(ulong n, ulong m = 10)
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

            ulong sum = f0 + f1;
            for (uint i = 2; i <= remainder; i++)
            {
                f = f0 + f1;
                sum += f;
                sum = sum % m;
                f = f % m;
                f0 = f1;
                f1 = f;
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            var n = ulong.Parse(Console.ReadLine());
            var result = Calculate(n);
            Console.WriteLine(result);
        }
    }
}
