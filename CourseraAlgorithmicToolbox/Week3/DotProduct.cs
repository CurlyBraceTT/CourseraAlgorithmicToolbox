using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseraAlgorithmicToolbox.Week3
{
    class DotProduct
    {
        public static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            var perClickProfits = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
            var averageClicks = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();

            perClickProfits.Sort((a, b) => b.CompareTo(a));
            averageClicks.Sort((a, b) => b.CompareTo(a));

            long sum = 0;
            for(var i = 0; i < n; i++)
            {
                sum += perClickProfits[i] * averageClicks[i];
            }

            Console.WriteLine(sum);
        }
    }
}
