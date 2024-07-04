using System;

namespace LeetCode.SystemBasics;

public class SpreadElement
{
    private static readonly int[] row0 = [1, 2, 3];
    private static readonly int[] row1 = [4, 5, 6];
    private static readonly int[] row2 = [7, 8, 9];

    // spread element .. in C# and ... in JS
    public static void CombineArrays()
    {
        int[] single = [.. row0,.. row1,.. row2];

        foreach (var element in single)
        {
            Console.Write($"{element}, ");
        }
    }
}