using System;

namespace CourseraAlgorithmicToolbox.Week2
{
    public class LCM
    {
        private static ulong Calculate(ulong a, ulong b)
        {
            var startA = a;
            var startB = b;

            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            // Order prevents overflow
            ulong result = startA * (startB / a);
            return result;
        }

        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            string[] tokens = numbers.Split(' ');

            var a = ulong.Parse(tokens[0]);
            var b = ulong.Parse(tokens[1]);
            var result = Calculate(a, b);
            Console.WriteLine(result);
        }
    }
}
