using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseraAlgorithmicToolbox.Week5
{
    public class LCS3
    {
        public static int Calculate(List<int> seq1, List<int> seq2, List<int> seq3)
        {
            var n = seq1.Count + 1;
            var m = seq2.Count + 1;
            var l = seq3.Count + 1;
            var d = new int[n, m, l];

            for (var j = 0; j < m; j++)
            {
                d[0, j, 0] = 0;
            }
            for (var i = 0; i < n; i++)
            {
                d[i, 0, 0] = 0;
            }
            for (var k = 0; k < l; k++)
            {
                d[0, 0, k] = 0;
            }

            for (var j = 1; j < m; j++)
            {
                for (var i = 1; i < n; i++)
                {
                    for(var k = 1; k < l; k++)
                    {
                        var insertion = d[i, j - 1, k];
                        var deletion = d[i - 1, j, k];
                        var something = d[i, j, k -1];

                        var check = d[i - 1, j - 1, k - 1];

                        if (seq1[i - 1] == seq2[j - 1] && seq1[i - 1] == seq2[k - 1])
                        {
                            check++;
                        }

                        var max1 = Math.Max(deletion, insertion);
                        var max2 = Math.Max(something, max1);
                        d[i, j, k] = Math.Max(max2, check);
                    }

                }
            }

            return d[n - 1, m - 1, l -1];
        }

        public static void Main(string[] args)
        {
            int.Parse(Console.ReadLine());
            var seq1 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            int.Parse(Console.ReadLine());
            var seq2 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            int.Parse(Console.ReadLine());
            var seq3 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var result = Calculate(seq1, seq2, seq3);
            Console.WriteLine(result);
        }
    }
}
