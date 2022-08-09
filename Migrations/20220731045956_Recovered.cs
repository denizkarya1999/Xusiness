using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Omega.Web.Migrations
{
    public partial class Recovered : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompaniesGeneral",
                keyColumn: "Id",
                keyValue: new Guid("a118cf5c-fbb8-40be-9330-8b2eac5a53fe"));

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "CompaniesGeneral",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CompaniesGeneral",
                columns: new[] { "Id", "AreaOfService", "BlacklistedOrNot", "CompanyName", "CompanyType", "FoundationDate", "IsSelected", "NumberOfEmployees", "PreviouslyWorkedOrNot", "Revenue", "WebsiteLink" },
                values: new object[] { new Guid("8e605783-79e0-452c-95b8-045b0d5a963c"), "Global", false, "Omega Consulting LLC. (Sample)", "Business Solutions", new DateTime(2022, 7, 30, 21, 59, 56, 248, DateTimeKind.Local).AddTicks(185), true, 15000, true, 120.0, "https://www.dev-27.azurewebsites.net" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompaniesGeneral",
                keyColumn: "Id",
                keyValue: new Guid("8e605783-79e0-452c-95b8-045b0d5a963c"));

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "CompaniesGeneral");

            migrationBuilder.InsertData(
                table: "CompaniesGeneral",
                columns: new[] { "Id", "AreaOfService", "BlacklistedOrNot", "CompanyName", "CompanyType", "FoundationDate", "NumberOfEmployees", "PreviouslyWorkedOrNot", "Revenue", "WebsiteLink" },
                values: new object[] { new Guid("a118cf5c-fbb8-40be-9330-8b2eac5a53fe"), "Global", false, "Omega Consulting LLC. (Sample)", "Business Solutions", new DateTime(2022, 7, 30, 21, 57, 38, 982, DateTimeKind.Local).AddTicks(8349), 15000, true, 120.0, "https://www.dev-27.azurewebsites.net" });
        }
    }
}
