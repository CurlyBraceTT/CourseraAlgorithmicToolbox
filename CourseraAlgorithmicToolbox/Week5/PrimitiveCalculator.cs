using System;
using System.Collections.Generic;

namespace CourseraAlgorithmicToolbox.Week5
{
    public class PrimitiveCalculator
    {
        public static List<int> Calculate(int number)
        {
            var minNum = new int[number + 1];
            var back = new int[number + 1];

            minNum[1] = 0;

            for(var i = 2; i <= number; i++)
            {
                var min = 0;
                var backIndex = i - 1;

                if (i % 3 == 0)
                {
                    backIndex = i / 3;
                    min = minNum[backIndex] + 1;
                }
                else if(i % 2 == 0)
                {
                    backIndex = i / 2;
                    min = minNum[backIndex] + 1;
                }
                else
                {
                    min = minNum[backIndex] + 1;
                }

                if(min > minNum[i - 1] + 1)
                {
                    backIndex = i - 1;
                }

                minNum[i] = minNum[backIndex] + 1;
                back[i] = backIndex;
            }

            var path = new List<int>();
            var backNumber = number;
            while(backNumber >= 1)
            {
                path.Add(backNumber);
                backNumber = back[backNumber];
            }

            return path;
        }

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = Calculate(n);
            Console.WriteLine(result.Count - 1);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
