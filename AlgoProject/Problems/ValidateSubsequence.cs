using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProject.Problems
{
    public static class ValidateSubsequence
    {
        public static bool IsValidSubsequence(List<int> list, List<int> sub)
        {
            foreach (int num in list)
            {
                if (num == sub[0])
                {
                    sub.Remove(sub[0]);
                }

                if (sub.Count == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
