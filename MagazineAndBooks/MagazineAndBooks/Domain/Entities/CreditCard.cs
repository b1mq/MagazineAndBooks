namespace MagazineAndBooks.Domain.Entities
{
    public class CreditCard
    {
        public required int CardNumber { get; init; }
        public required int CVC { get; init; }
        public required Human CardOwner { get; init; }

        public required decimal CardAmount { get; set; }

        public void ShowCardInfo ()
        {
            Console.WriteLine($"Card Number: {CardNumber}\nCard owner: {CardOwner.ToString()}\nCard Amount: {CardAmount}\nCVC: {CVC}");
        }
        public static CreditCard operator +(CreditCard a, decimal amount)
        {
            a.CardAmount += amount;
            return a;
        }
        public static CreditCard operator -(CreditCard a, decimal amount)
        {
            try
            {
                a.CardAmount -= amount;
                return a;
            }
            catch 
            {
                Console.WriteLine("Error, try again please.");
            }
            return a;

        }
        public static bool operator ==(CreditCard a, CreditCard b)
        {
            return a.CVC == b.CVC;
        }
        public static bool operator ==(CreditCard a, int CVC)
        {
            return a.CVC == CVC;
        }
        public static bool operator !=(CreditCard a, int CVC)
        {
            return a.CVC != CVC;
        }
        public static bool operator !=(CreditCard a, CreditCard b)
        {
            return a.CardAmount != b.CardAmount;
        }
        public static bool operator >(CreditCard a, CreditCard b)
        {
            return a.CardAmount > b.CardAmount;
        }
        public static bool operator <(CreditCard a, CreditCard b)
        {
            return a.CardAmount < b.CardAmount;
        }
        public static bool operator >(CreditCard a, decimal amount)
        {
            return a.CardAmount > amount;
        }
        public static bool operator <(CreditCard a, decimal amount)
        {
            return a.CardAmount < amount;
        }
    }
}
