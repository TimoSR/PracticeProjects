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
}