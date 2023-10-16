using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class OnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Age", "ExamDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, 30, new DateTime(2023, 10, 16, 10, 34, 41, 448, DateTimeKind.Local).AddTicks(9999), "Pepe", 10m },
                    { 2, 35, new DateTime(2023, 10, 16, 10, 34, 41, 449, DateTimeKind.Local).AddTicks(42), "Luis", 7m },
                    { 3, 29, new DateTime(2023, 10, 16, 10, 34, 41, 449, DateTimeKind.Local).AddTicks(45), "Ana", 8.4m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
