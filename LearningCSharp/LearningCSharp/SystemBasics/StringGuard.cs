using System;

namespace LeetCode.SystemBasics;

public class StringGuard
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