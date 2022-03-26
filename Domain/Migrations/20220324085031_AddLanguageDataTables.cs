using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class AddLanguageDataTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserDetailLookupField_FieldId_Name_IsDeleted",
                table: "UserDetailLookupField");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "UserDetailLookupField",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserDetailLookupField",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CompanyLanguageData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    RegisterCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
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
                    table.PrimaryKey("PK_CompanyLanguageData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyLanguageData_Company_KeyId",
                        column: x => x.KeyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyLanguageData_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InsuranceTitleLanguageData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
                    table.PrimaryKey("PK_InsuranceTitleLanguageData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceTitleLanguageData_InsuranceTitle_KeyId",
                        column: x => x.KeyId,
                        principalTable: "InsuranceTitle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsuranceTitleLanguageData_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonLanguageData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Family = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
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
                    table.PrimaryKey("PK_PersonLanguageData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonLanguageData_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonLanguageData_Person_KeyId",
                        column: x => x.KeyId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PointParameterLanguageData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_PointParameterLanguageData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PointParameterLanguageData_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PointParameterLanguageData_PointParameter_KeyId",
                        column: x => x.KeyId,
                        principalTable: "PointParameter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetailFieldLanguageData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_UserDetailFieldLanguageData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetailFieldLanguageData_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetailFieldLanguageData_UserDetailField_KeyId",
                        column: x => x.KeyId,
                        principalTable: "UserDetailField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetailLanguageData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_UserDetailLanguageData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetailLanguageData_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetailLanguageData_UserDetail_KeyId",
                        column: x => x.KeyId,
                        principalTable: "UserDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetailLookupFieldLanguageData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_UserDetailLookupFieldLanguageData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetailLookupFieldLanguageData_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetailLookupFieldLanguageData_UserDetailLookupField_KeyId",
                        column: x => x.KeyId,
                        principalTable: "UserDetailLookupField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 24, 13, 20, 30, 656, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 24, 13, 20, 30, 656, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 24, 13, 20, 30, 656, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailLookupField_FieldId_Name_IsDeleted",
                table: "UserDetailLookupField",
                columns: new[] { "FieldId", "Name", "IsDeleted" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLanguageData_KeyId",
                table: "CompanyLanguageData",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLanguageData_LanguageId",
                table: "CompanyLanguageData",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceTitleLanguageData_KeyId",
                table: "InsuranceTitleLanguageData",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceTitleLanguageData_LanguageId",
                table: "InsuranceTitleLanguageData",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonLanguageData_KeyId",
                table: "PersonLanguageData",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonLanguageData_LanguageId",
                table: "PersonLanguageData",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PointParameterLanguageData_KeyId",
                table: "PointParameterLanguageData",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_PointParameterLanguageData_LanguageId",
                table: "PointParameterLanguageData",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailFieldLanguageData_KeyId",
                table: "UserDetailFieldLanguageData",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailFieldLanguageData_LanguageId",
                table: "UserDetailFieldLanguageData",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailLanguageData_KeyId",
                table: "UserDetailLanguageData",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailLanguageData_LanguageId",
                table: "UserDetailLanguageData",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailLookupFieldLanguageData_KeyId",
                table: "UserDetailLookupFieldLanguageData",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailLookupFieldLanguageData_LanguageId",
                table: "UserDetailLookupFieldLanguageData",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyLanguageData");

            migrationBuilder.DropTable(
                name: "InsuranceTitleLanguageData");

            migrationBuilder.DropTable(
                name: "PersonLanguageData");

            migrationBuilder.DropTable(
                name: "PointParameterLanguageData");

            migrationBuilder.DropTable(
                name: "UserDetailFieldLanguageData");

            migrationBuilder.DropTable(
                name: "UserDetailLanguageData");

            migrationBuilder.DropTable(
                name: "UserDetailLookupFieldLanguageData");

            migrationBuilder.DropIndex(
                name: "IX_UserDetailLookupField_FieldId_Name_IsDeleted",
                table: "UserDetailLookupField");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "UserDetailLookupField",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserDetailLookupField",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

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

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailLookupField_FieldId_Name_IsDeleted",
                table: "UserDetailLookupField",
                columns: new[] { "FieldId", "Name", "IsDeleted" },
                unique: true,
                filter: "[Name] IS NOT NULL");
        }
    }
}
