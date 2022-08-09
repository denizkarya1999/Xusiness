using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Omega.Data.ITCompanies;

namespace Project.Omega.Services.ITCompanies
{
    public class CompaniesSpecificService
    {
        // Property
        private readonly CompaniesDBContext _SpecificDBContext;

        // Constructor
        public CompaniesSpecificService(CompaniesDBContext SpecificDBContext)
        {
            _SpecificDBContext = SpecificDBContext;
        }

        // Get the list of specific companies
        public async Task<List<Specific>> GetAllSpecificCompanies()
        {
            return await _SpecificDBContext.CompaniesSpecific.ToListAsync();
        }

        // Get company by Id
        public async Task<Specific> GetSpecificCompanyByIDAsync(Guid Id)
        {
            Specific specificcompany = await _SpecificDBContext.CompaniesSpecific.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return specificcompany;
        }

        // Update company
        public async Task<bool> UpdateSpecificCompanyAsync(Specific specificcompany)
        {
            _SpecificDBContext.CompaniesSpecific.Update(specificcompany);
            await _SpecificDBContext.SaveChangesAsync();
            return true;
        }

        // Delete company
        public async Task<bool> DeleteSpecificCompanyAsync(Specific specificcompany)
        {
            _SpecificDBContext.Remove(specificcompany);
            await _SpecificDBContext.SaveChangesAsync();
            return true;
        }
    }
}
