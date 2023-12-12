using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication_MusicShop.Migrations
{
    /// <inheritdoc />
    public partial class addMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "GenreId", "PerformerId", "Price", "Title" },
                values: new object[,]
                {
                    { 15, 1, 2, 2.50m, "Wonderwall" },
                    { 16, 2, 3, 3.75m, "Bohemian Rhapsody" },
                    { 17, 3, 4, 1.80m, "Fly Me to the Moon" },
                    { 18, 4, 5, 2.25m, "Back in Black" },
                    { 19, 5, 6, 2.90m, "California Love" },
                    { 20, 6, 7, 1.95m, "Take Me Home, Country Roads" },
                    { 21, 7, 8, 2.80m, "Sunshine of Your Love" },
                    { 22, 8, 9, 3.30m, "One More Time" },
                    { 23, 9, 10, 2.60m, "American Pie" },
                    { 24, 10, 11, 4.50m, "Moonlight Sonata" },
                    { 25, 11, 12, 2.70m, "Redemption Song" },
                    { 26, 12, 13, 2.45m, "Anarchy in the UK" },
                    { 27, 13, 14, 3.20m, "A Change Is Gonna Come" },
                    { 28, 14, 1, 3.00m, "Heart-Shaped Box" },
                    { 29, 1, 3, 2.20m, "Yellow Submarine" },
                    { 30, 2, 4, 3.10m, "Hello" },
                    { 31, 3, 5, 1.60m, "Autumn Leaves" },
                    { 32, 4, 6, 2.70m, "Master of Puppets" },
                    { 33, 5, 7, 3.50m, "Stan" },
                    { 34, 6, 8, 1.80m, "Ring of Fire" },
                    { 35, 7, 9, 2.30m, "Sweet Home Chicago" },
                    { 36, 8, 10, 2.99m, "Lean On" },
                    { 37, 9, 11, 2.50m, "Hotel California" },
                    { 38, 10, 12, 4.20m, "Four Seasons" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 38);
        }
    }
}
