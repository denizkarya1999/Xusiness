using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Omega.Web.Migrations
{
    public partial class SelectedOrNotRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompaniesGeneral",
                keyColumn: "Id",
                keyValue: new Guid("275d02a9-1664-40cd-b2b8-b03259b8eb6a"));

            migrationBuilder.DropColumn(
                name: "SelectedOrNot",
                table: "CompaniesGeneral");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FoundationDate",
                table: "CompaniesGeneral",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "CompaniesGeneral",
                columns: new[] { "Id", "AreaOfService", "BlacklistedOrNot", "CompanyName", "CompanyType", "FoundationDate", "NumberOfEmployees", "PreviouslyWorkedOrNot", "Revenue", "WebsiteLink" },
                values: new object[] { new Guid("c8832872-0348-4a66-991e-bd72c6a5d372"), "Global", false, "Omega Consulting LLC. (Sample)", "Business Solutions", new DateTime(2022, 7, 29, 11, 19, 22, 167, DateTimeKind.Local).AddTicks(2699), 15000, true, 120.0, "https://www.dev-27.azurewebsites.net" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompaniesGeneral",
                keyColumn: "Id",
                keyValue: new Guid("c8832872-0348-4a66-991e-bd72c6a5d372"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FoundationDate",
                table: "CompaniesGeneral",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SelectedOrNot",
                table: "CompaniesGeneral",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CompaniesGeneral",
                columns: new[] { "Id", "AreaOfService", "BlacklistedOrNot", "CompanyName", "CompanyType", "FoundationDate", "NumberOfEmployees", "PreviouslyWorkedOrNot", "Revenue", "SelectedOrNot", "WebsiteLink" },
                values: new object[] { new Guid("275d02a9-1664-40cd-b2b8-b03259b8eb6a"), "Global", false, "Omega Consulting LLC. (Sample)", "Business Solutions", new DateTime(2022, 7, 26, 12, 49, 43, 537, DateTimeKind.Local).AddTicks(2411), 15000, true, 120.0, true, "https://www.dev-27.azurewebsites.net" });
        }
    }
}
