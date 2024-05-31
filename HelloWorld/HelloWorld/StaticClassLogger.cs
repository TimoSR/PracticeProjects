namespace HelloWorld;

public static class StaticClassLogger
{
    public static int AMOUNT_OF_LOGGERS;

    static StaticClassLogger()
    {
        AMOUNT_OF_LOGGERS++;
    }

    public static void Log(string @string)
    {
        Console.WriteLine(@string);   
    }
}