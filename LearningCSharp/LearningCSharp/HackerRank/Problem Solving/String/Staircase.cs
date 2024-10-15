namespace DefaultNamespace;

public class Staircase
{
    
    //A goode exter demonstrating how to construct strings
    
    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            var spaces = new string(' ', n - i);
            var hashes = new string('#', i);
            Console.WriteLine(spaces + hashes);
        }
    }
    
    //My own not so optimal solution
    
    public static void staircaseOLD(int n)
    {
        var collection = new string[n];
        
        for (int i = 0; i < n; i++)
        {
            collection[i] = " ";
        }

        for (int i = n - 1; i >= 0; i--)
        {
            collection[i] = "#";

            var concatenatedString = string.Join("", collection);
            
            Console.WriteLine(concatenatedString);
        }
    }
}