namespace LeetCode.HackerRank.Problem_Solving.WorkingWithNumbers;

public class FindingSharedFactors
{
    
    int[] array1 = [2, 4];
    int[] array2 = [16, 32, 96];
    
    public static int getTotalX(List<int> factors, List<int> multiples)
    {
        // Calculate the Least Common Multiple (LCM) of all elements in the factors list
        int lcmOfFactors = factors[0];
        
        foreach (var num in factors)
        {
            lcmOfFactors = CalculateLeastCommonMultiple(lcmOfFactors, num);
        }

        // Calculate the Greatest Common Divisor (GCD) of all elements in the multiples list
        int gcdOfMultiples = multiples[0];
        
        foreach (var num in multiples)
        {
            gcdOfMultiples = CalculateGreatestCommonDivisor(gcdOfMultiples, num);
        }

        int validCount = 0;

        // Check for each multiple of LCM up to GCD if it's a divisor of GCD
        for (int i = lcmOfFactors, j = 2; i <= gcdOfMultiples; i = lcmOfFactors * j, j++)
        {
            if (gcdOfMultiples % i == 0)
            {
                validCount++;
            }
        }

        return validCount;
    }

    // Function to calculate the Greatest Common Divisor (GCD) of two numbers
    private static int CalculateGreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Function to calculate the Least Common Multiple (LCM) of two numbers
    private static int CalculateLeastCommonMultiple(int a, int b)
    {
        return (a * b) / CalculateGreatestCommonDivisor(a, b);
    }
}