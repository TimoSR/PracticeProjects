namespace LeetCode.SystemBasics;

public class WorkingWithStrings
{
    public void SayHello(string @string)
    {
        if (String.IsNullOrEmpty(@string))
        {
            return;
        }
        
        Console.WriteLine($"{@string}");
    }
}