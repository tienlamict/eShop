using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class Seed_Identity_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e684a3c4-dd84-4018-aff5-fd3ace5886fa"), "b51e7729-f850-47f3-89c1-90cb3b17cfe0", "Administrator Role", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e684a3c4-dd84-4018-aff5-fd3ace5886fa"), new Guid("64ce4f89-8b76-4f12-8fd0-3b4caba86fc8") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("64ce4f89-8b76-4f12-8fd0-3b4caba86fc8"), 0, "efc2cc04-02a5-4b81-813b-0eb4cd8f45ae", new DateTime(1992, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "tienlamict@gmail.com", true, "Nguyen", "Tien Lam", false, null, "tienlamict@gmail.com", "admin", "AQAAAAEAACcQAAAAEKfuHsFPNr0DVsT2u62q14AUa6kxs4mQfGZtE+Cm5ToMFAfYH/DJZlsiUKEM8ylRaQ==", null, false, "", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 10, 9, 15, 58, 54, 927, DateTimeKind.Local).AddTicks(7503));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e684a3c4-dd84-4018-aff5-fd3ace5886fa"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e684a3c4-dd84-4018-aff5-fd3ace5886fa"), new Guid("64ce4f89-8b76-4f12-8fd0-3b4caba86fc8") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("64ce4f89-8b76-4f12-8fd0-3b4caba86fc8"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 10, 9, 15, 39, 43, 546, DateTimeKind.Local).AddTicks(4922));
        }
    }
}
