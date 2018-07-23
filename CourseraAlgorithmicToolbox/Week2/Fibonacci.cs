using System;

namespace CourseraAlgorithmicToolbox.Week2
{
    public class Fibonacci
    {
        private static ulong Calculate(ulong n)
        {
            if (n <= 1)
            {
                return n;
            }

            ulong f0 = 0;
            ulong f1 = 1;
            ulong f = 0;

            for (ulong i = 2; i <= n; i++)
            {
                f = f0 + f1;

                f0 = f1;
                f1 = f;
            }

            return f;
        }

        public static void Main(string[] args)
        {
            var n = ulong.Parse(Console.ReadLine());
            var result = Calculate(n);
            Console.WriteLine(result);
        }
    }
}
