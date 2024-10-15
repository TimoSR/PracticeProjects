namespace LearningCSharp.SystemBasics.UnderstandingStatic;

internal class ClassLogger : ILogger
{
    public static int AMOUNT_OF_LOGGERS;

    public ClassLogger()
    {
        AMOUNT_OF_LOGGERS++;
    }
    
    public void Log(string log)
    {
        if (string.IsNullOrEmpty(log) || string.IsNullOrWhiteSpace(log))
        {
            return;
        }
        
        Console.WriteLine(log);
    }
}

public interface ILogger
{
    public void Log(string log);
}