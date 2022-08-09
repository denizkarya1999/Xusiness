using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Omega.Web.Migrations
{
    public partial class SeedDataCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CompaniesGeneral",
                columns: new[] { "Id", "AreaOfService", "BlacklistedOrNot", "CompanyName", "CompanyType", "FoundationDate", "NumberOfEmployees", "PreviouslyWorkedOrNot", "Revenue", "SelectedOrNot", "WebsiteLink" },
                values: new object[] { new Guid("275d02a9-1664-40cd-b2b8-b03259b8eb6a"), "Global", false, "Omega Consulting LLC. (Sample)", "Business Solutions", new DateTime(2022, 7, 26, 12, 49, 43, 537, DateTimeKind.Local).AddTicks(2411), 15000, true, 120.0, true, "https://www.dev-27.azurewebsites.net" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompaniesGeneral",
                keyColumn: "Id",
                keyValue: new Guid("275d02a9-1664-40cd-b2b8-b03259b8eb6a"));
        }
    }
}
