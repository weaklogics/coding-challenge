using System;
using System.Collections.Generic;
using System.Linq;


using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CarrerHub.Utility;
using CarrerHub.Model;
using static CarrerHub.Utility.DbconUtil;

namespace CarrerHub.Dao
{
    internal class JobListingDao:IjobListingDao
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        private string connectionString;

        public JobListingDao()
        {
            
            sqlConnection=new SqlConnection(DbconUtil.GetConnectionString());
            cmd = new SqlCommand();
        }


       
    }
        }
    

