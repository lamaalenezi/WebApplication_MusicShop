namespace WebApplication_MusicShop.Models
{
    public class Performer
    {
        public int PerformerId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
