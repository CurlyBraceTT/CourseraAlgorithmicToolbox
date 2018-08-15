using System;
using System.Collections.Generic;

namespace CourseraAlgorithmicToolbox.Week5
{
    public class ChangeDP
    {
        public static int CalculateChange(int money, List<int> coins)
        {
            var minNumCoins = new Dictionary<int, int>();
            minNumCoins.Add(0, 0);

            var numCoins = 0;
            for(var i = 0; i <= money; i++)
            {
                for (var j = 0; j < coins.Count; j++)
                {
                    if (i >= coins[j])
                    {
                        numCoins = minNumCoins[i - coins[j]] + 1;

                        int min = 0;
                        var exists = minNumCoins.TryGetValue(i, out min);
                        if(!exists || numCoins < min)
                        {
                            minNumCoins[i] = numCoins;
                        }
                    }
                }
            }

            return minNumCoins[money];
        }

        public static void Main(string[] args)
        {
            var money = int.Parse(Console.ReadLine());
            var result = CalculateChange(money, new List<int> { 1, 3, 4 });
            Console.WriteLine(result);
        }
    }
}
