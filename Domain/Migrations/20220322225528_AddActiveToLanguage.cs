using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class AddActiveToLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Language",
                type: "bit",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 23, 3, 25, 27, 253, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Active", "CreatedDate" },
                values: new object[] { true, new DateTime(2022, 3, 23, 3, 25, 27, 253, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Active", "CreatedDate" },
                values: new object[] { true, new DateTime(2022, 3, 23, 3, 25, 27, 253, DateTimeKind.Local).AddTicks(4209) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Language");

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
                column: "CreatedDate",
                value: new DateTime(2022, 3, 23, 1, 24, 44, 751, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 23, 1, 24, 44, 751, DateTimeKind.Local).AddTicks(839));
        }
    }
}
