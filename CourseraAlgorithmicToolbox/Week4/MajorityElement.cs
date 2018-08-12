using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseraAlgorithmicToolbox.Week4
{
    public class MajorityElement
    {
        public static int CalculateMajorityElement(List<ulong> list)
        {
            var numbers = new Dictionary<ulong, int>();

            ulong maxNumber = 0;
            int maxCount = 0;
            for(var i = 0; i < list.Count; i++)
            {
                var number = list[i];
                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers.Add(number, 1);
                }

                if (numbers[number] > maxCount)
                {
                    maxCount = numbers[number];
                    maxNumber = number;
                }
            }

            if(maxCount <= list.Count / 2)
            {
                return 0;
            }

            foreach(var numberPair in numbers)
            {
                if(numberPair.Key == maxNumber)
                {
                    continue;
                }

                if(numberPair.Value >= maxCount)
                {
                    return 0;
                }
            }

            return 1;
        }

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(' ').Select(x => ulong.Parse(x)).ToList();

            var result = CalculateMajorityElement(list);
            Console.WriteLine(result);
        }
    }
}
