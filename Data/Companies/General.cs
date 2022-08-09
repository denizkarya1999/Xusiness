using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Omega.Data.ITCompanies
{
    public class General
    {
        [Key]
        public Guid Id { get; set; }
        public string AreaOfService { get; set; }
        public bool BlacklistedOrNot { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public DateTime? FoundationDate { get; set; }
        public int NumberOfEmployees { get; set; }
        public bool PreviouslyWorkedOrNot { get; set; }
        public double Revenue { get; set; }
        public bool IsSelected { get; set; }
        public string WebsiteLink { get; set; }
    }
}
