using System;

namespace CourseraAlgorithmicToolbox.Week2
{
    public class GCD
    {
        private static uint Calculate(uint a, uint b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            string[] tokens = numbers.Split(' ');

            var a = uint.Parse(tokens[0]);
            var b = uint.Parse(tokens[1]);
            var result = Calculate(a, b);
            Console.WriteLine(result);
        }
    }
}
