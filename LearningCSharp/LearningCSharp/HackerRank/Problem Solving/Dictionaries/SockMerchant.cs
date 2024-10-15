public class SockMerchant {

    public static int sockMerchant(int n, List<int> ar) {


        int pairs = 0;
        var sockStats = new Dictionary<int, int>();

        foreach(var sock in ar) {

            if(sockStats.ContainsKey(sock)) {

                sockStats[sock]++;

            } else {

                sockStats[sock] = 1;

            }
        }

        foreach(var color in sockStats) {

            var amount = color.Value;

            if(amount >= 2) {

                pairs += amount / 2;

            }

        }

        return pairs;

    }

}