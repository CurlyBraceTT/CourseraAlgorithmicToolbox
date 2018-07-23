using System;

namespace CourseraAlgorithmicToolbox.Week1
{
    // Repl https://repl.it/@CurlyBrace/MaxPairwiseProduct
    public class MaxPairwiseProduct
    {
        public static void Main(string[] args)
        {
            var length = ulong.Parse(Console.ReadLine());
            var numbers = new ulong[length];

            var numbersStr = Console.ReadLine();
            string[] tokens = numbersStr.Split(' ');

            ulong[] convertedItems = Array.ConvertAll(tokens, ulong.Parse);

            for (ulong i = 0; i < length; i++)
            {
                numbers[i] = convertedItems[i];
            }

            if (length < 2)
            {
                throw new ArgumentException("Should be at least one pair");
            }

            ulong max1 = numbers[0];
            ulong max2 = numbers[1];

            if (max2 > max1)
            {
                var temp = max1;
                max1 = max2;
                max2 = temp;
            }

            for (ulong i = 2; i < length; i++)
            {
                if (numbers[i] > max1)
                {
                    max2 = max1;
                    max1 = numbers[i];
                }
                else if (numbers[i] > max2)
                {
                    max2 = numbers[i];
                }
            }

            Console.WriteLine(max1 * max2);
        }
    }
}