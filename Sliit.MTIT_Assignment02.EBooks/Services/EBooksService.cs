using Sliit.MTIT_Assignment02.EBooks.Data;
using Sliit.MTIT_Assignment02.EBooks.Models;

namespace Sliit.MTIT_Assignment02.EBooks.Services
{
    public class EBooksService : IEBooksService
    {
        public List<Models.EBooks> GetEBooks()
        {
            return EBooksMockDataService.EBooks;
        }

        public Models.EBooks? GetEBook(int id)
        {
            return EBooksMockDataService.EBooks.FirstOrDefault(ebook => ebook.Id == id);
        }

        public Models.EBooks? AddEBook(Models.EBooks ebook)
        {
            var lastId = EBooksMockDataService.EBooks.LastOrDefault()?.Id ?? 0;
            ebook.Id = lastId + 1;
            EBooksMockDataService.EBooks.Add(ebook);
            return ebook;
        }

        public Models.EBooks? UpdateEBook(Models.EBooks ebook)
        {
            var index = EBooksMockDataService.EBooks.FindIndex(e => e.Id == ebook.Id);
            if (index >= 0)
            {
                EBooksMockDataService.EBooks[index] = ebook;
                return ebook;
            }
            return null;
        }

        public bool? DeleteEBook(int id)
        {
            var ebook = EBooksMockDataService.EBooks.FirstOrDefault(e => e.Id == id);
            if (ebook != null)
            {
                EBooksMockDataService.EBooks.Remove(ebook);
                return true;
            }
            return null;
        }

    }
}
