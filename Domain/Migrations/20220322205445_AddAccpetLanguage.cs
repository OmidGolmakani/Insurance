using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class AddAccpetLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcceptLanguage",
                table: "Language",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 23, 1, 24, 44, 751, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AcceptLanguage", "CreatedDate" },
                values: new object[] { "fa-IR", new DateTime(2022, 3, 23, 1, 24, 44, 751, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AcceptLanguage", "CreatedDate" },
                values: new object[] { "en-US", new DateTime(2022, 3, 23, 1, 24, 44, 751, DateTimeKind.Local).AddTicks(839) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptLanguage",
                table: "Language");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 22, 18, 59, 53, 690, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 22, 18, 59, 53, 690, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 22, 18, 59, 53, 690, DateTimeKind.Local).AddTicks(1643));
        }
    }
}
