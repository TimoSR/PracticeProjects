public class PageCount {




    // The coverpage is at index 0
    // Page 1 is at index 1; = 1 page a flip
    // The end page is at n;





    public static int pageCount(int n, int p){

        var bookPages = n;
        var targetPage = p;
        var flips = 0;

        var book = new Book(bookPages);
        
        foreach(var page in book.PagePairs) {

            Console.WriteLine(page);

        }

        return flips;

    }


    // Private class representing the book
    private class Book
    {
        public List<(int, int)> PagePairs { get; }

        public Book(int totalPages)
        {
            PagePairs = new List<(int, int)>();

            // Generate page pairs
            for (int i = 0; i <= totalPages / 2; i++)
            {
                int leftPage = 2 * i;
                int rightPage = 0; 

                // -1 for the last single page
                if(leftPage + 1 <= totalPages) {

                    rightPage = leftPage + 1;

                } else{

                    rightPage = -1;
                }

                PagePairs.Add((leftPage, rightPage));
            }
        }

        // Method to print page pairs (for debugging purposes)
        public void PrintPagePairs()
        {
            foreach (var pair in PagePairs)
            {
                Console.WriteLine($"({pair.Item1}, {pair.Item2})");
            }
        }
    }
    
}