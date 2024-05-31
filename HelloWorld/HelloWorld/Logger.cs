namespace HelloWorld;

public class Logger : ILogger
{
    private static int _activeLoggers;

    public Logger()
    {
        _activeLoggers++;
    }

    public void GetActiveLoggers()
    {
        Console.WriteLine(_activeLoggers);
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
    public void GetActiveLoggers();
    public void Log(string log);
}