namespace MagazineAndBooks.Domain.Entities
{
    public class Magazine
    {
        public required string Name { get; set; }

        public required int YearOfFoundation { get; set; }

        public required  string Description { get; set; }

        public required string EMail { get; set; }

        public int CountOfWorkers { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name {Name}\nYearOfFoundation {YearOfFoundation}\nDescription {Description}\nEmail {EMail}");
        }

        public static Magazine operator+(Magazine a, int count)
        {
            a.CountOfWorkers += count;
            return a;
        }
        public static Magazine operator -(Magazine a, int count)
        {
            a.CountOfWorkers -= count;
            return a;
        }
        public static bool operator ==(Magazine a, Magazine b)
        {
            return a.CountOfWorkers == b.CountOfWorkers;
        }
        public static bool operator !=(Magazine a, Magazine b)
        {
            return a.CountOfWorkers != b.CountOfWorkers;
        }

        public static bool operator >(Magazine a, Magazine b)
        {
            return a.CountOfWorkers > b.CountOfWorkers;
        }

        public static bool operator <(Magazine a, Magazine b)
        {
            return a.CountOfWorkers < b.CountOfWorkers;
        }

    }
}
