using CarrerHub.Model;
using CarrerHub.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static CarrerHub.Utility.DbconUtil;

namespace CarrerHub.Dao
{
    internal class CompanyDao : IcompanyDao
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        //constructor
        public CompanyDao()
        {

            sqlConnection = new SqlConnection(DbconUtil.GetConnectionString());
            cmd = new SqlCommand();
        }

        public List<Company> GetCompanies()
        {
            List<Company> company = new List<Company>();
            using (SqlConnection sqlConnection = new SqlConnection(DbconUtil.GetConnectionString()))
            {
                cmd.CommandText = "select * from companies";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Company company1 = new Company();
                    company1.CompanyId = (int)reader["CompanyId"];
                    company1.CompanyName = (string)reader["CompanyName"];
                    company1.Location = (string)reader["Location"];

                    company.Add(company1);
                }

                return company;
            }
        }
        public List<JobListing> GetJobs(Company company)
        {
            List<JobListing> Jobs = new List<JobListing>();
            cmd.CommandText = "SELECT * FROM Jobs WHERE CompanyID = @compid";
            cmd.Parameters.AddWithValue("@compid", company.CompanyId);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                JobListing newjobs = new JobListing();
                newjobs.JobTitle = (string)reader["JobTitle"];
                newjobs.JobDescription = (string)reader["JobDescription"];
                newjobs.JobType = (string)reader["JobType"];
                newjobs.JobLocation = (string)reader["JobLocation"];
                newjobs.Salary = (decimal)reader["Salary"];
                newjobs.PostedDate = (DateTime)reader["PostedDate"];

                Jobs.Add(newjobs);
            }
            sqlConnection.Close();
            return Jobs;
        }
    }
}

