using System;
using System.IO;
using System.Text;

namespace CourseraAlgorithmicToolbox
{
    public class Utils
    {
        public static void SetInput(string[] args)
        {
            var input = new StringBuilder();
            foreach (var a in args)
            {
                input.AppendLine(a);
            }
            var reader = new StringReader(input.ToString());
            Console.SetIn(reader);
        }

        public static StringBuilder SetOutput()
        {
            var output = new StringBuilder();
            var writer = new StringWriter(output);
            Console.SetOut(writer);
            return output;
        }
    }
}
