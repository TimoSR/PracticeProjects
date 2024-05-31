namespace HelloWorld;

public class Logger : ILogger
{
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