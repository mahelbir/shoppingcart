
namespace ShoppingCart
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PageNumber { get; set; }
        public string ImageUrl { get; set; }

        public Book(int BookID, string Title, string Author, string Publisher, int PageNumber, string ImageUrl)
        {
            this.BookID = BookID;
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.PageNumber = PageNumber;
            this.ImageUrl = ImageUrl;
        }

    }
}