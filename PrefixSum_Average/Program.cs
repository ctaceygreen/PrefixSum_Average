using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        if (A.Length == 2) return 0;

        int minSliceTwo = A[0] + A[1];
        int minTwoIndex = 0;

        int minSliceThree = int.MaxValue;
        int minThreeIndex = 0;

        for (int i = 2; i < A.Length; i++)
        {
            int sliceTwo = A[i - 1] + A[i];
            if (sliceTwo < minSliceTwo)
            {
                minSliceTwo = sliceTwo;
                minTwoIndex = i - 1;
            }

            int sliceThree = sliceTwo + A[i - 2];
            if (sliceThree < minSliceThree)
            {
                minSliceThree = sliceThree;
                minThreeIndex = i - 2;
            }
        }
        int averageMinTwo = minSliceTwo * 3;
        int averageMinThree = minSliceThree * 2;

        if (averageMinTwo == averageMinThree) return Math.Min(minTwoIndex, minThreeIndex);
        else return averageMinTwo < averageMinThree ? minTwoIndex : minThreeIndex;
    }
}