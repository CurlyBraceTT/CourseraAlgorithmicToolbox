using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseraAlgorithmicToolbox.Week4
{
    public class BinarySearch
    {
        public static int BinarySearchRecursive(List<ulong> a, int low, int high, ulong key)
        {
            if(low > high)
            {
                return -1;
            }

            var mid = (int)Math.Floor(low + ((double)high - low) / 2);

            if(key == a[mid])
            {
                return mid;
            }
            else if(key < a[mid])
            {
                return BinarySearchRecursive(a, low, mid - 1, key);
            }
            else if (key > a[mid])
            {
                return BinarySearchRecursive(a, mid + 1, high, key);
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split(' ').Select(x => ulong.Parse(x)).ToList();
            var n = (int)inputList[0];
            var orderedSequence = inputList.GetRange(1, n);

            var searchList = Console.ReadLine().Split(' ').Select(x => ulong.Parse(x)).ToList();
            var k = (int)searchList[0];
            var searchKeys = searchList.GetRange(1, k);

            var results = new List<int>();
            foreach(var key in searchKeys)
            {
                results.Add(BinarySearchRecursive(orderedSequence, 0, n - 1, key));
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
