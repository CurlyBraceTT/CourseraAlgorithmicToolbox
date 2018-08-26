using Xunit;

namespace CourseraAlgorithmicToolbox.Week6
{
    [Trait("Category", "Week6")]
    public class Week6
    {
        [Theory]
        [InlineData(9, "10 3", "1 4 8")]
        [InlineData(10, "10 5", "3 5 3 3 5")]
        public void KnapsackTheory(int expected, params string[] args)
        {
            using (Examinator.Check(expected, args))
            {
                Knapsack.Main(args);
            }
        }

        [Theory]
        [InlineData(6, "1+5")]
        [InlineData(200, "5-8+7*4-8+9")]
        public void PlacingParenthesesTheory(int expected, params string[] args)
        {
            using (Examinator.Check(expected, args))
            {
                PlacingParentheses.Main(args);
            }
        }
    }
}
