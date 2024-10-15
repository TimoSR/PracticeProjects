namespace LeetCode.HackerRank.Problem_Solving;

public class BirthdayCakeCandles
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        var maxHeight = candles.Max();
        var amountOfMax = 0;

        foreach (var value in candles)
        {
            if (value == maxHeight)
            {
                amountOfMax++;
            }
        }

        return amountOfMax;
    }
}