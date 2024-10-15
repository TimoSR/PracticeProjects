namespace HelloWorld;

internal class PrintLib
{
    private ILogger _log;

    public PrintLib(ILogger log)
    {
        _log = log;
    }
    
    public void HelloWorld()
    {
        if (_log is ClassLogger)
        {
            _log.Log("Class World!");
        }
    }
}