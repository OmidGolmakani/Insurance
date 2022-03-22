using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class CreateDefaultAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Email", "HasImage", "IsDeleted", "LanguageId", "LastModified", "LastModifiedBy", "LockoutEnabled", "LockoutEnd", "NationalId", "NormalizedEmail", "NormalizedUserName", "ParentId", "PasswordHash", "PersonType", "PhoneNumber", "PhoneNumberConfirmed", "ReasonDeactivation", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1L, "69e99f0a-aae2-456a-a3d7-360ddbcf85c0", "System", new DateTime(2022, 3, 22, 12, 29, 16, 347, DateTimeKind.Local).AddTicks(8013), null, null, null, false, false, 1, null, null, false, null, "0", null, "ADMIN", null, "09111111111", (byte)1, "09111111111", true, null, "5IFNBTDO2BBCYS6SZDOM5M3SX5D2FM6R", false, "Admin" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L);

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
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 18, 0, 40, 36, 653, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 18, 0, 40, 36, 653, DateTimeKind.Local).AddTicks(6683));
        }
    }
}
