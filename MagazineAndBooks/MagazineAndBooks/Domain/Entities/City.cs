namespace MagazineAndBooks.Domain.Entities
{
    public class City
    {
        public required string CityName { get; set; }
        public required List<Human>  Peoples {  get; set; }
        
        public int CountOfPeoplesInCity() {  return Peoples.Count; }

        public override string ToString()
        {
            return $"City Name: {CityName}\nCount Of Peoples in City: {CountOfPeoplesInCity()}";
        }
        public void ShowPeoplesInfo()
        {
            foreach (var people in Peoples)
            {
                Console.WriteLine(people);
            }
        }
        public static City operator+(City c,Human h)
        {
            c.Peoples.Add(h);
            return c;
        }
        public static City operator -(City c, Human h)
        {
            c.Peoples.Remove(h);
            return c;
        }
        public static bool operator ==(City c, City b)
        {
            
            return c.Peoples.Count == b.Peoples.Count;
        }
        public static bool operator !=(City c, City b)
        {

            return c.Peoples.Count != b.Peoples.Count;
        }
        public static bool operator >(City c, City b)
        {

            return c.Peoples.Count > b.Peoples.Count;
        }
        public static bool operator <(City c, City b)
        {

            return c.Peoples.Count < b.Peoples.Count;
        }

    }
}
