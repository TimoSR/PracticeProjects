using HelloWorld;

ILogger newLogger1 = new ClassLogger();

ILogger newLogger2 = new ClassLogger();

PrintLib newPrintLib = new PrintLib(newLogger1);

newPrintLib.HelloWorld();

Console.WriteLine(ClassLogger.AMOUNT_OF_LOGGERS);

string @string1 = "Awesome World!";

StaticClassLogger.Log(@string1);

Console.WriteLine(StaticClassLogger.AMOUNT_OF_LOGGERS);

string @string2 = "Static World 1!";  

StaticMethods.StaticLog(@string2);

string @string3 = "Static World 2!";

StaticMethods.StaticLog(@string3);

Console.WriteLine(StaticMethods.AMOUNT_OF_LOGGERS);