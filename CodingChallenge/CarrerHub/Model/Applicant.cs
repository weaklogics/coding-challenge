using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerHub.Model
{
    internal class Applicant
    {
        public int ApplicantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email{ get; set; }
        public string Phone { get; set; }
            public string Resume { get; set; }


        public Applicant()
        {

        }
        public Applicant(int applicantid,string firstname,string lastname ,string email,string phone)
        {
            ApplicantId = applicantid;
            FirstName = firstname;
                
            LastName = lastname;
            Email = email;
            Phone = phone;

        }
        public override string ToString() {
            return $"ApplicantId:{ApplicantId}, FirstName:{FirstName}, LastName:{LastName},Email:{Email},Phone:{Phone}";
        }

        
    }
}
