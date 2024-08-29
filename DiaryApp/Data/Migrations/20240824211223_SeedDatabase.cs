using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Date", "Title" },
                values: new object[,]
                {
                    { 1, "This is the first entry in the diary.", new DateTime(2024, 8, 25, 0, 12, 22, 781, DateTimeKind.Local).AddTicks(3947), "First Entry" },
                    { 2, "This is the second entry in the diary.", new DateTime(2024, 8, 25, 0, 12, 22, 781, DateTimeKind.Local).AddTicks(3949), "Second Entry" },
                    { 3, "This is the third entry in the diary.", new DateTime(2024, 8, 25, 0, 12, 22, 781, DateTimeKind.Local).AddTicks(3951), "Third Entry" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
