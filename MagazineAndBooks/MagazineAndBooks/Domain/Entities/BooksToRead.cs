namespace MagazineAndBooks.Domain.Entities
{
    public class Library
    {
        public required string Name {  get; set; }
        public required List<Book> Books { get; set; }

        public int CountOfBooks()
        {
            return Books.Count;
        }

        public bool IsBookInLibrary(Book book)
        {

            foreach (var item in Books)
            {
                if (item == book)
                {
                    return true;
                }

            }
            return false;
        }

        public static Library operator +(Book book,Library a)
        {
            a.Books.Add(book);
            return a;
        }
        public static Library operator -(Book book, Library a)
        {
            
            a.Books.Remove(book);
            return a;
        }
    }
}
