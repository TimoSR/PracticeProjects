using System.Data.Common;
using System.Numerics;

namespace LeetCode.HackerRank.Problem_Solving.WorkingWithNumbers;

public class KangarooBase
{
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        // Check if kangaroos start at the same position
        if (x1 == x2)
        {
            return "YES";
        }

        // Check if kangaroos have the same jump distance but different start points
        if (v1 == v2)
        {
            return "NO";
        }

        // Calculate n such that (x2 - x1) / (v1 - v2) is a non-negative integer
        int distanceDiff = x2 - x1;
        int velocityDiff = v1 - v2;

        // Check if they can meet at the same point
        if (distanceDiff % velocityDiff == 0 && distanceDiff / velocityDiff >= 0)
        {
            return "YES";
        }

        return "NO";
    }
}