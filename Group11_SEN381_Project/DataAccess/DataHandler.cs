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

        //TODO: ADD POLICY_ID FIELD!!!!!
        // update the client details
        public void updateClient(Client client)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Client SET Name_Surname = @FullName, Address = @Address, Phone_Number = @PhoneNum, Email = @Email, Dependants = @Dependants, National_id = @NatID WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", client.ID);
                cmd.Parameters.AddWithValue("@FullName", client.FullName);
                cmd.Parameters.AddWithValue("@Address", client.Address);
                cmd.Parameters.AddWithValue("@PhoneNum", client.PhoneNum);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@Dependants", client.Dependants);
                cmd.Parameters.AddWithValue("@NatID", client.NatID);
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
        //TODO: Add Policy_ID field!!!!!!
        public void CreateClient(Client client)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Client (Name_Surname, Address, Phone_Number, Email, Dependants, National_id) VALUES (@FullName, @Address, @PhoneNum, @Email, @Dependants, @NatID)", con);
                cmd.Parameters.AddWithValue("@FullName", client.FullName);
                cmd.Parameters.AddWithValue("@Address", client.Address);
                cmd.Parameters.AddWithValue("@PhoneNum", client.PhoneNum);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@Dependants", client.Dependants);
                cmd.Parameters.AddWithValue("@NatID", client.NatID);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Client WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", client.ID);
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

            // this function will run and send a full view of the respective table in a data table format 
            SqlCommand cmd = new SqlCommand("SELECT * FROM Policy", sqlcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    
        
        // update the policy details
        public void UpdatePolicy(PolicyBL policy)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Policy SET description = @Description, Date_Time = @StartDate, Importance = @Importance, Fee = @Fee, expired = @Expired WHERE id = @PolicyID", con);
                cmd.Parameters.AddWithValue("@PolicyID", policy.PolicyID1);
                cmd.Parameters.AddWithValue("@Description", policy.Description1);
                cmd.Parameters.AddWithValue("@StartDate", policy.StartDate1);
                cmd.Parameters.AddWithValue("@Importance", policy.Importance1);
                cmd.Parameters.AddWithValue("@Fee", policy.Fee1);
                cmd.Parameters.AddWithValue("@Expired", policy.Expired1);
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Policy (description, Date_Time, Importance, Fee, expired) " +
                    "VALUES (@Description, @StartDate, @Importance, @Fee, @Expired)", con);
                cmd.Parameters.AddWithValue("@Description", policy.Description1);
                cmd.Parameters.AddWithValue("@StartDate", policy.StartDate1);
                cmd.Parameters.AddWithValue("@Importance", policy.Importance1);
                cmd.Parameters.AddWithValue("@Fee", policy.Fee1);
                cmd.Parameters.AddWithValue("@Expired", policy.Expired1);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Policy WHERE id = @PolicyID", con);
                cmd.Parameters.AddWithValue("@PolicyID", policy.PolicyID1);
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Providers", sqlcon());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
        }

        // update the medical provider details
        public void UpdateProvider(Provider provider)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Providers SET Name = @Name, Location = @Location, Rating = @Rating WHERE id = @ProviderID", con);
                cmd.Parameters.AddWithValue("@ProviderID", provider.ProviderID);
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Providers (Name, Location, Rating) " +
                    "VALUES (@Name, @Location, @Rating)", con);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Providers WHERE id = @ProviderID", con);
                cmd.Parameters.AddWithValue("@ProviderID", provider.ProviderID);
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


                    SqlCommand cmd = new SqlCommand("SELECT * FROM Medical_Conditions", sqlcon());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
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
                SqlCommand cmd = new SqlCommand("UPDATE Medical_Conditions SET Condition_Name = @Name, Priority = @Priority, Treatment = @Treatment WHERE id = @MedicalConditionID", con);
                cmd.Parameters.AddWithValue("@MedicalConditionID", medicalCondition.ConditionID);
                cmd.Parameters.AddWithValue("@Name", medicalCondition.ConditionName1);
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Medical_Conditions (Condition_Name, Priority) " +
                    "VALUES (@Name, @Priority)", con);
                cmd.Parameters.AddWithValue("@Name", medicalCondition.ConditionName1);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Medical_Conditions WHERE id = @MedicalConditionID", con);
                cmd.Parameters.AddWithValue("@MedicalConditionID", medicalCondition.ConditionID);
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
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Treatments", sqlcon());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;


                }
        }

        // update the treatment details
        public void UpdateTreatments(Treatment treatment)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Treatments SET Treatment_Name = @Name, Level = @Level, Days = @Days WHERE id = @TreatmentID", con);
                cmd.Parameters.AddWithValue("@TreatmentID", treatment.TreatmentID);
                cmd.Parameters.AddWithValue("@Name", treatment.TreatmentName);
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Treatments (Treatment_Name, Level, Days) " +
                    "VALUES (@Name, @Level, @Days)", con);
                cmd.Parameters.AddWithValue("@Name", treatment.TreatmentName);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Treatments WHERE id = @TreatmentID", con);
                cmd.Parameters.AddWithValue("@TreatmentID", treatment.TreatmentID);
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
            


                    SqlCommand cmd = new SqlCommand("SELECT * FROM Report", sqlcon());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
        }

        //TODO: update the report details

        //TODO: Create the report details

        //TODO: Delete the report details
    }
}



    

