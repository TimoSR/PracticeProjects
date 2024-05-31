using HelloWorld;

ILogger newLogger = new Logger();

PrintLib newPrintLib = new PrintLib(newLogger);

newPrintLib.HelloWorld();