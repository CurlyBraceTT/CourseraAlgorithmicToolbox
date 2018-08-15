using System;

namespace CourseraAlgorithmicToolbox.Week5
{
    public class EditDistance
    {
        public static int Calculate(string word1, string word2)
        {
            var n = word1.Length + 1;
            var m = word2.Length + 1;
            var d = new int[n, m];

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

                    if(word1[i - 1] == word2[j - 1])
                    {
                        var match = d[i - 1, j - 1];
                        d[i, j] = Math.Min(insertion, Math.Min(deletion, match));
                    }
                    else
                    {
                        var mismatch = d[i - 1, j - 1] + 1;
                        d[i, j] = Math.Min(insertion, Math.Min(deletion, mismatch));
                    }
                }
            }

            return d[n - 1, m - 1];
        }

        public static void Main(string[] args)
        {
            var word1 = Console.ReadLine();
            var word2 = Console.ReadLine();
            var result = Calculate(word1, word2);
            Console.WriteLine(result);
        }
    }
}
