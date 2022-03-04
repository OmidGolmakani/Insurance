using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class AddRelationLanguageIdForUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 4, 19, 41, 34, 46, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 4, 19, 41, 34, 46, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LanguageId",
                table: "AspNetUsers",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Language_LanguageId",
                table: "AspNetUsers",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Language_LanguageId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_LanguageId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 4, 19, 33, 21, 511, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 4, 19, 33, 21, 511, DateTimeKind.Local).AddTicks(3040));
        }
    }
}
