using MagazineAndBooks.Domain.Entities;

var a = new Magazine() { Description = "",Name = "A",EMail = "gmail",YearOfFoundation = 0,CountOfWorkers = 1}; 
var b = new Magazine() { Description = "",Name = "A",EMail = "gmail",YearOfFoundation = 0,CountOfWorkers = 2};

Console.WriteLine(a != b);



