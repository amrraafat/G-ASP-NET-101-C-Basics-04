namespace G_ASP_NET_101_C_Basics_04
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Question 1

            // Create a one-dimensional array of double values
            double[] prices = { 25.5, 40.0, 33.75 };

            // Print the second price (index 1)
            Console.WriteLine(prices[1]);

            #endregion

            #region Question 2

            // Create a 2x2 multidimensional array with rows for shelf 0 and shelf 1
            int[,] shelfCopies = {
              { 3, 5 }, // shelf 0
              { 1, 4 }  // shelf 1
               };

            // Print the number of copies on shelf 1, slot 0
            Console.WriteLine(shelfCopies[1, 0]);

            #endregion

            #region Question 3

            // Define a method that takes no parameters and prints a welcome message
            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }

            // Inside Main method:
            // Call the method
            PrintWelcomeMessage();

            #endregion

            #region Question 4

            // Define a method that takes a string parameter and prints it with a label
            static void PrintBookTitle(string title)
            {
                Console.WriteLine("Book title: " + title);
            }

            // Inside Main method:
            // Call the method with the text "Clean Code"
            PrintBookTitle("Clean Code");

            #endregion

            #region Question 5

            // Method that receives an integer by value and adds 50 to it
            static void AddBonusPages(int pages)
            {
                pages += 50;
            }

            // Inside Main method:
            int pages = 400;

            // Call the method with the 'pages' variable
            AddBonusPages(pages);

            // Print pages afterward
            Console.WriteLine(pages);
            /*
             * Expected Output: 400
             * Because 'int' is a Value Type. When passed to a method without 'ref', 
             */

            #endregion
        }
    }
}
