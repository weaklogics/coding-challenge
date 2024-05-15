using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerHub.Model
{
    internal class JobApplication
    {
        public int ApplicationId { get; set; }
        public int JobId { get; set; }
        public int ApplicantId  { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string CoverLetter{ get; set; }

        public JobApplication()
        {

        }
        public JobApplication(int applicationid , int jobid ,int applicantid, DateTime applicationDate, string coverletter)
        {
            ApplicationId = applicationid;
                JobId = jobid;
            ApplicantId = applicantid;
            ApplicationDate = applicationDate;
            CoverLetter = coverletter;

        }
    }
}
