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
            var backtrack = new int[n, m];  // -1 for deletion, 1 for insertion

            for (var j = 0; j < m; j++)
            {
                d[0, j] = j;
            }
            for (var i = 0; i < n; i++)
            {
                d[i, 0] = i;
            }

            for (var j = 1; j < m; j++)
            {
                for (var i = 1; i < n; i++)
                {
                    var insertion = d[i, j - 1] + 1;
                    var deletion = d[i - 1, j] + 1;

                    var check = d[i - 1, j - 1];

                    if (seq1[i - 1] == seq2[j - 1])
                    {
                        d[i, j] = Math.Min(insertion, Math.Min(deletion, check));
                    }
                    else
                    {
                        check++;
                        d[i, j] = Math.Min(insertion, Math.Min(deletion, check));
                    }
                }
            }

            var aligment = new List<Tuple<string, string>>();
            GetAligment(n - 1, m - 1, seq1, seq2, d, aligment);

            var matches = 0;
            foreach (var tuple in aligment)
            {
                if(tuple.Item1 == tuple.Item2)
                {
                    matches++;
                }
            }

            return matches;
        }

        public static void GetAligment(int i, int j, List<int> seq1, List<int> seq2, int[,] d, List<Tuple<string, string>> aligment)
        {
            if(i == 0 && j == 0)
            {
                return;
            }

            if(i > 0 && d[i, j] == d[i - 1, j] + 1)
            {
                aligment.Add(new Tuple<string, string>(seq1[i - 1].ToString(), "-"));
                GetAligment(i - 1, j, seq1, seq2, d, aligment);
            }
            else if (j > 0 && d[i, j] == d[i, j - 1] + 1)
            {
                aligment.Add(new Tuple<string, string>("-", seq2[j - 1].ToString()));
                GetAligment(i, j - 1, seq1, seq2, d, aligment);
            }
            else
            {
                aligment.Add(new Tuple<string, string>(seq1[i - 1].ToString(), seq2[j - 1].ToString()));
                GetAligment(i - 1, j - 1, seq1, seq2, d, aligment);
            }
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
