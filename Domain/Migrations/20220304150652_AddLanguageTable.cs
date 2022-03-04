using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class AddLanguageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "InsuranceTitle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    level = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceTitle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Direction = table.Column<byte>(type: "tinyint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Direction", "IsDeleted", "LanguageName", "LastModified", "LastModifiedBy" },
                values: new object[] { 1, "System", new DateTime(2022, 3, 4, 18, 36, 52, 169, DateTimeKind.Local).AddTicks(8438), null, null, (byte)2, false, "Persian", null, null });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Direction", "IsDeleted", "LanguageName", "LastModified", "LastModifiedBy" },
                values: new object[] { 2, "System", new DateTime(2022, 3, 4, 18, 36, 52, 169, DateTimeKind.Local).AddTicks(8472), null, null, (byte)1, false, "English", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InsuranceTitle");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "RolePermission");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "PointParameter");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "InsurancePointParameter");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "InsurancePoint");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "AspNetUsers");
        }
    }
}
