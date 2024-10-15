namespace LeetCode.SystemBasics;

public class ExploringWritingEnums
{
    
    public static void WritingEnums()
    {
        var number = 1;
        var hello = "hello";
        var @decimal = 1.5f;
        var season = Seasons.Autumn;
        
        Console.WriteLine($"{number}, {hello}, {@decimal}, {(int) Seasons.Winter}");
        testMethod(season);
    }
    
    private static void testMethod(Seasons season)
    {
        switch (season)
        {
            case Seasons.Autumn:
                Console.WriteLine("It is Autumn!");
                break;
            default:
                Console.WriteLine("We got nothing");
                break;
        }
    }
    
    private enum Seasons
    {
        Spring,
        Summer,
        Autumn,
        Winter,
    };
}