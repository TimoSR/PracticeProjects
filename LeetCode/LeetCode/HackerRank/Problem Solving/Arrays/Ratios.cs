using System;
using System.Collections.Generic;

namespace LeetCode.HackerRank.Problem_Solving;

public class Ratios
{
    public static void plusMinus(List<int> arr)
    {
        var count = arr.Count;
        var positive = 0;
        var negative = 0;
        var zeros = 0;

        foreach (var number in arr)
        {
            if(number > 0) {
                positive++;
            }
            else if (number < 0) {
                negative++;
            }
            else {
                zeros++;
            }
        }
        
        var positiveRatio = Math.Round((decimal) positive / count, 6);
        var negativeRatio = Math.Round((decimal) negative / count, 6);
        var zeroRatio = Math.Round((decimal) zeros / count, 6); 
        
        Console.WriteLine($"{positiveRatio:F6}");
        Console.WriteLine($"{negativeRatio:F6}");
        Console.WriteLine($"{zeroRatio:F6}");
    }
}