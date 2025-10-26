namespace MagazineAndBooks.Domain.Entities
{
    public class Worker:Human
    {
        public required decimal Salary  { get; set; }

        public required string JobTitle { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nJob title {JobTitle}\nSalary {Salary}\n";
        }
        public static Worker operator+(Worker w,decimal s)
        {
            w.Salary += s ;
            return w ;
        }
        public static Worker operator -(Worker w, decimal s)
        { 
            w.Salary -= s;
            return w;


        }
        public static bool operator ==(Worker w, Worker s)
        {
            if (ReferenceEquals(w, null) && ReferenceEquals(s, null)) return true;
            if (ReferenceEquals(w, null) || ReferenceEquals(s, null)) return false;
            return w.Salary == s.Salary;

        }
        public static bool operator !=(Worker w, Worker s)
        {
           return !(w.Salary == s.Salary);

        }
        public static bool operator >(Worker w, Worker s)
        {
            return w.Salary > s.Salary;

        }
        public static bool operator <(Worker w, Worker s)
        {
            return w.Salary < s.Salary;
        }
        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Worker other = (Worker)obj;
            return Salary == other.Salary;
        }

    }
}
