using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Omega.Data.ITCompanies
{
    public class CompaniesDBContext : DbContext
    {
        public CompaniesDBContext(DbContextOptions<CompaniesDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<General>().HasData(
                new General()
                {
                    Id = Guid.NewGuid(),
                    AreaOfService = "Global",
                    BlacklistedOrNot = false,
                    CompanyName = "Omega Consulting LLC. (Sample)",
                    CompanyType = "Business Solutions",
                    FoundationDate = DateTime.Now,
                    NumberOfEmployees = 15000,
                    PreviouslyWorkedOrNot = true,
                    Revenue = 120.00000000000,
                    IsSelected = false,
                    WebsiteLink = "https://www.dev-27.azurewebsites.net"
                }
            );
        }
        public DbSet<General> CompaniesGeneral { get; set; }
        public DbSet<Specific> CompaniesSpecific { get; set; }
    }
}
