using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace CourseraAlgorithmicToolbox.Week1
{
    public class Week1
    {
        [Theory]
        [InlineData(6, "3", "1 2 3")]
        [InlineData(9000000000, "2", "100000 90000")]
        public void MaxPairwiseProductTest(ulong expected, params string[] args)
        {
            Utils.SetInput(args);
            var output = Utils.SetOutput();
            MaxPairwiseProduct.Main(args);
            var result = ulong.Parse(output.ToString());
            Assert.Equal(expected, result);
        }
    }
}
