public class DivisibleSumPairs
{
    public static int divisibleSumPairs(int n, int k, List<int> ar) {

        var pairs = new List<(int, int)> ();

        for(int i = 0; i < n; i++){

            var value1 = ar[i];

            for(int j = i + 1; j < n; j++) {

                var value2 = ar[j];

                var sum = value1 + value2;

                bool divisibleByK = sum % k == 0;

                if (divisibleByK){

                    pairs.Add((value1, value2));
                    
                }
            }
        }

        return pairs.Count;
    }
}

