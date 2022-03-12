using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class AddUserDetailAndUserDetailField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePointParameter_Company_InsuranceId",
                table: "InsurancePointParameter");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePointParameter_InsuranceId",
                table: "InsurancePointParameter");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Tel",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "NationalCode",
                table: "AspNetUsers",
                newName: "NationalId");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "InsuranceTitle",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Company",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "RegisterCode",
                table: "Company",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisterDate",
                table: "Company",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Company",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "Block",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValueSql: "0");

            migrationBuilder.AddColumn<byte>(
                name: "PersonType",
                table: "AspNetUsers",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "InsuranceCompany",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_InsuranceCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceCompany_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Family = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Person_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_UserGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGroup_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserGroup_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldId = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_UserDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetail_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetail_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDetailField",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    TypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Order = table.Column<byte>(type: "tinyint", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "1"),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "0"),
                    UserDetailId = table.Column<long>(type: "bigint", nullable: true),
                    UserDetailLookupFieldId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_UserDetailField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetailField_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetailField_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetailField_UserDetail_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDetailLookupField",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Order = table.Column<byte>(type: "tinyint", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, computedColumnSql: "1"),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false, computedColumnSql: "0"),
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
                    table.PrimaryKey("PK_UserDetailLookupField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetailLookupField_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetailLookupField_UserDetailField_FieldId",
                        column: x => x.FieldId,
                        principalTable: "UserDetailField",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 0, 38, 2, 177, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 0, 38, 2, 177, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.CreateIndex(
                name: "IX_PointParameter_Name_IsDeleted",
                table: "PointParameter",
                columns: new[] { "Name", "IsDeleted" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceTitle_Code_ParentId_IsDeleted",
                table: "InsuranceTitle",
                columns: new[] { "Code", "ParentId", "IsDeleted" },
                unique: true,
                filter: "[Code] IS NOT NULL AND [ParentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceTitle_ParentId",
                table: "InsuranceTitle",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePointParameter_InsuranceId_PointParameterId_IsDeleted",
                table: "InsurancePointParameter",
                columns: new[] { "InsuranceId", "PointParameterId", "IsDeleted" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_UserId",
                table: "Company",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceCompany_LanguageId",
                table: "InsuranceCompany",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_LanguageId",
                table: "Person",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_UserId",
                table: "Person",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_FieldId",
                table: "UserDetail",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_LanguageId",
                table: "UserDetail",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_UserId",
                table: "UserDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailField_LanguageId",
                table: "UserDetailField",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailField_UserDetailId",
                table: "UserDetailField",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailField_UserDetailLookupFieldId",
                table: "UserDetailField",
                column: "UserDetailLookupFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailField_UserId_Order_IsDeleted",
                table: "UserDetailField",
                columns: new[] { "UserId", "Order", "IsDeleted" },
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailLookupField_FieldId_Name_IsDeleted",
                table: "UserDetailLookupField",
                columns: new[] { "FieldId", "Name", "IsDeleted" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetailLookupField_LanguageId",
                table: "UserDetailLookupField",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_LanguageId",
                table: "UserGroup",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_UserId_Name",
                table: "UserGroup",
                columns: new[] { "UserId", "Name" });

            migrationBuilder.AddForeignKey(
                name: "FK_Company_AspNetUsers_UserId",
                table: "Company",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePointParameter_InsuranceCompany_InsuranceId",
                table: "InsurancePointParameter",
                column: "InsuranceId",
                principalTable: "InsuranceCompany",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceTitle_InsuranceTitle_ParentId",
                table: "InsuranceTitle",
                column: "ParentId",
                principalTable: "InsuranceTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetail_UserDetailField_FieldId",
                table: "UserDetail",
                column: "FieldId",
                principalTable: "UserDetailField",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetailField_UserDetailLookupField_UserDetailLookupFieldId",
                table: "UserDetailField",
                column: "UserDetailLookupFieldId",
                principalTable: "UserDetailLookupField",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_AspNetUsers_UserId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePointParameter_InsuranceCompany_InsuranceId",
                table: "InsurancePointParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceTitle_InsuranceTitle_ParentId",
                table: "InsuranceTitle");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetail_UserDetailField_FieldId",
                table: "UserDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetailLookupField_UserDetailField_FieldId",
                table: "UserDetailLookupField");

            migrationBuilder.DropTable(
                name: "InsuranceCompany");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "UserDetailField");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "UserDetailLookupField");

            migrationBuilder.DropIndex(
                name: "IX_PointParameter_Name_IsDeleted",
                table: "PointParameter");

            migrationBuilder.DropIndex(
                name: "IX_InsuranceTitle_Code_ParentId_IsDeleted",
                table: "InsuranceTitle");

            migrationBuilder.DropIndex(
                name: "IX_InsuranceTitle_ParentId",
                table: "InsuranceTitle");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePointParameter_InsuranceId_PointParameterId_IsDeleted",
                table: "InsurancePointParameter");

            migrationBuilder.DropIndex(
                name: "IX_Company_UserId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "InsuranceTitle");

            migrationBuilder.DropColumn(
                name: "RegisterCode",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "RegisterDate",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Block",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonType",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "AspNetUsers",
                newName: "NationalCode");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Company",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tel",
                table: "AspNetUsers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true);

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
                name: "IX_InsurancePointParameter_InsuranceId",
                table: "InsurancePointParameter",
                column: "InsuranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePointParameter_Company_InsuranceId",
                table: "InsurancePointParameter",
                column: "InsuranceId",
                principalTable: "Company",
                principalColumn: "Id");
        }
    }
}
