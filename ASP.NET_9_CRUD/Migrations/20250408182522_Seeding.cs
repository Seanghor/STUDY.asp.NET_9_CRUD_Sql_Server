using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.NET_9_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Developer", "Platform", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Seanghor", "PS5", "Sony Interactive Entertainment", "Test" },
                    { 2, "Game Studio", "PS4", "Big Games Inc.", "Adventure Quest" },
                    { 3, "Epic Developers", "PC", "Super Games Co.", "Battle Royale" },
                    { 4, "SpeedWorks", "Xbox", "Turbo Media", "Racing Rivals" },
                    { 5, "Galaxy Studios", "PS5", "Cosmic Entertainment", "Space Odyssey" },
                    { 6, "Survival Games", "PC", "Apocalypse Studios", "Zombie Defense" },
                    { 7, "Fantasy Makers", "PS4", "DreamWorks Entertainment", "Fantasy World" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
