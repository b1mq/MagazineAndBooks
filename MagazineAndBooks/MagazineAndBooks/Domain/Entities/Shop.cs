namespace MagazineAndBooks.Domain.Entities
{
    public class Shop
    {
        public required string Name {  get; set; }
        public required double ShopArea {  get; set; }

        public static Shop operator +(Shop a, double count)
        {
            a.ShopArea += count;
            return a;
        }
        public static Shop operator -(Shop a, double count)
        {
            a.ShopArea -= count;
            return a;
        }

        public static bool operator ==(Shop a, Shop b)
        {
            return a.ShopArea == b.ShopArea;
        }
        public static bool operator !=(Shop a, Shop b)
        {
            return a.ShopArea != b.ShopArea;
        }
        public static bool operator >(Shop a, Shop b)
        {
            return a.ShopArea > b.ShopArea;
        }
        public static bool operator <(Shop a, Shop b)
        {
            return a.ShopArea < b.ShopArea;
        }

    }
}
