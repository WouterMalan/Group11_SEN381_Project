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
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Policy", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable getProvider()
        {
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Provider", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable getMedicalCondition()
        {
            {
                {
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM MedicalCondition", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable getTreatment()
        {
            {
                {
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Treatment", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                    //Prov=New Provider();
                    //Prov.getProvider(34)
                }
            }
        }
    }
}
