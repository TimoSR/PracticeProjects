namespace LeetCode.Problem_Solving;

public class CompareTheTriplets
{
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var aPoints = 0;
        var bPoints = 0;
        
        for (var i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
            {
                aPoints++;
            }
            else if (b[i] > a[i])
            {
                bPoints++;
            }
        }
        
        var pointsEarned = new List<int> {aPoints, bPoints};

        return pointsEarned;
    }
}