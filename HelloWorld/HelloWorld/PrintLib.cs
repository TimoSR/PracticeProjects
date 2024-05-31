namespace HelloWorld;

public class PrintLib
{
    private ILogger _log;

    public PrintLib(ILogger log)
    {
        _log = log;
    }
    
    public void HelloWorld()
    {
        if (_log is Logger)
        {
            _log.Log("Hello World!");
        }
    }
}