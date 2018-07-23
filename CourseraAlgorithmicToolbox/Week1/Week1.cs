using Xunit;

namespace CourseraAlgorithmicToolbox.Week1
{
    [Trait("Category", "Week1")]
    public class Week1
    {
        [Theory]
        [InlineData(6, "3", "1 2 3")]
        [InlineData(9000000000, "2", "100000 90000")]
        public void MaxPairwiseProductFact(ulong expected, params string[] args)
        {
            using (ConsoleExaminator<ulong>.Exam(expected, args))
            {
                MaxPairwiseProduct.Main(args);
            }
        }
    }
}
