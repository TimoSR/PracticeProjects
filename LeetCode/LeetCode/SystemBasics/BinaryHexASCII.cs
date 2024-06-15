namespace LeetCode.SystemBasics;

public class BinaryHexASCII
{
    public static void CharHexBinaryStuff()
    {
        const char originalChar = 'A'; // Example character

        //0x20 is hexadecimal = value 32
        const char flippedChar = (char)(originalChar ^ 0x20);

        Console.WriteLine($"Original character: {originalChar} ASCII: {(int) originalChar} Binary: {Convert.ToString(originalChar, toBase: 2)}");
        Console.WriteLine($"Character after flipping the sixth bit: {flippedChar} ASCII: {(int) flippedChar} Binary: {Convert.ToString(flippedChar, toBase: 2)}");

        const string hello = "A b B C Hello World!";

        foreach (var character in hello)
        {
            Console.WriteLine($"CHAR '{character}' ASCII Value {(int) character} Binary {Convert.ToString(character, toBase: 2)}");
        }
    }

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