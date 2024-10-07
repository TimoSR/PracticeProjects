namespace HackerRank.Flow;

public class ElectronicsShop
{
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        var closestToBudget = 0;

        foreach (var keyboard in keyboards)
        {
            foreach (var drive in drives)
            {
                var cost = keyboard + drive;

                if (cost > closestToBudget && cost <= b)
                {
                    closestToBudget = cost;
                }
            }
        }

        return closestToBudget > 0 ? closestToBudget : -1;
    }
}