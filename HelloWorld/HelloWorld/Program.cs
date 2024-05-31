using HelloWorld;

ILogger newLogger1 = new Logger();

ILogger newLogger2 = new Logger();

PrintLib newPrintLib = new PrintLib(newLogger1);

newPrintLib.HelloWorld();

newLogger1.GetActiveLoggers();