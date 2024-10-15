public class PageCount {

    public static int pageCount(int n, int p){

        var targetPage = p;
        var totalPages = n;

        // Calculate flips from the front of the book
        int flipsFromFront = targetPage / 2;

        // Calculate flips from the back of the book
        int flipsFromBack = (totalPages / 2) - (targetPage / 2);

        // The minimum number of flips required to reach the target page
        return Math.Min(flipsFromFront, flipsFromBack);
    }
}