using System;
using System.Collections.Generic;

namespace LeetCode.HackerRank.Problem_Solving;

public class DiagonalDifference
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        var length = arr.Count;
        var diagonalSumRight = 0;
        var diagonalSumLeft = 0;

        for (var i = 0; i < length; i++)
        {
            var j = length - 1 - i;
            diagonalSumRight += arr[i][i];
            diagonalSumLeft += arr[i][j];
        }

        var difference = Math.Abs(diagonalSumRight - diagonalSumLeft);

        return difference;
    }
}