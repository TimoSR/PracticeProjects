using System.Globalization;

namespace LeetCode.HackerRank.Problem_Solving.WorkingWithNumbers;

public class Birthday
{
    public static int birthday(List<int> s, int d, int m)
    {
        var count = 0;
        var sumGoal = d;
        var pieces = m;

        // This assignment is about knowing how to use multiple pointers to walk through an array
        // To convert the values to work on the array and respect the boundaries of the array length
        
        for (var i = 0; i < s.Count; i++)
        {
            var lastPiecePosition = i + pieces - 1;

            var sum = s[i];
            
            for (var j = i + 1; j <= lastPiecePosition && j < s.Count; j++)
            {
                sum += s[j];   
            }
            
            if (sum == sumGoal)
            {
                count++;
            }
        }

        return count;
    }
}