using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections.Specialized;

namespace Group11_SEN381_Project.DataAccess
{
    class DataHandler
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Database=MedicalCallCenter;Trusted_Connection=True");
        public SqlConnection sqlcon()
        {// this will test the connection and open it and retune the connection needed for sqlcommand/saladpater
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

        public DataTable getClient()
        {
            {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Client", con);
                    sda.Fill(dt);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return dt;
            }
        }
        //TODO: try to fix error
        //public DataTable updateClient(int id, string name_surname, string address, string phone_number, string email,string dependents, int national_id)
        //{
        //    con.Open();
        //    try
        //    {

        //        string line = "Update Client set  Name_Surname='" + name_surname + "',address= '" + address + "', phone_number='" + phone_number + "',Email='" + email + "',Dependents=  '" + dependents+ "',National_id=  '" + national_id + "' where id= '" + id.ToString() + "'";
        //        SqlCommand command = new SqlCommand(line, con);
        //        command.ExecuteNonQuery();
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Data Failed to be Updated");
        //        MessageBox.Show(ex.ToString());

        //    }
        //    finally
        //    {
        //        MessageBox.Show("Data was updated");

        //    }
        //    con.Close();
        //}

        public DataTable getPolicy()
        {

            // this function will run and send a full view of the respective table in a data table format 
            SqlCommand cmd = new SqlCommand("SELECT * FROM Policy", sqlcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void UpdatePolicy(int id, string desc, DateTime date_time, string type_of_policy, int fee, int expired)
        {
            con.Open();
            try
            {

                string line = "Update Policy set  description='" + desc + "',Date_Time= '" + date_time + "', Type_of_Policy='" + type_of_policy + "',Fee='" + fee.ToString() + "',expired=  '" + expired.ToString() + "' where id= '" + id.ToString() + "'";
                SqlCommand command = new SqlCommand(line, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Updated");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was updated");

            }
            con.Close();
        }

        public DataTable getProvider()
        {
            {



                SqlCommand cmd = new SqlCommand("SELECT * FROM Providers", sqlcon());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
        }

        public void UpdateProvider(int id, string Name, string Location, int rating)
        {

            try
            {

                string line = "Update Providers set   Name='" + Name + "',Location= '" + Location + "', Rating='" + rating.ToString() + "' where id= '" + id.ToString() + "'";
                SqlCommand command = new SqlCommand(line, sqlcon());
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Updated");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was updated");

            }
            con.Close();
        }



        public DataTable getMedicalCondition()
        {
            {
                {


                    SqlCommand cmd = new SqlCommand("SELECT * FROM MedicalCondition", sqlcon());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
            }
        }

        public void UpdateMedicalConditions(int id, string Name, string description)
        {

            try
            {

                string line = "Update Medical_Conditions set   Condition_Name='" + Name + "',Description= '" + description + "'  where id= '" + id.ToString() + "'";
                SqlCommand command = new SqlCommand(line, sqlcon());
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Updated");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was updated");

            }
            con.Close();
        }

        public DataTable getTreatment()
        {
            {
                {


                    SqlCommand cmd = new SqlCommand("SELECT * FROM Treatment", sqlcon());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;


                }
            }
        }


        public void UpdateTreatments(int id, string Name, string description)
        {

            try
            {

                string line = "Update Treatments set   Treatment_Name='" + Name + "',Description= '" + description + "'  where id= '" + id.ToString() + "'";
                SqlCommand command = new SqlCommand(line, sqlcon());
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Updated");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was updated");

            }
            con.Close();
        }
    }
}



    

