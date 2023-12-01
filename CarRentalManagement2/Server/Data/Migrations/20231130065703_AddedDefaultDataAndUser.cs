using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement2.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 30, 14, 57, 3, 149, DateTimeKind.Local).AddTicks(8886), new DateTime(2023, 11, 30, 14, 57, 3, 149, DateTimeKind.Local).AddTicks(8897), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 30, 14, 57, 3, 149, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 11, 30, 14, 57, 3, 149, DateTimeKind.Local).AddTicks(8900), "Blue", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
