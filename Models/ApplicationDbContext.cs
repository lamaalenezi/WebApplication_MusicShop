

using Microsoft.EntityFrameworkCore;
using WebApplication_MusicShop.Models;

namespace WebApplication_MusicShop.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        

        // Create DbSet 
        public DbSet<Song> Songs { get; set; }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // initial data
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Rock" },
                new Genre { GenreId = 2, Name = "Pop" },
                new Genre { GenreId = 3, Name = "Jazz" },
                new Genre { GenreId = 4, Name = "Metal" },
                new Genre { GenreId = 5, Name = "Rap" },
                new Genre { GenreId = 6, Name = "Country" },
                new Genre { GenreId = 7, Name = "Blues" },
                new Genre { GenreId = 8, Name = "Electronic" },
                new Genre { GenreId = 9, Name = "Folk" },
                new Genre { GenreId = 10, Name = "Classical" },
                new Genre { GenreId = 11, Name = "Reggae" },
                new Genre { GenreId = 12, Name = "Punk" },
                new Genre { GenreId = 13, Name = "Soul" },
                new Genre { GenreId = 14, Name = "Alternative" }
            );


            modelBuilder.Entity<Performer>().HasData(
                new Performer { PerformerId = 1, Name = "Adam Levine", GenreId = 1 },
                new Performer { PerformerId = 2, Name = "Taylor Swift", GenreId = 2 },
                new Performer { PerformerId = 3, Name = "Miles Davis", GenreId = 3 },
                new Performer { PerformerId = 4, Name = "James Hetfield", GenreId = 4 },
                new Performer { PerformerId = 5, Name = "Eminem", GenreId = 5 },
                new Performer { PerformerId = 6, Name = "Dolly Parton", GenreId = 6 },
                new Performer { PerformerId = 7, Name = "B.B. King", GenreId = 7 },
                new Performer { PerformerId = 8, Name = "Calvin Harris", GenreId = 8 },
                new Performer { PerformerId = 9, Name = "Bob Dylan", GenreId = 9 },
                new Performer { PerformerId = 10, Name = "Ludwig van Beethoven", GenreId = 10 },
                new Performer { PerformerId = 11, Name = "Bob Marley", GenreId = 11 },
                new Performer { PerformerId = 12, Name = "Joey Ramone", GenreId = 12 },
                new Performer { PerformerId = 13, Name = "Aretha Franklin", GenreId = 13 },
                new Performer { PerformerId = 14, Name = "Kurt Cobain", GenreId = 14 }
            );

            modelBuilder.Entity<Song>().HasData(
                 new Song { SongId = 1, Title = "Starlight", GenreId = 1, PerformerId = 1, Price = 1.99m },
                 new Song { SongId = 2, Title = "Shake It Off", GenreId = 2, PerformerId = 2, Price = 2.99m },
                 new Song { SongId = 3, Title = "Blue in Green", GenreId = 3, PerformerId = 3, Price = 1.49m },
                 new Song { SongId = 4, Title = "Enter Sandman", GenreId = 4, PerformerId = 4, Price = 2.49m },
                 new Song { SongId = 5, Title = "Lose Yourself", GenreId = 5, PerformerId = 5, Price = 3.99m },
                 new Song { SongId = 6, Title = "Jolene", GenreId = 6, PerformerId = 6, Price = 1.99m },
                 new Song { SongId = 7, Title = "The Thrill Is Gone", GenreId = 7, PerformerId = 7, Price = 2.99m },
                 new Song { SongId = 8, Title = "Summer", GenreId = 8, PerformerId = 8, Price = 3.49m },
                 new Song { SongId = 9, Title = "Blowin' in the Wind", GenreId = 9, PerformerId = 9, Price = 1.99m },
                 new Song { SongId = 10, Title = "Fifth Symphony", GenreId = 10, PerformerId = 10, Price = 4.99m },
                 new Song { SongId = 11, Title = "No Woman, No Cry", GenreId = 11, PerformerId = 11, Price = 3.49m },
                 new Song { SongId = 12, Title = "Blitzkrieg Bop", GenreId = 12, PerformerId = 12, Price = 2.49m },
                 new Song { SongId = 13, Title = "Respect", GenreId = 13, PerformerId = 13, Price = 2.99m },
                 new Song { SongId = 14, Title = "Smells Like Teen Spirit", GenreId = 14, PerformerId = 14, Price = 3.99m },

                 // Add more data
                 new Song { SongId = 15, Title = "Wonderwall", GenreId = 1, PerformerId = 2, Price = 2.50m },
                new Song { SongId = 16, Title = "Bohemian Rhapsody", GenreId = 2, PerformerId = 3, Price = 3.75m },
                new Song { SongId = 17, Title = "Fly Me to the Moon", GenreId = 3, PerformerId = 4, Price = 1.80m },
                new Song { SongId = 18, Title = "Back in Black", GenreId = 4, PerformerId = 5, Price = 2.25m },
                new Song { SongId = 19, Title = "California Love", GenreId = 5, PerformerId = 6, Price = 2.90m },
                new Song { SongId = 20, Title = "Take Me Home, Country Roads", GenreId = 6, PerformerId = 7, Price = 1.95m },
                new Song { SongId = 21, Title = "Sunshine of Your Love", GenreId = 7, PerformerId = 8, Price = 2.80m },
                new Song { SongId = 22, Title = "One More Time", GenreId = 8, PerformerId = 9, Price = 3.30m },
                new Song { SongId = 23, Title = "American Pie", GenreId = 9, PerformerId = 10, Price = 2.60m },
                new Song { SongId = 24, Title = "Moonlight Sonata", GenreId = 10, PerformerId = 11, Price = 4.50m },
                new Song { SongId = 25, Title = "Redemption Song", GenreId = 11, PerformerId = 12, Price = 2.70m },
                new Song { SongId = 26, Title = "Anarchy in the UK", GenreId = 12, PerformerId = 13, Price = 2.45m },
                new Song { SongId = 27, Title = "A Change Is Gonna Come", GenreId = 13, PerformerId = 14, Price = 3.20m },
                new Song { SongId = 28, Title = "Heart-Shaped Box", GenreId = 14, PerformerId = 1, Price = 3.00m },

                new Song { SongId = 29, Title = "Yellow Submarine", GenreId = 1, PerformerId = 3, Price = 2.20m },
                new Song { SongId = 30, Title = "Hello", GenreId = 2, PerformerId = 4, Price = 3.10m },
                new Song { SongId = 31, Title = "Autumn Leaves", GenreId = 3, PerformerId = 5, Price = 1.60m },
                new Song { SongId = 32, Title = "Master of Puppets", GenreId = 4, PerformerId = 6, Price = 2.70m },
                new Song { SongId = 33, Title = "Stan", GenreId = 5, PerformerId = 7, Price = 3.50m },
                new Song { SongId = 34, Title = "Ring of Fire", GenreId = 6, PerformerId = 8, Price = 1.80m },
                new Song { SongId = 35, Title = "Sweet Home Chicago", GenreId = 7, PerformerId = 9, Price = 2.30m },
                new Song { SongId = 36, Title = "Lean On", GenreId = 8, PerformerId = 10, Price = 2.99m },
                new Song { SongId = 37, Title = "Hotel California", GenreId = 9, PerformerId = 11, Price = 2.50m },
                new Song { SongId = 38, Title = "Four Seasons", GenreId = 10, PerformerId = 12, Price = 4.20m },
                new Song { SongId = 39, Title = "The Sound of Silence", GenreId = 11, PerformerId = 13, Price = 2.90m },
                new Song { SongId = 40, Title = "I Walk the Line", GenreId = 12, PerformerId = 14, Price = 2.10m },
                new Song { SongId = 41, Title = "Johnny B. Goode", GenreId = 13, PerformerId = 1, Price = 2.80m },
                new Song { SongId = 42, Title = "I Will Always Love You", GenreId = 14, PerformerId = 2, Price = 3.40m },
                new Song { SongId = 43, Title = "My Way", GenreId = 1, PerformerId = 3, Price = 2.60m },
                new Song { SongId = 44, Title = "What a Wonderful World", GenreId = 2, PerformerId = 4, Price = 3.10m },
                new Song { SongId = 45, Title = "I Will Survive", GenreId = 3, PerformerId = 5, Price = 2.40m },
                new Song { SongId = 46, Title = "Billie Jean", GenreId = 4, PerformerId = 6, Price = 3.20m },
                new Song { SongId = 47, Title = "Bohemian Rhapsody", GenreId = 5, PerformerId = 7, Price = 2.70m },
                new Song { SongId = 48, Title = "Like a Rolling Stone", GenreId = 6, PerformerId = 8, Price = 2.90m },
                new Song { SongId = 49, Title = "Hey Jude", GenreId = 7, PerformerId = 9, Price = 3.30m },
                new Song { SongId = 50, Title = "Smells Like Teen Spirit", GenreId = 8, PerformerId = 10, Price = 2.50m },
                new Song { SongId = 51, Title = "Imagine", GenreId = 9, PerformerId = 11, Price = 3.00m }




             );


        }
        public DbSet<WebApplication_MusicShop.Models.CartItem> CartItem { get; set; } = default!;
        public DbSet<WebApplication_MusicShop.Models.User> User { get; set; } = default!;



    }


}
