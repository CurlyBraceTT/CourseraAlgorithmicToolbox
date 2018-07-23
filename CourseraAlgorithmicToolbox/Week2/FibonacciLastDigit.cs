using System;

namespace CourseraAlgorithmicToolbox.Week2
{
    public class FibonacciLastDigit
    {
        private static uint Calculate(uint n)
        {
            if (n <= 1)
            {
                return n;
            }

            uint f0 = 0;
            uint f1 = 1;
            uint f = 0;

            for (ulong i = 2; i <= n; i++)
            {
                f = f0 + f1;

                f = f % 10;

                f0 = f1;
                f1 = f;
            }

            return f;
        }

        public static void Main(string[] args)
        {
            var n = uint.Parse(Console.ReadLine());
            var result = Calculate(n);
            Console.WriteLine(result);
        }
    }
}
