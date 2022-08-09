using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Omega.Web.Migrations
{
    public partial class IsSelectedCreatedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompaniesGeneral",
                keyColumn: "Id",
                keyValue: new Guid("c8832872-0348-4a66-991e-bd72c6a5d372"));

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "CompaniesGeneral",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CompaniesGeneral",
                columns: new[] { "Id", "AreaOfService", "BlacklistedOrNot", "CompanyName", "CompanyType", "FoundationDate", "IsSelected", "NumberOfEmployees", "PreviouslyWorkedOrNot", "Revenue", "WebsiteLink" },
                values: new object[] { new Guid("2f65a494-2e28-4f29-8813-5fa4f202f1d4"), "Global", false, "Omega Consulting LLC. (Sample)", "Business Solutions", new DateTime(2022, 7, 30, 21, 42, 15, 967, DateTimeKind.Local).AddTicks(7311), false, 15000, true, 120.0, "https://www.dev-27.azurewebsites.net" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompaniesGeneral",
                keyColumn: "Id",
                keyValue: new Guid("2f65a494-2e28-4f29-8813-5fa4f202f1d4"));

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "CompaniesGeneral");

            migrationBuilder.InsertData(
                table: "CompaniesGeneral",
                columns: new[] { "Id", "AreaOfService", "BlacklistedOrNot", "CompanyName", "CompanyType", "FoundationDate", "NumberOfEmployees", "PreviouslyWorkedOrNot", "Revenue", "WebsiteLink" },
                values: new object[] { new Guid("c8832872-0348-4a66-991e-bd72c6a5d372"), "Global", false, "Omega Consulting LLC. (Sample)", "Business Solutions", new DateTime(2022, 7, 29, 11, 19, 22, 167, DateTimeKind.Local).AddTicks(2699), 15000, true, 120.0, "https://www.dev-27.azurewebsites.net" });
        }
    }
}
