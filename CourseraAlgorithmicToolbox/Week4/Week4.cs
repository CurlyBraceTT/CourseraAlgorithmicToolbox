using System;
using System.Collections.Generic;
using CourseraAlgorithmicToolbox.Utils;
using Xunit;

namespace CourseraAlgorithmicToolbox.Week4
{
    [Trait("Category", "Week4")]
    public class Week4
    {
        [Theory]
        [InlineData("2 0 -1 0 -1", "5 1 5 8 12 13", "5 8 1 23 1 11")]
        [InlineData("0 1 2 3 4", "5 1 2 3 4 5", "5 1 2 3 4 5")]
        public void BinarySearchTheory(string expected, params string[] args)
        {
            using (ConsoleExaminator<string>.Exam(expected, new StringIgnoreLineEndsComparer(), args))
            {
                BinarySearch.Main(args);
            }
        }

        [Theory]
        [InlineData(1, "5", "2 3 9 2 2")]
        [InlineData(0, "4", "1 2 3 4")]
        [InlineData(0, "10", "512766168 717383758 5 126144732 5 573799007 5 5 5 405079772")]
        public void MajorityElementTheory(int expected, params string[] args)
        {
            using (ConsoleExaminator<int>.Exam(expected, args))
            {
                MajorityElement.Main(args);
            }
        }

        [Theory]
        [InlineData(2, "5", "2 3 9 2 9")]
        [InlineData(15, "6", "9 8 7 3 2 1")]
        public void InversionsTheory(int expected, params string[] args)
        {
            using (ConsoleExaminator<int>.Exam(expected, args))
            {
                Inversions.Main(args);
            }
        }

        [Fact]
        public void InversionsTimeoutFact()
        {
            var n = 40000;
            var numbers = new List<int>(n);

            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (var i = 0; i < n; i++)
            {
                numbers.Add(random.Next(1000));
            }

            var results = new List<int>();
            Inversions.InversionsRecursive(numbers, out results, 0, n - 1);
        }
    }
}
