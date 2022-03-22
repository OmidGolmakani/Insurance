using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class AddDefaultRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1L, "420d99de-7b2d-4a31-acd9-da52b0927bd0", "مدیر ارشد", "Administrator", "ADMINISTRATOR" },
                    { 2L, "b212d236-c010-41bf-958a-71d77a3d61c2", "مهمان", "Guest", "GUEST" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2022, 3, 22, 18, 42, 34, 714, DateTimeKind.Local).AddTicks(8944), "AQAAAAEAACcQAAAAEKW/y44Jh9PvnN76n0szdq7UROQdDzJ00uYmnm/9IIT/sj1wwIp+9xGys5WvqlIQhg==", "TJUF2RGBNANVU2SAL3V5N6AL76XVC445" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 22, 18, 42, 34, 714, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 22, 18, 42, 34, 714, DateTimeKind.Local).AddTicks(8850));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2022, 3, 22, 13, 4, 2, 629, DateTimeKind.Local).AddTicks(5019), "09111111111", "5IFNBTDO2BBCYS6SZDOM5M3SX5D2FM6R" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 22, 13, 4, 2, 629, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 22, 13, 4, 2, 629, DateTimeKind.Local).AddTicks(4926));
        }
    }
}
