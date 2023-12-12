namespace WebApplication_MusicShop.Models
{
    public class Song
    {
        // Create Entity Framework Core model class
        public int SongId { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public int ? GenreId { get; set; }
        public Genre? Genre { get; set; }
        public int? PerformerId { get; set; }
        public Performer? Performer { get; set; }
    }
}
