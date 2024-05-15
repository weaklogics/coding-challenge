using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarrerHub.Model
{
    internal class Company
    {
        public int CompanyId { get; set; }  

        public string CompanyName { get; set; }
        public string Location { get; set;}

        public Company()
        {

        }
        public Company(int companyid , string companyname,string location )
        {
            CompanyId = companyid;
            CompanyName = companyname;
            Location = location;


        }

        public override string ToString()
        {
            return $"companyid:{CompanyId}, companyname:{CompanyName}, location:{Location}";
        }
    }
    }

