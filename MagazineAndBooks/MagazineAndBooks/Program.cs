using MagazineAndBooks.Domain.Entities;
using static System.Reflection.Metadata.BlobBuilder;


var b = new Book() { BookName = "Transerfing", Author = "S", CountOfPages = 250 };

var l = new Library()
{
    Name = "MyLibrary",
    Books = new List<Book> { b }  
};

