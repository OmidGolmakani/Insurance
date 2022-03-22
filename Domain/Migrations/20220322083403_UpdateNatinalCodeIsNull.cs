using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class UpdateNatinalCodeIsNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NationalId",
                table: "AspNetUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "NationalId" },
                values: new object[] { new DateTime(2022, 3, 22, 13, 4, 2, 629, DateTimeKind.Local).AddTicks(5019), null });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NationalId",
                table: "AspNetUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "NationalId" },
                values: new object[] { new DateTime(2022, 3, 22, 12, 29, 16, 347, DateTimeKind.Local).AddTicks(8013), "0" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 22, 12, 29, 16, 347, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 22, 12, 29, 16, 347, DateTimeKind.Local).AddTicks(7881));
        }
    }
}
