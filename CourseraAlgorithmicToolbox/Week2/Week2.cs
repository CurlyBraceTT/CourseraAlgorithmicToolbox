using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CourseraAlgorithmicToolbox.Week2
{
    public class Week2
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(55, "10")]
        public void FibonacciFact(ulong expected, params string[] args)
        {
            using (ConsoleExaminator<ulong>.Exam(expected, args))
            {
                Fibonacci.Main(args);
            }
        }
    }
}
