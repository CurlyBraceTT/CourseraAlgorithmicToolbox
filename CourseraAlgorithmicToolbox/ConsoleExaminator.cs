using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public virtual void Compare(TExpected expected, TExpected actual)
        {
            if (Comparer != null)
            {
                Assert.Equal(Expected, actual, Comparer);
            }
            else
            {
                Assert.Equal(Expected, actual);
            }
        }

        public virtual void Dispose()
        {
            var readerActual = new StringReader(Output.ToString());
            var actualStr = readerActual.ReadLine().Trim();

            var actual = (TExpected)Convert.ChangeType(actualStr, typeof(TExpected));
            Compare(Expected, actual);
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
