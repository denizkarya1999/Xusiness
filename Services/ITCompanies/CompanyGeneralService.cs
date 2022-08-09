using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Omega.Data.ITCompanies;

namespace Project.Omega.Services.ITCompanies
{
    public class CompanyGeneralService
    {
        // Property
        private readonly CompaniesDBContext _GeneralDBContext;

        // Constructor
        public CompanyGeneralService(CompaniesDBContext GeneralDBContext)
        {
            _GeneralDBContext = GeneralDBContext;
        }

        // Get the list of general companies
        public async Task<List<General>> GetAllGeneralCompanies()
        {
            return await _GeneralDBContext.CompaniesGeneral.ToListAsync();
        }

        // Insert a company into general database
        public async Task<bool> InsertGeneralCompany(General generalcompany)
        {
            await _GeneralDBContext.CompaniesGeneral.AddAsync(generalcompany);
            await _GeneralDBContext.SaveChangesAsync();
            return true;
        }

        // Get company by Id
        public async Task<General> GetGeneralCompanyByIDAsync(Guid Id)
        {
            General generalcompany = await _GeneralDBContext.CompaniesGeneral.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return generalcompany;
        }

        // Update company
        public async Task<bool> UpdateGeneralCompanyAsync(General generalcompany)
        {
            _GeneralDBContext.CompaniesGeneral.Update(generalcompany);
            await _GeneralDBContext.SaveChangesAsync();
            return true;
        }

        // Delete company
        public async Task<bool> DeleteGeneralCompanyAsync(General generalcompany)
        {
            _GeneralDBContext.Remove(generalcompany);
            await _GeneralDBContext.SaveChangesAsync();
            return true;
        }

        //Transfer from General to Specific
        public async Task<bool> SelectAndTransferCompany(General generalcompany)
        {
            //Create a new target company
            Specific targetcompany = new Specific()
            {
                Id = generalcompany.Id,
                AreaOfService = generalcompany.AreaOfService,
                CompanyName = generalcompany.CompanyName,
                NumberOfEmployees = generalcompany.NumberOfEmployees,
                Revenue = generalcompany.Revenue,
                WebsiteLink = generalcompany.WebsiteLink,
            };
            //Assign it into specific database
            await _GeneralDBContext.CompaniesSpecific.AddAsync(targetcompany);

            //Save changes
            await _GeneralDBContext.SaveChangesAsync();

            //If successful return true
            return true;
        }
    }
}
