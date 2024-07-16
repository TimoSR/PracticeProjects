namespace LeetCode.HackerRank.Problem_Solving.WorkingWithNumbers;

public class SamsHouse
{
    
    /// <summary>
    /// Counts the number of apples and oranges that fall within the house range.
    /// </summary>
    /// <param name="s">The start point of the house.</param>
    /// <param name="t">The end point of the house.</param>
    /// <param name="a">The location of the apple tree.</param>
    /// <param name="b">The location of the orange tree.</param>
    /// <param name="apples">The list of distances apples fall from the tree.</param>
    /// <param name="oranges">The list of distances oranges fall from the tree.</param>
    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var appleCount = 0;
        var orangeCount = 0;
        var houseRange = (s, t);
        var appleTreeLocation = a;
        var orangeTreeLocation = b;

        foreach (var unitsDistance in apples)
        {
            var fallpoint = FallPoint(appleTreeLocation, unitsDistance);

            if (WithinHouseRange(houseRange, fallpoint))
            {
                appleCount++;
            }
        }
        
        Console.WriteLine(appleCount);

        foreach (var unitsDistance in oranges)
        {
            var fallpoint = FallPoint(orangeTreeLocation, unitsDistance);

            if (WithinHouseRange(houseRange, fallpoint))
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

    private static bool WithinHouseRange(ValueTuple<int, int> houseRange, int fallPoint)
    {
        if (fallPoint >= houseRange.Item1 && fallPoint <= houseRange.Item2)
        {
            return true;
        }
        
        return false;
    }
}