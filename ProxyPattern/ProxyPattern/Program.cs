using MyGuess;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMyGuess();
            RunGuessBasedOnLecture();
            RunTheirSolution();
            RunExercise();

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        private static void RunGuessBasedOnLecture()
        {
            GuessBasedOnLecture.Libary library = new GuessBasedOnLecture.Libary();
            library.AddEbook(@"C:\temp\book1.book");
            library.AddEbook(@"C:\temp\book2.book");
            library.AddEbook(@"C:\temp\book3.book");
            library.AddEbook(@"C:\temp\book4.book");

            library[@"C:\temp\book3.book"].Show();
        }

        private static void RunTheirSolution()
        {
            TheirSolution.Libary library = new TheirSolution.Libary();
            library.AddEbook(@"C:\temp\book1.book");
            library.AddEbook(@"C:\temp\book2.book");
            library.AddEbook(@"C:\temp\book3.book");
            library.AddEbook(@"C:\temp\book4.book");

            library.OpenEbook(@"C:\temp\book3.book");
        }

        private static void RunMyGuess()
        {
            MyGuess.Library library = new MyGuess.Library();
            library.AddBook(@"C:\temp\book1.book", "Title 1", null);
            library.AddBook(@"C:\temp\book2.book", "Title 2", null);
            library.AddBook(@"C:\temp\book3.book", "Title 3", null);
            library.AddBook(@"C:\temp\book4.book", "Title 4", null);

            EbookProxy proxy = library[@"C:\temp\book3.book"];
            Console.WriteLine(proxy.Ebook);
            proxy.LoadContents();
            Console.WriteLine(proxy.Ebook);            
        }

        private static void RunExercise()
        {
            Exercise.DbContext dbContext = new Exercise.DbContext();

            // We read an object (eg a product) from a database.
            var product = dbContext.GetProduct(1);

            // We modify the properties of the object in memory.
            product.Name = "Updated Name";

            // DbContext should keep track of changed objects in memory.
            // When we call saveChanges(), it'll automatically generate
            // the right SQL statements to update our database.
            dbContext.SaveChanges();

            // After saving the changes to the database, we can
            // change our in-memory object again and save the changes.
            product.Name = "Another name";
            dbContext.SaveChanges();
        }
    }
}
