using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication_MusicShop.Migrations
{
    /// <inheritdoc />
    public partial class addMoreData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "GenreId", "PerformerId", "Price", "Title" },
                values: new object[,]
                {
                    { 39, 11, 13, 2.90m, "The Sound of Silence" },
                    { 40, 12, 14, 2.10m, "I Walk the Line" },
                    { 41, 13, 1, 2.80m, "Johnny B. Goode" },
                    { 42, 14, 2, 3.40m, "I Will Always Love You" },
                    { 43, 1, 3, 2.60m, "My Way" },
                    { 44, 2, 4, 3.10m, "What a Wonderful World" },
                    { 45, 3, 5, 2.40m, "I Will Survive" },
                    { 46, 4, 6, 3.20m, "Billie Jean" },
                    { 47, 5, 7, 2.70m, "Bohemian Rhapsody" },
                    { 48, 6, 8, 2.90m, "Like a Rolling Stone" },
                    { 49, 7, 9, 3.30m, "Hey Jude" },
                    { 50, 8, 10, 2.50m, "Smells Like Teen Spirit" },
                    { 51, 9, 11, 3.00m, "Imagine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 51);
        }
    }
}
