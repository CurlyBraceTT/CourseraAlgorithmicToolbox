using System;
using System.Collections.Generic;

namespace CourseraAlgorithmicToolbox
{
    public class Examinator
    {
        public static IDisposable MultiLineCheck(string expected, string[] args)
        {
            return new MultiLineConsoleExaminator(expected, args);
        }

        public static IDisposable MultiLineCheck(string expected,
            IEqualityComparer<string> comparer, string[] args)
        {
            return new MultiLineConsoleExaminator(expected, args)
            {
                Comparer = comparer
            };
        }

        public static IDisposable Check<TExpected>(TExpected expected,
            IEqualityComparer<TExpected> comparer, string[] args)
        {
            return new ConsoleExaminator<TExpected>(expected, args)
            {
                Comparer = comparer
            };
        }

        public static IDisposable Check<TExpected>(TExpected expected, string[] args)
        {
            return new ConsoleExaminator<TExpected>(expected, args);
        }
    }
}
