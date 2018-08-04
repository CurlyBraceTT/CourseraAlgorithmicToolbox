using System;

namespace CourseraAlgorithmicToolbox.Week3
{
    public class Change
    {
        public static void Main(string[] args)
        {
            uint m = uint.Parse(Console.ReadLine());

            var coins = new int[3] { 10, 5, 1 };
            Array.Sort(coins, (a, b) => b.CompareTo(a));

            var count = 0;
            var sum = 0;

            while(sum < m)
            {
                foreach(var coin in coins)
                {
                    if(sum + coin <= m)
                    {
                        count++;
                        sum += coin;
                        break;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
