using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseraAlgorithmicToolbox.Week5
{
    public class LCS2
    {
        public static int Calculate(List<int> seq1, List<int> seq2)
        {
            var n = seq1.Count + 1;
            var m = seq2.Count + 1;
            var d = new int[n, m];

            for (var j = 0; j < m; j++)
            {
                d[0, j] = 0;
            }
            for (var i = 0; i < n; i++)
            {
                d[i, 0] = 0;
            }

            for (var j = 1; j < m; j++)
            {
                for (var i = 1; i < n; i++)
                {
                    var insertion = d[i, j - 1];
                    var deletion = d[i - 1, j];

                    var check = d[i - 1, j - 1];

                    if (seq1[i - 1] == seq2[j - 1])
                    {
                        check++;
                    }
                    d[i, j] = Math.Max(insertion, Math.Max(deletion, check));
                }
            }

            return d[n - 1, m - 1];
        }

        public static void Main(string[] args)
        {
            int.Parse(Console.ReadLine());
            var seq1 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            int.Parse(Console.ReadLine());
            var seq2 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var result = Calculate(seq1, seq2);
            Console.WriteLine(result);
        }
    }
}
