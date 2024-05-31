namespace HelloWorld;

public static class AwesomeLogger
{
    public static int AMOUNT_OF_LOGGERS;

    static AwesomeLogger()
    {
        AMOUNT_OF_LOGGERS++;
    }

    public static void Log(string @string)
    {
        Console.WriteLine(@string);   
    }
}