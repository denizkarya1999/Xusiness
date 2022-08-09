using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Omega.Web.Migrations
{
    public partial class CreateGeneralandSpecificTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompaniesGeneral",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AreaOfService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlacklistedOrNot = table.Column<bool>(type: "bit", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoundationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfEmployees = table.Column<int>(type: "int", nullable: false),
                    PreviouslyWorkedOrNot = table.Column<bool>(type: "bit", nullable: false),
                    Revenue = table.Column<double>(type: "float", nullable: false),
                    SelectedOrNot = table.Column<bool>(type: "bit", nullable: false),
                    WebsiteLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompaniesGeneral", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompaniesSpecific",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AreaOfService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfEmployees = table.Column<int>(type: "int", nullable: false),
                    Revenue = table.Column<double>(type: "float", nullable: false),
                    WebsiteLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompaniesSpecific", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompaniesGeneral");

            migrationBuilder.DropTable(
                name: "CompaniesSpecific");
        }
    }
}
