using HelloWorld;

ILogger newLogger1 = new Logger();

ILogger newLogger2 = new Logger();

PrintLib newPrintLib = new PrintLib(newLogger1);

newPrintLib.HelloWorld();

newLogger1.GetActiveLoggers();

string @string1 = "Awesome World!";

AwesomeLogger.Log(@string1);

Console.WriteLine(AwesomeLogger.AMOUNT_OF_LOGGERS);

string @string2 = "Static World 1!";  

StaticMethods.StaticLog(@string2);

string @string3 = "Static World 2!";

StaticMethods.StaticLog(@string3);

Console.WriteLine(StaticMethods.AMOUNT_OF_LOGGERS);