using MagazineAndBooks.Domain.Entities;
using static System.Reflection.Metadata.BlobBuilder;

var a = new Human() { Age = 32, Name = "Aleks", Surname = "Sora" };
var b = new Human() { Age = 15, Name = "Valera", Surname = "Pivo" };

var c = new City() { CityName = "New York", Peoples = new List<Human> { a, b } };
var s = new City() { CityName = "Hawai", Peoples = new List<Human> { a, b } };

Console.WriteLine(c);
c.ShowPeoplesInfo();


