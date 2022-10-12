using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Group11_SEN381_Project.DataAccess
{
    class DataHandler
    {
        string connection = "Data Source=DESKTOP-V43B9TN\\SQLEXPRESS;Initial Catalog=MedicalCallCentre;Integrated Security=True";
        public DataTable getPolicy()
        {
            SqlConnection cn = new SqlConnection(connection);
            SqlDataAdapter ad = new SqlDataAdapter("getPolicy", cn);
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
