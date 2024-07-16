namespace LeetCode.HackerRank.Problem_Solving.WorkingWithNumbers;

public class SamsHouse
{
    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var appleCount = 0;
        var orangeCount = 0;

        foreach (var unitsDistance in apples)
        {
            var fallpoint = FallPoint(a, unitsDistance);

            if (WithinHouseRange(s, t, fallpoint))
            {
                appleCount++;
            }
        }
        
        Console.WriteLine(appleCount);

        foreach (var unitsDistance in oranges)
        {
            var fallpoint = FallPoint(b, unitsDistance);

            if (WithinHouseRange(s, t, fallpoint))
            {
                orangeCount++;
            }
        }
        
        Console.WriteLine(orangeCount);
    }

    private static int FallPoint(int treeLocation, int unitsDistance)
    {
        return treeLocation + unitsDistance;
    }

    private static bool WithinHouseRange(int s, int t, int fallPoint)
    {
        if (fallPoint >= s && fallPoint <= t)
        {
            return true;
        }
        
        return false;
    }
}