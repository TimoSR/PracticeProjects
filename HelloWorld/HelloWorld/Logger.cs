namespace HelloWorld;

public class Logger : ILogger
{
    public void Log(string log)
    {
        Console.WriteLine(log);
    }
}

public interface ILogger
{
    public void Log(string log);
}