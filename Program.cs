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






        }
    }
}
