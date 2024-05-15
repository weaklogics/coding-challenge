using CarrerHub.Model;
using CarrerHub.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerHub.Dao
{
    internal class ApplicantDao : Iapplicantdao
    {

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        //constructor
        public ApplicantDao()
        {

            sqlConnection = new SqlConnection(DbconUtil.GetConnectionString());
            cmd = new SqlCommand();
        }

        public List<Applicant> GetApplicants()
        {
            List<Applicant> applicants = new List<Applicant>();
            using (SqlConnection sqlConnection = new SqlConnection(DbconUtil.GetConnectionString()))
            {
                cmd.CommandText = "select * from Applicants";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Applicant applicant = new Applicant();
                    applicant.ApplicantId = (int)reader["ApplicantId"];
                    applicant.FirstName = (string)reader["FirstName"];
                    applicant.LastName = (string)reader["LastName"];
                    applicant.Email = (string)reader["Email"];
                    applicant.Phone = (string)reader["Phone"];
                    applicant.Resume = (string)reader["Resume"];
                    applicants.Add(applicant);


                }
                return applicants;
            }

        }
    }
}
