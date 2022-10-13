using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Group11_SEN381_Project.DataAccess
{
    class DataHandler
    {
        SqlConnection con = new SqlConnection("Server=.;Database=MedicalCallCenter;Trusted_Connection=True"); 
        public SqlConnection sqlcon()
        {
            try
            {
                con.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
                MessageBox.Show(ex.ToString());
            }

            return con;

        }
        
        public DataTable getPolicy()
        {
            
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM Policy", sqlcon());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            
        }
        
        public DataTable getProvider()
        {
            {
               
                
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Provider", sqlcon());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                
            }
        }

        public DataTable getMedicalCondition()
        {
            {
                {
                    
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM MedicalCondition", sqlcon());
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    
                }
            }
        }

        public DataTable getTreatment()
        {
            {
                {
                   
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Treatment", sqlcon());
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
