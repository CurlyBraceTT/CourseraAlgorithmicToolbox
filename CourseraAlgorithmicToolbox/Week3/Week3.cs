using CourseraAlgorithmicToolbox.Utils;
using Xunit;

namespace CourseraAlgorithmicToolbox.Week3
{
    [Trait("Category", "Week3")]
    public class Week3
    {
        [Theory]
        [InlineData(2, "2")]
        [InlineData(6, "28")]
        public void ChangeTheory(uint expected, params string[] args)
        {
            using (ConsoleExaminator<uint>.Exam(expected, args))
            {
                Change.Main(args);
            }
        }

        [Theory]
        [InlineData("180,0000", "3 50", "60 20", "100 50", "120 30")]
        [InlineData("166,6667", "1 10", "500 30")]
        public void FractionalKnapsackTheory(string expected, params string[] args)
        {
            using (ConsoleExaminator<string>.Exam(expected, new StringIgnoreLineEndsComparer(), args))
            {
                FractionalKnapsack.Main(args);
            }
        }

        [Theory]
        [InlineData(897, "1", "23", "39")]
        [InlineData(23, "3", "1 3 -5", "-2 4 1")]
        public void DotProductTheory(long expected, params string[] args)
        {
            using (ConsoleExaminator<long>.Exam(expected, args))
            {
                DotProduct.Main(args);
            }
        }
    }
}
