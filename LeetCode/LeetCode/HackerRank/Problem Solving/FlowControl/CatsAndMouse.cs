namespace HackerRank.Flow;

public class CatsAndMouse
{
    static string catAndMouse(int x, int y, int z)
    {
        var catADistanceToMouse = Math.Abs(z - x);
        var catBDistanceToMouse = Math.Abs(z - y);

        if (catADistanceToMouse < catBDistanceToMouse)
        {
            return "Cat A";
        }

        if (catBDistanceToMouse < catADistanceToMouse)
        {
            return "Cat B";
        }
        
        return "Mouse C";
    }
}