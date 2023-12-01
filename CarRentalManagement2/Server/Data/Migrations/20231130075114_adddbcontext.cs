using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement2.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class adddbcontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "04f5943f-183f-4da5-b5b6-d65e076619bc", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENpkEYu5fmLuLf3rE7uLnQ8iFEhDwFrE18HG2HA4v10kUTCwXczfm72pq8qvZexL2w==", null, false, "b90ea461-3e28-4b27-8d28-d0887577821b", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(1050), new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(1052), new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(901), new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(901), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(903), new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(903), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(683), new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(696), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(697), new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(698), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(699), new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(699), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(700), new DateTime(2023, 11, 30, 15, 51, 14, 14, DateTimeKind.Local).AddTicks(701), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 14, 57, 3, 149, DateTimeKind.Local).AddTicks(8886), new DateTime(2023, 11, 30, 14, 57, 3, 149, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 14, 57, 3, 149, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 11, 30, 14, 57, 3, 149, DateTimeKind.Local).AddTicks(8900) });
        }
    }
}
