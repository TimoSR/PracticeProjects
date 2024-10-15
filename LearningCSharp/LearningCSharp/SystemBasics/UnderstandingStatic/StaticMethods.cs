namespace LearningCSharp.SystemBasics.UnderstandingStatic;

internal class StaticMethods
{

    public static int AMOUNT_OF_LOGGERS;

    public StaticMethods()
    {
        AMOUNT_OF_LOGGERS++;
    }
    
    public static void StaticLog(string @string)
    {
        Console.WriteLine(@string);
    }
}