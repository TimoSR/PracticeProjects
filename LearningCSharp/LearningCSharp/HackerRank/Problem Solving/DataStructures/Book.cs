public class Book
    {
        public List<(int, int)> PagePairs { get; }

        public Book(int totalPages)
        {
            PagePairs = new List<(int, int)>();

            int PairCount = totalPages / 2 + 1;

            // Generate page pairs
            for (int i = 0; i < PairCount; i++)
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
    