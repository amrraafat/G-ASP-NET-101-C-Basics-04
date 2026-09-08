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
        }
    }
}
