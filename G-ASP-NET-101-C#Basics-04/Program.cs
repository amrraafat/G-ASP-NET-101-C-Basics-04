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

            #region Question 6

            // Method that receives an array and subtracts 5 from the first item
            static void ApplyDiscount(double[] Discountprices)
            {
                Discountprices[0] -= 5;
            }

            // Inside Main method:
            double[] Discountprices = { 25.5, 40.0 };

            // Call the method with the 'prices' array
            ApplyDiscount(Discountprices);

            // Print the first price afterward
            Console.WriteLine(Discountprices[0]);

            #endregion

            #region Question 7

            // Method that receives an integer by reference using 'ref' and adds 50
            static void AddBonusPagesByRef(ref int Bonuspages)
            {
                Bonuspages += 50;
            }

            // Inside Main method:
            int Bonuspages = 400;

            // Call the method using the 'ref' keyword
            AddBonusPagesByRef(ref Bonuspages);

            // Print pages afterward
            Console.WriteLine(Bonuspages);


            #endregion

            #region Question 8

            // Method that completely replaces an array using 'ref'
            static void ReplaceArray(ref double[] ReplaceArrayprices)
            {
                // Create a new array and assign it to the 'prices' reference
                ReplaceArrayprices = new double[] { 10.0, 12.5, 15.0 };
            }

            // Inside Main method:
            double[] ReplaceArrayprices = { 25.5, 40.0 };

            // Call the method using the 'ref' keyword
            ReplaceArray(ref ReplaceArrayprices);

            // Print the length of the new array
            Console.WriteLine(ReplaceArrayprices.Length);

            #endregion

            #region String Question 1

            string title = "clean code";

            // Convert to uppercase and store in a new variable
            string upperTitle = title.ToUpper();

            // Print both to show that original 'title' did not change (Strings are immutable)
            Console.WriteLine(title);      // Output: clean code
            Console.WriteLine(upperTitle); // Output: CLEAN CODE

            #endregion

            #region String Question 2

            string title1 = "Clean Code";
            string title2 = "Clean Code";

            // Check if both string variables point to the same object in memory
            bool isSameReference = object.ReferenceEquals(title1, title2);

            Console.WriteLine(isSameReference); // Output: True (Due to C# String Interning)

            #endregion

            #region String Question 3

            // Create a StringBuilder object
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            // Append text to the same object
            sb.Append("Book List");
            sb.Append(" - Updated");

            // Print the final result
            Console.WriteLine(sb.ToString()); // Output: Book List - Updated

            #endregion

            #region String Question 4

            // Using the same StringBuilder from Question 3
            // Replace "Book List" with "Library"
            sb.Replace("Book List", "Library");

            // Print the modified result
            Console.WriteLine(sb.ToString()); // Output: Library - Updated

            #endregion

            #region String Question 5

            string title5 = "Clean Code";
            int pages5 = 464;

            // Build the sentence using the + operator (Concatenation)
            string result5 = "Book: " + title5 + ", Pages: " + pages5;

            Console.WriteLine(result5); // Output: Book: Clean Code, Pages: 464

            #endregion

            #region String Question 6

            string title6 = "Clean Code";
            int pages6 = 464;

            // Build the sentence using String Interpolation ($)
            string result6 = $"Book: {title6}, Pages: {pages6}";

            Console.WriteLine(result6); // Output: Book: Clean Code, Pages: 464

            #endregion

            #region String Question 7

            string title7 = "Clean Code";
            int pages7 = 464;

            // Build the sentence using string.Format()
            string result7 = string.Format("Book: {0}, Pages: {1}", title7, pages7);

            Console.WriteLine(result7); // Output: Book: Clean Code, Pages: 464

            #endregion
        }
    }
}
