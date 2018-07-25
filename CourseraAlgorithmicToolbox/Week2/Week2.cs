using Xunit;

namespace CourseraAlgorithmicToolbox.Week2
{
    [Trait("Category", "Week2")]
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

        [Theory]
        [InlineData(2, "3")]
        [InlineData(9, "331")]
        public void FibonacciLastDigitFact(ulong expected, params string[] args)
        {
            using (ConsoleExaminator<ulong>.Exam(expected, args))
            {
                FibonacciLastDigit.Main(args);
            }
        }

        [Theory]
        [InlineData(1, "18 35")]
        [InlineData(17657, "28851538 1183019")]
        public void GCDFact(ulong expected, params string[] args)
        {
            using (ConsoleExaminator<ulong>.Exam(expected, args))
            {
                GCD.Main(args);
            }
        }

        [Theory]
        [InlineData(24, "6 8")]
        [InlineData(226436590403296, "14159572 63967072")]
        [InlineData(1933053046, "28851538 1183019")]
        public void LCMFact(ulong expected, params string[] args)
        {
            using (ConsoleExaminator<ulong>.Exam(expected, args))
            {
                LCM.Main(args);
            }
        }

        [Theory]
        [InlineData(1, "5 2")]
        [InlineData(1, "10 2")]
        [InlineData(161, "239 1000")]
        [InlineData(151, "2816213588 239")]
        [InlineData(0, "99999999999999999 2")]
        public void FibonacciHugeFact(ulong expected, params string[] args)
        {
            using (ConsoleExaminator<ulong>.Exam(expected, args))
            {
                FibonacciHuge.Main(args);
            }
        }

        [Theory]
        [InlineData(0, "6")]
        [InlineData(4, "3")]
        [InlineData(5, "100")]
        public void FibonacciSumLastDigitFact(ulong expected, params string[] args)
        {
            using (ConsoleExaminator<ulong>.Exam(expected, args))
            {
                FibonacciSumLastDigit.Main(args);
            }
        }
    }
}
