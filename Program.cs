namespace C_Basic03
{
    using System;

    class Program
    {
        static void Main()
        {
            #region 1 - Double to Int using Cast

            double price = 49.99;

            int priceInt = (int)price;

            Console.WriteLine(priceInt);

            #endregion

            #region 2 - String to Int using Convert

            string pagesText = "464";

            int pages = Convert.ToInt32(pagesText);

            Console.WriteLine(pages);

            #endregion



            #region 3 - Parse and TryParse

            string yearText = "2023";

            int year = int.Parse(yearText);

            Console.WriteLine(year);


            string badText = "abc";

            if (int.TryParse(badText, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            #endregion


            #region 4 - Int to String using ToString

            int pagesNumber = 464;

            string pagesString = pagesNumber.ToString();

            Console.WriteLine(pagesString);
            Console.WriteLine(pagesString.GetType());

            #endregion


            #region 5 - Boxing and Unboxing

            int copies = 100;

            object obj = copies;          // Boxing

            int newCopies = (int)obj;     // Unboxing

            Console.WriteLine(copies);
            Console.WriteLine(newCopies);

            #endregion


            #region 6 - If Else

            int bookPages = 464;

            if (bookPages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            #endregion



            #region 7 - If with && Operator

            int totalPages = 464;
            bool isAvailable = true;

            if (totalPages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }

            #endregion

        }
    }
}
