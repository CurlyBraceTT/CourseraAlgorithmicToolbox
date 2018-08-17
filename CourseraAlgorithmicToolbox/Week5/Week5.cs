using Xunit;

namespace CourseraAlgorithmicToolbox.Week5
{
    [Trait("Category", "Week5")]
    public class Week5
    {
        [Theory]
        [InlineData(2, "2")]
        [InlineData(9, "34")]
        public void ChangeDPTheory(int expected, params string[] args)
        {
            using (Examinator.Check(expected, args))
            {
                ChangeDP.Main(args);
            }
        }

        [Theory]
        [InlineData(0, "1")]
        [InlineData(3, "10")]
        [InlineData(14, "96234")]
        public void PrimitiveCalculatorTheory(int expected, params string[] args)
        {
            using (Examinator.Check(expected, args))
            {
                PrimitiveCalculator.Main(args);
            }
        }

        [Theory]
        [InlineData(0, "ab", "ab")]
        [InlineData(3, "short", "ports")]
        [InlineData(5, "editing", "distance")]
        public void EditDistanceTheory(int expected, params string[] args)
        {
            using (Examinator.Check(expected, args))
            {
                EditDistance.Main(args);
            }
        }

        [Theory]
        [InlineData(2, "3", "2 7 5", "2", "2 5")]
        [InlineData(0, "1", "7", "4", "1 2 3 4")]
        [InlineData(2, "4", "2 7 8 3", "4", "5 2 8 7")]
        public void LCS2Theory(int expected, params string[] args)
        {
            using (Examinator.Check(expected, args))
            {
                LCS2.Main(args);
            }
        }

        [Theory]
        [InlineData(2, "3", "1 2 3", "3", "2 1 3", "3", "1 3 5")]
        [InlineData(3, "5", "8 3 2 1 7", "7", "8 2 1 3 8 10 7", "6", "6 8 3 1 4 7")]
        public void LCS3Theory(int expected, params string[] args)
        {
            using (Examinator.Check(expected, args))
            {
                LCS3.Main(args);
            }
        }
    }
}
