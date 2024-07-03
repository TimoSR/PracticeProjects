namespace LeetCode.SystemBasics;

public class WorkingWithStringTemplates
{
    public static void StringStuffReplace()
    {
        var template = "[A], [B]";

        Console.WriteLine($"Original String: {template}");
        
        var replace = template
            .Replace("[A]", "Hello")
            .Replace("[B]", "World!");
        
        Console.WriteLine($"Replace String: {replace}");
    }

    public static void StringStuffFormat()
    {
        var template = "{0}, {1}";
        
        Console.WriteLine($"Original String: {template}");

        var formatted = string.Format(template, "Hello", "World!");
        
        Console.WriteLine($"Formatted String: {formatted}");
    }

    public static void StringStuffInterpolation()
    {
        var hello = "Hello";
        var world = "World!";
        var interpolatedString = $"{hello}, {world}";
        Console.WriteLine($"Interpolated String: {interpolatedString}");
    }
}