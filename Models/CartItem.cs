namespace WebApplication_MusicShop.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public void AddItem(CartItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(int songId)
        {
            Items.RemoveAll(i => i.SongId == songId);
        }

        public decimal ComputeTotalValue() =>
            Items.Sum(e => e.Price * e.Quantity);

        public void Clear() => Items.Clear();


    }
}
