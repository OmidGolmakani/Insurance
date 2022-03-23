using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class RemoveLanguageIdFromBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Language_LanguageId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceCompany_Language_LanguageId",
                table: "InsuranceCompany");

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
                name: "FK_Person_Language_LanguageId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_PointParameter_Language_LanguageId",
                table: "PointParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermission_Language_LanguageId",
                table: "RolePermission");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetail_Language_LanguageId",
                table: "UserDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailField_Language_LanguageId",
                table: "UserDetailField");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailLookupField_Language_LanguageId",
                table: "UserDetailLookupField");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGroup_Language_LanguageId",
                table: "UserGroup");

            migrationBuilder.DropIndex(
                name: "IX_UserGroup_LanguageId",
                table: "UserGroup");

            migrationBuilder.DropIndex(
                name: "IX_UserDetailLookupField_LanguageId",
                table: "UserDetailLookupField");

            migrationBuilder.DropIndex(
                name: "IX_UserDetailField_LanguageId",
                table: "UserDetailField");

            migrationBuilder.DropIndex(
                name: "IX_UserDetail_LanguageId",
                table: "UserDetail");

            migrationBuilder.DropIndex(
                name: "IX_RolePermission_LanguageId",
                table: "RolePermission");

            migrationBuilder.DropIndex(
                name: "IX_PointParameter_LanguageId",
                table: "PointParameter");

            migrationBuilder.DropIndex(
                name: "IX_Person_LanguageId",
                table: "Person");

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
                name: "IX_InsuranceCompany_LanguageId",
                table: "InsuranceCompany");

            migrationBuilder.DropIndex(
                name: "IX_Company_LanguageId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "UserGroup");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "UserDetailLookupField");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "UserDetailField");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "UserDetail");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "RolePermission");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "PointParameter");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "InsuranceTitle");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "InsurancePointParameter");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "InsurancePoint");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "InsuranceCompany");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Company");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 24, 2, 0, 32, 961, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 24, 2, 0, 32, 961, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 24, 2, 0, 32, 961, DateTimeKind.Local).AddTicks(8481));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "UserGroup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "UserDetailLookupField",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "UserDetailField",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "UserDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "RolePermission",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "PointParameter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Language",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "InsuranceTitle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "InsurancePointParameter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "InsurancePoint",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "InsuranceCompany",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                column: "CreatedDate",
                value: new DateTime(2022, 3, 23, 3, 25, 27, 253, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 23, 3, 25, 27, 253, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_LanguageId",
                table: "UserGroup",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailLookupField_LanguageId",
                table: "UserDetailLookupField",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailField_LanguageId",
                table: "UserDetailField",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_LanguageId",
                table: "UserDetail",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_LanguageId",
                table: "RolePermission",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PointParameter_LanguageId",
                table: "PointParameter",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_LanguageId",
                table: "Person",
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
                name: "IX_InsuranceCompany_LanguageId",
                table: "InsuranceCompany",
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
                name: "FK_InsuranceCompany_Language_LanguageId",
                table: "InsuranceCompany",
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
                name: "FK_Person_Language_LanguageId",
                table: "Person",
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

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetail_Language_LanguageId",
                table: "UserDetail",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailField_Language_LanguageId",
                table: "UserDetailField",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailLookupField_Language_LanguageId",
                table: "UserDetailLookupField",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroup_Language_LanguageId",
                table: "UserGroup",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id");
        }
    }
}
