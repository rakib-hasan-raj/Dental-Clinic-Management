using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dental_Clinic_Management_Project
{
    class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-JE2QVC1;Initial Catalog=DentalDb;Persist Security Info=True;User ID=sa;Password=125141";
            return Con;
        }
    }
}
