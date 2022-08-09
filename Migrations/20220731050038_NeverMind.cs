using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Omega.Web.Migrations
{
    public partial class NeverMind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompaniesGeneral",
                keyColumn: "Id",
                keyValue: new Guid("8e605783-79e0-452c-95b8-045b0d5a963c"));

            migrationBuilder.InsertData(
                table: "CompaniesGeneral",
                columns: new[] { "Id", "AreaOfService", "BlacklistedOrNot", "CompanyName", "CompanyType", "FoundationDate", "IsSelected", "NumberOfEmployees", "PreviouslyWorkedOrNot", "Revenue", "WebsiteLink" },
                values: new object[] { new Guid("7bc61611-20bf-42eb-84b0-a5519f5aec85"), "Global", false, "Omega Consulting LLC. (Sample)", "Business Solutions", new DateTime(2022, 7, 30, 22, 0, 37, 630, DateTimeKind.Local).AddTicks(1454), false, 15000, true, 120.0, "https://www.dev-27.azurewebsites.net" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompaniesGeneral",
                keyColumn: "Id",
                keyValue: new Guid("7bc61611-20bf-42eb-84b0-a5519f5aec85"));

            migrationBuilder.InsertData(
                table: "CompaniesGeneral",
                columns: new[] { "Id", "AreaOfService", "BlacklistedOrNot", "CompanyName", "CompanyType", "FoundationDate", "IsSelected", "NumberOfEmployees", "PreviouslyWorkedOrNot", "Revenue", "WebsiteLink" },
                values: new object[] { new Guid("8e605783-79e0-452c-95b8-045b0d5a963c"), "Global", false, "Omega Consulting LLC. (Sample)", "Business Solutions", new DateTime(2022, 7, 30, 21, 59, 56, 248, DateTimeKind.Local).AddTicks(185), true, 15000, true, 120.0, "https://www.dev-27.azurewebsites.net" });
        }
    }
}
