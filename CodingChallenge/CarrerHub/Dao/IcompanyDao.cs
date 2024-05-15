using CarrerHub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerHub
{
    internal interface IcompanyDao
    {
        List<Company> GetCompanies();
        List<JobListing> GetJobs(Company company);
      
    }
}
