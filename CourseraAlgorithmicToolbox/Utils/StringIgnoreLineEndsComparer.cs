using System.Collections.Generic;

namespace CourseraAlgorithmicToolbox.Utils
{
    public class StringIgnoreLineEndsComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.TrimEnd('\r', '\n').Equals(y.TrimEnd('\r', '\n'));
        }

        public int GetHashCode(string obj)
        {
            return obj.TrimEnd('\r', '\n').GetHashCode();
        }
    }
}
