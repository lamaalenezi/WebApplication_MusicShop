using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication_MusicShop.Migrations
{
    /// <inheritdoc />
    public partial class addDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Performers",
                columns: table => new
                {
                    PerformerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performers", x => x.PerformerId);
                    table.ForeignKey(
                        name: "FK_Performers_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId");
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: true),
                    PerformerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId");
                    table.ForeignKey(
                        name: "FK_Songs_Performers_PerformerId",
                        column: x => x.PerformerId,
                        principalTable: "Performers",
                        principalColumn: "PerformerId");
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, "Rock" },
                    { 2, "Pop" },
                    { 3, "Jazz" },
                    { 4, "Metal" },
                    { 5, "Rap" },
                    { 6, "Country" },
                    { 7, "Blues" },
                    { 8, "Electronic" },
                    { 9, "Folk" },
                    { 10, "Classical" },
                    { 11, "Reggae" },
                    { 12, "Punk" },
                    { 13, "Soul" },
                    { 14, "Alternative" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "PerformerId", "Description", "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, null, 1, "Adam Levine" },
                    { 2, null, 2, "Taylor Swift" },
                    { 3, null, 3, "Miles Davis" },
                    { 4, null, 4, "James Hetfield" },
                    { 5, null, 5, "Eminem" },
                    { 6, null, 6, "Dolly Parton" },
                    { 7, null, 7, "B.B. King" },
                    { 8, null, 8, "Calvin Harris" },
                    { 9, null, 9, "Bob Dylan" },
                    { 10, null, 10, "Ludwig van Beethoven" },
                    { 11, null, 11, "Bob Marley" },
                    { 12, null, 12, "Joey Ramone" },
                    { 13, null, 13, "Aretha Franklin" },
                    { 14, null, 14, "Kurt Cobain" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "GenreId", "PerformerId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, 1.99m, "Starlight" },
                    { 2, 2, 2, 2.99m, "Shake It Off" },
                    { 3, 3, 3, 1.49m, "Blue in Green" },
                    { 4, 4, 4, 2.49m, "Enter Sandman" },
                    { 5, 5, 5, 3.99m, "Lose Yourself" },
                    { 6, 6, 6, 1.99m, "Jolene" },
                    { 7, 7, 7, 2.99m, "The Thrill Is Gone" },
                    { 8, 8, 8, 3.49m, "Summer" },
                    { 9, 9, 9, 1.99m, "Blowin' in the Wind" },
                    { 10, 10, 10, 4.99m, "Fifth Symphony" },
                    { 11, 11, 11, 3.49m, "No Woman, No Cry" },
                    { 12, 12, 12, 2.49m, "Blitzkrieg Bop" },
                    { 13, 13, 13, 2.99m, "Respect" },
                    { 14, 14, 14, 3.99m, "Smells Like Teen Spirit" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Performers_GenreId",
                table: "Performers",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_PerformerId",
                table: "Songs",
                column: "PerformerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Performers");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
