using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class AddRelationLanguageId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Language",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_LanguageId",
                table: "RolePermission",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PointParameter_LanguageId",
                table: "PointParameter",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceTitle_LanguageId",
                table: "InsuranceTitle",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePointParameter_LanguageId",
                table: "InsurancePointParameter",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePoint_LanguageId",
                table: "InsurancePoint",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_LanguageId",
                table: "Company",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Language_LanguageId",
                table: "Company",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePoint_Language_LanguageId",
                table: "InsurancePoint",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePointParameter_Language_LanguageId",
                table: "InsurancePointParameter",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceTitle_Language_LanguageId",
                table: "InsuranceTitle",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointParameter_Language_LanguageId",
                table: "PointParameter",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermission_Language_LanguageId",
                table: "RolePermission",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Language_LanguageId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePoint_Language_LanguageId",
                table: "InsurancePoint");

            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePointParameter_Language_LanguageId",
                table: "InsurancePointParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceTitle_Language_LanguageId",
                table: "InsuranceTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_PointParameter_Language_LanguageId",
                table: "PointParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermission_Language_LanguageId",
                table: "RolePermission");

            migrationBuilder.DropIndex(
                name: "IX_RolePermission_LanguageId",
                table: "RolePermission");

            migrationBuilder.DropIndex(
                name: "IX_PointParameter_LanguageId",
                table: "PointParameter");

            migrationBuilder.DropIndex(
                name: "IX_InsuranceTitle_LanguageId",
                table: "InsuranceTitle");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePointParameter_LanguageId",
                table: "InsurancePointParameter");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePoint_LanguageId",
                table: "InsurancePoint");

            migrationBuilder.DropIndex(
                name: "IX_Company_LanguageId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Language");

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 4, 18, 36, 52, 169, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 4, 18, 36, 52, 169, DateTimeKind.Local).AddTicks(8472));
        }
    }
}
