namespace Sliit.MTIT_Assignment02.EBooks.Data
{
    public class EBooksMockDataService
    {
        public static List<Models.EBooks> EBooks = new List<Models.EBooks>()
    {
        new Models.EBooks { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Publisher = "Scribner", YearPublished = 1925, Price = 12.99m, Format = "EPUB" },
        new Models.EBooks { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Publisher = "J.B. Lippincott & Co.", YearPublished = 1960, Price = 9.99m, Format = "PDF" },
        new Models.EBooks { Id = 3, Title = "1984", Author = "George Orwell", Publisher = "Secker & Warburg", YearPublished = 1949, Price = 8.99m, Format = "Kindle" },
        new Models.EBooks { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Publisher = "T. Egerton, Whitehall", YearPublished = 1813, Price = 7.99m, Format = "EPUB" },
        new Models.EBooks { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Publisher = "Little, Brown and Company", YearPublished = 1951, Price = 10.99m, Format = "PDF" }
    };
    }
}
