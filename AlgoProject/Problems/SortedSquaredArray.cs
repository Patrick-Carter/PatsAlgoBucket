using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoProject.Problems
{
    public class SortedSquaredArray
    {
        public static int[] SquareArray(int[] arr)
        {
            int[] returnArr = new int[arr.Length];

            for (var i = 0; i < arr.Length; i++)
            {
                returnArr[i] = arr[i] * arr[i];
            }
            Array.Sort(returnArr);

            return returnArr;
        }

        public static int[] SquareArray2(int[] arr)
        {
            int[] returnArr = new int[arr.Length];
           
            int smallIdx = 0;
            int largeIdx = arr.Length - 1;

            for (var i = 0; i < arr.Length; i++)
            {
               if (Math.Abs(arr[smallIdx]) >= Math.Abs(arr[largeIdx]))
                {
                    returnArr[arr.Length - 1 - i] = arr[smallIdx] * arr[smallIdx];
                    smallIdx++;
                }
                else
                {
                    returnArr[arr.Length - 1 - i] = arr[largeIdx] * arr[largeIdx];
                    largeIdx--;
                }
            }
            return returnArr;
        }
    }
}
