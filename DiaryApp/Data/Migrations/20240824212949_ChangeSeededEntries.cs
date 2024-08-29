using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSeededEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Date", "Title" },
                values: new object[] { "We went hiking with Rain!", new DateTime(2024, 8, 25, 0, 29, 48, 832, DateTimeKind.Local).AddTicks(7134), "Went hiking!" });

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Date", "Title" },
                values: new object[] { "I worked on my game...", new DateTime(2024, 8, 25, 0, 29, 48, 832, DateTimeKind.Local).AddTicks(7135), "Worked on Anima." });

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Date", "Title" },
                values: new object[] { "We played tennis with Rain!", new DateTime(2024, 8, 25, 0, 29, 48, 832, DateTimeKind.Local).AddTicks(7137), "Played tennis!" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Date", "Title" },
                values: new object[] { "This is the first entry in the diary.", new DateTime(2024, 8, 25, 0, 12, 22, 781, DateTimeKind.Local).AddTicks(3947), "First Entry" });

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Date", "Title" },
                values: new object[] { "This is the second entry in the diary.", new DateTime(2024, 8, 25, 0, 12, 22, 781, DateTimeKind.Local).AddTicks(3949), "Second Entry" });

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Date", "Title" },
                values: new object[] { "This is the third entry in the diary.", new DateTime(2024, 8, 25, 0, 12, 22, 781, DateTimeKind.Local).AddTicks(3951), "Third Entry" });
        }
    }
}
