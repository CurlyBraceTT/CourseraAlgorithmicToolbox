using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace CourseraAlgorithmicToolbox
{
    public class ConsoleExaminator<TExpected> : IDisposable
    {
        public TExpected Expected { get; set; }
        public IEqualityComparer<TExpected> Comparer { get; set; }

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

            if(Comparer != null)
            {
                Assert.Equal(Expected, result, Comparer);
            }
            else
            {
                Assert.Equal(Expected, result);
            }
        }

        public static ConsoleExaminator<TExpected> Exam(TExpected expected,
            IEqualityComparer<TExpected> comparer, string[] args)
        {
            return new ConsoleExaminator<TExpected>(expected, args)
            {
                Comparer = comparer
            };
        }

        public static ConsoleExaminator<TExpected> Exam(TExpected expected, string[] args)
        {
            return new ConsoleExaminator<TExpected>(expected, args);
        }
    }
}
