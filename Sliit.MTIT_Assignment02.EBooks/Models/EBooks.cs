namespace Sliit.MTIT_Assignment02.EBooks.Models
{
    public class EBooks
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public int YearPublished { get; set; }
        public decimal Price { get; set; }
        public string? Format { get; set; }
    }
}
