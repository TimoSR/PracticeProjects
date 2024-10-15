using HelloWorld;

public class TestingStatic
{
    public static void testingStatic()
    {
        ILogger newLogger1 = new ClassLogger();

        ILogger newLogger2 = new ClassLogger();

        PrintLib newPrintLib = new PrintLib(newLogger1);

        newPrintLib.HelloWorld();

        Console.WriteLine($"Created Amount {ClassLogger.AMOUNT_OF_LOGGERS} \n");

        string @string1 = "StaticClass World!";

        StaticClassLogger.Log(@string1);

        Console.WriteLine($"Created Amount {StaticClassLogger.AMOUNT_OF_LOGGERS}\n");

        string @string2 = "StaticMethod World 1!";  

        StaticMethods.StaticLog(@string2);

        string @string3 = "StaticMethod World 2!";

        StaticMethods.StaticLog(@string3);

        Console.WriteLine($"Created Amount {StaticMethods.AMOUNT_OF_LOGGERS}\n");

        Console.WriteLine("Static variables and methods belong to the class itself instead of the object, therefore can be called on the type.\n");
        
        Console.WriteLine("This is something we see a lot with the types implemented in .NET \n");
    }
}