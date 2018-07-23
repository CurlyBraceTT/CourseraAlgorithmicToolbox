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
    }
}
