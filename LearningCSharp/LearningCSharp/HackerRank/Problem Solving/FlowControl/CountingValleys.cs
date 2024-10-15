namespace HackerRank.Flow;

public class CountingValleys
{
    public static readonly string Path = "UDDDUDUU";
    
    public static int countingValleys(int steps, string path)
    {
        var level = 0;
        var valleys = 0;
 
        for (int i = 0; i < steps; i++)
        {
            if (level.Equals(-1) && path[i] == 'U')
            {
                valleys++;
            }

            if (path[i].Equals('U'))
            {
                level++;
            }
            else if (path[i].Equals('D'))
            {
                level--;
            }
        }
        
        return valleys;
    }

}