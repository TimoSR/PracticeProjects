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
        var houseRange = (start: s, end: t);
        var appleTreeLocation = a;
        var orangeTreeLocation = b;

        var appleCount = countFruitOnRoof(houseRange, appleTreeLocation, apples);
        
        Console.WriteLine(appleCount);
        
        var orangeCount = countFruitOnRoof(houseRange, orangeTreeLocation, oranges);
        
        Console.WriteLine(orangeCount);
    }

    /// <summary>
    /// Counts the number of fruits that fall within the house range.
    /// </summary>
    /// <param name="houseRange">The range of the house.</param>
    /// <param name="treeLocation">The location of the tree.</param>
    /// <param name="fruits">The list of distances fruits fall from the tree.</param>
    /// <returns>The count of fruits that fall within the house range.</returns>
    private static int countFruitOnRoof(ValueTuple<int, int> houseRange, int treeLocation, List<int> fruits)
    {
        var fruitCount = 0;
        
        foreach (var unitsDistance in fruits)
        {
            var fallpoint = FallPoint(treeLocation, unitsDistance);

            if (WithinHouseRange(houseRange, fallpoint))
            {
               fruitCount++;
            }
        }

        return fruitCount;
    }

    /// <summary>
    /// Calculates the fall point of a fruit given its tree location and distance.
    /// </summary>
    /// <param name="treeLocation">The location of the tree.</param>
    /// <param name="distance">The distance the fruit falls from the tree.</param>
    /// <returns>The fall point of the fruit.</returns>
    private static int FallPoint(int treeLocation, int distance)
    {
        return treeLocation + distance;
    }

    /// <summary>
    /// Checks if the fall point is within the house range.
    /// </summary>
    /// <param name="houseRange">The range of the house.</param>
    /// <param name="fallPoint">The fall point of the fruit.</param>
    /// <returns>True if the fall point is within the house range, otherwise false.</returns>
    private static bool WithinHouseRange((int start, int end) houseRange, int fallPoint)
    {
        if (fallPoint >= houseRange.start && fallPoint <= houseRange.end)
        {
            return true;
        }
        
        return false;
    }
}