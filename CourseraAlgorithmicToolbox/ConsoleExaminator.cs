using System;
using System.IO;
using System.Text;
using Xunit;

namespace CourseraAlgorithmicToolbox
{
    public class ConsoleExaminator<TExpected> : IDisposable
    {
        public TExpected Expected { get; set; }
        protected StringBuilder Output { get; set; }

        public ConsoleExaminator(TExpected expected, string[] args)
        {
            Expected = expected;

            var input = new StringBuilder();
            foreach (var a in args)
            {
                input.AppendLine(a);
            }
            var reader = new StringReader(input.ToString());
            Console.SetIn(reader);

            Output = new StringBuilder();
            var writer = new StringWriter(Output);
            Console.SetOut(writer);
        }

        public void Dispose()
        {
            var result = (TExpected)Convert.ChangeType(Output.ToString(), typeof(TExpected));
            Assert.Equal(Expected, result);
        }

        public static ConsoleExaminator<T> Exam<T>(T expected, string[] args)
        {
            return new ConsoleExaminator<T>(expected, args);
        }
    }
}
