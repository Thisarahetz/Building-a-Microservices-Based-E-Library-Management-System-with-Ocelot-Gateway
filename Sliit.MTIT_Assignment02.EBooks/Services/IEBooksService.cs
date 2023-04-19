namespace Sliit.MTIT_Assignment02.EBooks.Services
{
    public interface IEBooksService
    {
        List<Models.EBooks> GetEBooks();
        Models.EBooks? GetEBook(int id);
        Models.EBooks? AddEBook(Models.EBooks ebook);
        Models.EBooks? UpdateEBook(Models.EBooks ebook);
        bool? DeleteEBook(int id);
    }
}
