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
using Group11_SEN381_Project.BusinessLogic;
using System.Security.Policy;

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
        //get all the client details
        public DataTable getClient()
        {
            {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("ViewClient", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;// this will call the stored procedure
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


        // update the client details
        public void updateClient(Client client)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UpdateClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", client.ID);
                cmd.Parameters.AddWithValue("@Name_Surname", client.FullName);
                cmd.Parameters.AddWithValue("@Address", client.Address);
                cmd.Parameters.AddWithValue("@Phone_Number", client.PhoneNum);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@Dependents", client.Dependants);
                cmd.Parameters.AddWithValue("@National_id", client.NatID);
                cmd.Parameters.AddWithValue("@Policy_ID", client.PolicyID);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        //search for a client by their id
        public DataTable searchClient(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Client WHERE id = '" + id.ToString() + "'", con);
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }


        // add a new client to the database
        public void CreateClient(Client client)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", client.ID);
                cmd.Parameters.AddWithValue("@Name_Surname", client.FullName);
                cmd.Parameters.AddWithValue("@Address", client.Address);
                cmd.Parameters.AddWithValue("@Phone_Number", client.PhoneNum);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@Dependents", client.Dependants);
                cmd.Parameters.AddWithValue("@National_id", client.NatID);
                cmd.Parameters.AddWithValue("@Policy_ID", client.PolicyID);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create client");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Client created successfully");
            }
        }

        // delete a client from the database
        public void DeleteClient(Client client)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DeleteClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", client.ID);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete client");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Client deleted successfully");
            }
        }
    
            
   

        // get all the policy details
        public DataTable getPolicy()
        {

            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("ViewPolicy", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;// this will call the stored procedure
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }
    
        
        // update the policy details
        public void UpdatePolicy(PolicyBL policy)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UpdatePolicy", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", policy.PolicyID1);
                cmd.Parameters.AddWithValue("@description", policy.Description1);
                cmd.Parameters.AddWithValue("@Date_Time", policy.StartDate1);
                cmd.Parameters.AddWithValue("@Importance", policy.Importance1);
                cmd.Parameters.AddWithValue("@Fee", policy.Fee1);
                cmd.Parameters.AddWithValue("@expired", policy.Expired1);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update policy");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Policy updated successfully");
                
            }
        }

        // create a new policy and insert it into the database
       public void CreatePolicy(PolicyBL policy)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertPolicy", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", policy.PolicyID1);
                cmd.Parameters.AddWithValue("@description", policy.Description1);
                cmd.Parameters.AddWithValue("@Date_Time", policy.StartDate1);
                cmd.Parameters.AddWithValue("@Importance", policy.Importance1);
                cmd.Parameters.AddWithValue("@Fee", policy.Fee1);
                cmd.Parameters.AddWithValue("@expired", policy.Expired1);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to create policy");
            }
            finally
            {
                MessageBox.Show("Policy created successfully");
            }
        }

        // delete a policy from the database
        public void DeletePolicy(PolicyBL policy)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DeletePolicy", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", policy.PolicyID1);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to delete policy");
            }
            finally
            {
                MessageBox.Show("Policy deleted successfully");
            }
        }

        //search the policy by ID
        public DataTable searchPolicy(int id)
        {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Policy WHERE id = '" + id.ToString() + "'", con);
                    sda.Fill(dt);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return dt;
        }

        // get all the medical provider details
        public DataTable getProvider()
        {
            {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("ViewProviders", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;// this will call the stored procedure
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

        // update the medical provider details
        public void UpdateProvider(Provider provider)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UpdateProvider", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", provider.ProviderID);
                cmd.Parameters.AddWithValue("@Name", provider.ProvName);
                cmd.Parameters.AddWithValue("@Location", provider.Location);
                cmd.Parameters.AddWithValue("@Rating", provider.Rating);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update provider");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Provider updated successfully");
            }
        }

        // create a new medical provider and insert it into the database
        public void CreateProvider(Provider provider)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertProviders", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", provider.ProviderID);
                cmd.Parameters.AddWithValue("@Name", provider.ProvName);
                cmd.Parameters.AddWithValue("@Location", provider.Location);
                cmd.Parameters.AddWithValue("@Rating", provider.Rating);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create provider");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Provider created successfully");
            }
        }

        // delete a medical provider from the database
        public void DeleteProvider(Provider provider)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DeleteProviders", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", provider.ProviderID);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete provider");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Provider deleted successfully");
            }
        }

        public DataTable searchProvider(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Providers WHERE id = '" + id.ToString() + "'", con);
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        // get all the medical condition details
        public DataTable getMedicalCondition()
        {
            {
                {

                    //TODO: DOUBLE CHECK NAME OF PROCEDURE
                    DataTable dt = new DataTable();
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("ViewMdicalConditions", con);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;// this will call the stored procedure
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
        }

        // update the medical condition details
        public void UpdateMedicalConditions(Medical_Condition medicalCondition)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UpdateMedicalConditions", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", medicalCondition.ConditionID);
                cmd.Parameters.AddWithValue("@Condition_Name", medicalCondition.ConditionName1);
                cmd.Parameters.AddWithValue("@Priority", medicalCondition.Priority1);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update medical condition");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Medical condition updated successfully");
            }
        }

        //create a new medical condition and insert it into the database
        public void CreateMedicalConditions(Medical_Condition medicalCondition)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertMedicalConditions", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", medicalCondition.ConditionID);
                cmd.Parameters.AddWithValue("@Condition_Name", medicalCondition.ConditionName1);
                cmd.Parameters.AddWithValue("@Priority", medicalCondition.Priority1);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create medical condition");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Medical condition created successfully");
            }
        }

        // delete a medical condition from the database
        public void DeleteMedicalCondition(Medical_Condition medicalCondition)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DeleteMedicalConditions", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", medicalCondition.ConditionID);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete medical condition");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Medical condition deleted successfully");
            }
        }

        //search medical condition by ID
        public DataTable searchMedicalCondition(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Medical_Conditions WHERE id = '" + id.ToString() + "'", con);
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            return dt;
        }

        // get all the treatment details
        public DataTable getTreatment()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("ViewTreatments", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;// this will call the stored procedure
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        // update the treatment details
        public void UpdateTreatments(Treatment treatment)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UpdateTreatments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", treatment.TreatmentID);
                cmd.Parameters.AddWithValue("@Treatment_Name", treatment.TreatmentName);
                cmd.Parameters.AddWithValue("@Level", treatment.Level);
                cmd.Parameters.AddWithValue("@Days", treatment.Days);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update treatment");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Treatment updated successfully");
            }
        }

        // create a new treatment and insert it into the database
        public void CreateTreatments(Treatment treatment)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertTreatments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", treatment.TreatmentID);
                cmd.Parameters.AddWithValue("@Treatment_Name", treatment.TreatmentName);
                cmd.Parameters.AddWithValue("@Level", treatment.Level);
                cmd.Parameters.AddWithValue("@Days", treatment.Days);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create treatment");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Treatment created successfully");
            }
        }

        //search for treatment by ID
        public DataTable searchTreatment(int id)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Treatments WHERE id = '" + id.ToString() + "'", sqlcon());
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        //TODO: CREATE DELETE METHOD FOR TREATMENTS
        public void DeleteTreatment(Treatment treatment)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DeleteTreatments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", treatment.TreatmentID);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete treatment");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Treatment deleted successfully");
            }
        }

        //get all the report details
        public DataTable getReport()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("ViewReport", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;// this will call the stored procedure
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        //update the report details
        public void UpdateReport(Report report)
        {
            try
            {
                con.Open();
                // use the stored procedure name to update the report
                SqlCommand cmd = new SqlCommand("UpdateReport", con);// stored procedure name
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", report.Id);
                cmd.Parameters.AddWithValue("@Client_ID", report.Client_ID);
                cmd.Parameters.AddWithValue("@MC_ID", report.McID);
                cmd.Parameters.AddWithValue("@Policy_ID", report.Policy_ID);
                cmd.Parameters.AddWithValue("@ETimeStamp", report.ETimeStamp);
                cmd.Parameters.AddWithValue("@STimeStamp", report.STimeStamp);
                cmd.Parameters.AddWithValue("@Claim", report.Claim);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update report");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Report updated successfully");
            }
        }

        // create a new report and insert it into the database
        public void CreateReport(Report report)
        {
            try
            {
                con.Open();
                // use the stored procedure name to create the report
                SqlCommand cmd = new SqlCommand("InsertReport", con);// stored procedure name
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", report.Id);
                cmd.Parameters.AddWithValue("@Client_ID", report.Client_ID);
                cmd.Parameters.AddWithValue("@MC_ID", report.McID);
                cmd.Parameters.AddWithValue("@Policy_ID", report.Policy_ID);
                cmd.Parameters.AddWithValue("@ETimeStamp", report.ETimeStamp);
                cmd.Parameters.AddWithValue("@STimeStamp", report.STimeStamp);
                cmd.Parameters.AddWithValue("@Claim", report.Claim);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create report");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Report created successfully");
            }
        }

        // delete a report from the database
        public void DeleteReport(Report report)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DeleteReport", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", report.Id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete report");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("Report deleted successfully");
            }
        }
    }
}



    

