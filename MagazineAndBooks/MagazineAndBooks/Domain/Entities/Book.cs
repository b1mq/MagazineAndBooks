namespace MagazineAndBooks.Domain.Entities
{
    public class Book
    {
        public required string BookName {  get; set; }

        public required string Author {  get; set; }

        public required int CountOfPages { get; set; }
        public decimal Price { get; set; }

        public void ShowBookInfo()
        {
            Console.WriteLine($"Name of the book {BookName}\nAuthor {Author}\nCount of Pages {CountOfPages}");
        }
        public void BookPrice()
        {
            Console.WriteLine($"Price {Price}");
        }
    }
}
