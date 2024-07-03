namespace LeetCode.Problem_Solving;

public class ArraySum
{
    public static int simpleArraySum(List<int> ar)
    {
        var sum = 0;
        
        foreach (var integer in ar)
        {
            sum += integer;
        }

        return sum;
    }
}