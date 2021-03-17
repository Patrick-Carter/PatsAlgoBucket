using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProject.Problems
{
    public static class TwoNumberSum
    {

        public static int[] TwoNumberSumWorker(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] + array[i] == targetSum)
                    {
                        return new int[] { array[i], array[j] };
                    }
                }
            }
            return new int[0];
        }

        public static int[] TwoNumberSumWorker2(int[] array, int targetSum)
        {
            HashSet<int> nums = new HashSet<int>();

            foreach(int num in array)
            {
                int potintialMatch = targetSum - num;
                if (nums.Contains(potintialMatch))
                {
                    return new int[] { potintialMatch, num };
                } 
                else
                {
                    nums.Add(num);
                }
            }

            return new int[0];
        }
    }
}
