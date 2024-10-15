namespace LeetCode.HackerRank.Problem_Solving.WorkingWithNumbers;

public class BreakingRecords
{
    public static List<int> breakingRecords(List<int> scores)
    {
        var breakingMinRecordCount = 0;
        var breakingMaxRecordCount = 0;
        var minRecord = 0;
        var maxRecord = 0;

        for (var i = 0; i < scores.Count; i++)
        {
            var score = scores[i];
            
            if (i > 0)
            {
                if (score > maxRecord)
                {
                    maxRecord = score;
                    breakingMaxRecordCount++;
                }
                else if (score < minRecord)
                {
                    minRecord = score;
                    breakingMinRecordCount++;
                }
            }
            else
            {
                minRecord = score;
                maxRecord = score;
            }
        }

        return [breakingMaxRecordCount, breakingMinRecordCount];
    }
}