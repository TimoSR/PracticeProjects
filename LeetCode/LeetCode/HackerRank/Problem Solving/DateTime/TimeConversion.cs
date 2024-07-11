namespace LeetCode.HackerRank.Problem_Solving.DateTime;

public class TimeConversion
{
    public static string timeConversion(string s)
    {
        return TimeOnly.Parse(s).ToString("HH:mm:ss");
    }
}