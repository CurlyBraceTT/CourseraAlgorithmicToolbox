using System.IO;
using Xunit;

namespace CourseraAlgorithmicToolbox
{
    public class MultiLineConsoleExaminator : ConsoleExaminator<string>
    {
        public MultiLineConsoleExaminator(string expected, string[] args) : base(expected, args)
        {
        }

        public override void Dispose()
        {
            var reader = new StringReader(Output.ToString());
            var readerExpected = new StringReader(Expected);

            string expectedLine = string.Empty;
            while ((expectedLine = readerExpected.ReadLine()) != null)
            {
                var actualLine = reader.ReadLine();

                Assert.NotNull(actualLine);
                actualLine = actualLine.Trim();
                expectedLine = expectedLine.Trim();

                Compare(expectedLine, actualLine);
            }
        }
    }
}
