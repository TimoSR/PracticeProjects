namespace LeetCode.SystemBasics;

public class LongRawStringLiterals
{
    public static void LongString()
    {
        var Longitude = 5;
        var Latitude = 4;
        
        string longMessage = """
             This is a long message.
             It has several lines.
                 Some are indented
                         more than others.
             Some should start at the first column.
             Some have "quoted text" in them.
             """;
        
        var location = $$"""
             You are at {{{Longitude}}, {{Latitude}}}
             """;
        
        Console.WriteLine();
        Console.WriteLine(longMessage);
        Console.WriteLine(location);
    }
}