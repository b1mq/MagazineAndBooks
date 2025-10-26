namespace MagazineAndBooks.Domain.Entities
{
    public class Human // небольшой класс для задачки с работником
    {
        public required string Name { get; set; }

        public  required string Surname { get; set; }

        public required int Age { get; set; }

        public override string ToString()
        {
            return $"Name {Name}\nSurname {Surname}\nAge {Age}";
        }

    }
}
