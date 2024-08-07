namespace LeetCode.HackerRank.Problem_Solving.WorkingWithNumbers;

public class Palindrome
{
    
    // We should think of all numbers a set max or min range of values we can iterate over
    // So we can think 3 as a list of natural value 1, 2, 3.
    
    public static void LargestPalindrome3Digit()
    {
        var largestPalindrome = 0;

        // A good examples of comparing all possibilities of multiplying two 3-digit numbers
        for (var i = 999; i >= 100; i--)
        {
            for (var j = i; j >= 100; j--)
            {
                var value = i * j;

                if (IsAPalindrome(value) && value > largestPalindrome)
                {
                    largestPalindrome = value;
                }
            }
        }
        
        Console.WriteLine($"{largestPalindrome}");
        
    }

    private static bool IsAPalindrome(int value)
    {
        var numberString = value.ToString();
        
        // I only need to consider each half part of the string

        var numberLength = numberString.Length;
        var halfNumberLength = numberString.Length / 2;

        for (var i = 0; i < halfNumberLength; i++)
        {
            
            // I look from opposite directions of the string, to measure each
            if (numberString[i] != numberString[numberLength - 1 - i])
            {
                return false;
            }
        }
        
        return true;
    }
}