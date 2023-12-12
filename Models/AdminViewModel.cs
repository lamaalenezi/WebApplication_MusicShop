namespace WebApplication_MusicShop.Models
{
    public class AdminViewModel
    {
        public IEnumerable<Song> Songs { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Performer> Performers { get; set; }
    }
}
