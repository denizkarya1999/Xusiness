using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Omega.Data.ITCompanies
{
    public class Specific
    {
        [Key]
        public Guid Id { get; set; }
        public string AreaOfService { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
        public double Revenue { get; set; }
        public string WebsiteLink { get; set; }
    }
}
