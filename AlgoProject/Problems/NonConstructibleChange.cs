using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProject.Problems
{
    public static class NonConstructibleChange
    {
        public static int FindNonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);
            var change = 0;
            foreach (var coin in coins)
            {
                if (coin > change + 1)
                {
                    return change + 1;
                }
                else
                {
                    change += coin;
                }
            }
            return change + 1;
        }
    }
}
