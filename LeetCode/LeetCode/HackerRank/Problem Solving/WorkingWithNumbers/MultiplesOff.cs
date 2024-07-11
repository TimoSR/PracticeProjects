namespace LeetCode.HackerRank.Problem_Solving.WorkingWithNumbers;

public class MultiplesOff
{
    public static void multiplesOf3And5(int value)
    {
        var sumOfMultiplesOf3And5 = 0;

        for (int i = 1; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sumOfMultiplesOf3And5 += i;
            }
        }

        Console.WriteLine(sumOfMultiplesOf3And5);
    }
}