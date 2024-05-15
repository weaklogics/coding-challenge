using CarrerHub.Dao;
using CarrerHub.Model;

namespace CarrerHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
          IcompanyDao companyDao = new CompanyDao();
            List<Company> companies = companyDao.GetCompanies();
            foreach (Company company in companies)
            {
                Console.WriteLine(company);
            }

            Iapplicantdao applicantDao = new ApplicantDao();
            List<Applicant> applicants = applicantDao.GetApplicants();
            foreach (Applicant applicant in applicants)
            { 
                Console.WriteLine(applicant);
            }

            IcompanyDao companyDa  = new CompanyDao();
            List<JobListing> getJobs = companyDa.GetJobs();
            foreach (JobListing jobListing in getJobs)
            {
                Console.WriteLine(jobListing);
            }
                




           





        }

    }
}
