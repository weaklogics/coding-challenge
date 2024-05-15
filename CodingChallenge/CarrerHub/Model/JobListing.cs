using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerHub.Model
{
    internal class JobListing
    {
        public int JobID   { get; set; }
        public int CompanyId { get; set; }
        public string JobTitle { get; set;}
        public string JobDescription { get; set;}
        public string JobLocation { get; set;}
        public decimal Salary {  get; set;}
        public string JobType { get; set; }


        public DateTime PostedDate { get; set; }


        public JobListing()
        {

        }
        public JobListing(int jobid,int companyid , string jobtitle, string jobdescription, string joblocation ,decimal salary, string jobtype )
        {
            JobID = jobid;
            CompanyId = companyid;
            JobTitle = jobtitle;
            JobDescription = jobdescription;
            JobLocation = joblocation;
            Salary = salary;
                JobType = jobtype;

        }
   

    }



}
