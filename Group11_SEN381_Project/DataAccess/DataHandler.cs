﻿using System;
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

        // update the client details
        public void updateClient(int id, string name_surname, string address, string phone_number, string email, string dependents, int national_id)
        {
            con.Open();
            try
            {

                string line = "Update Client set  Name_Surname='" + name_surname + "',address= '" + address + "', phone_number='" + phone_number + "',Email='" + email + "',Dependents=  '" + dependents + "',National_id=  '" + national_id + "' where id= '" + id.ToString() + "'";
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
        public void CreateClient(int id,string name_surname, string address, string phone_number, string email, string dependents, int national_id)
        {
            con.Open();
            try
            {
                string line = "INSERT INTO Client (id,Name_Surname,Address,Phone_Number,Email,Dependents,National_id) VALUES ('"+ id+"','" + name_surname + "','" + address + "','" + phone_number + "','" + email + "','" + dependents + "','" + national_id + "')";
                SqlCommand command = new SqlCommand(line, con);// this will execute the command
                command.ExecuteNonQuery();
                con.Close();// this will close the connection
            }
            catch (Exception ex)// catch any errors
            {
                MessageBox.Show("Data Failed to be Inserted");// show message box
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was Inserted");// show message box if data was inserted

            }
            con.Close();
        }

        //TODO: CREATE DELETE METHOD FOR CLIENT

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
        public void UpdatePolicy(int id, string desc, string date_time, string type_of_policy, int fee, int expired)
        {
            con.Open();
            try
            {

                string line = "Update Policy set description='" + desc + "',Date_Time= '" + date_time + "', Type_of_Policy='" + type_of_policy + "',Fee='" + fee.ToString() + "',expired=  '" + expired.ToString() + "' where id= '" + id.ToString() + "'";
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

        // create a new policy and insert it into the database
        public void CreatePolicy(int id,string desc, string date_time, string type_of_policy,int fee, int expired)
        {
            con.Open();
            try
            {

                string line = "INSERT INTO Policy (id,description,Date_Time,Type_of_Policy,Fee,expired) VALUES ('"+ id+ "','" + desc + "','" + date_time + "','" + type_of_policy + "','" + fee.ToString() + "','" + expired.ToString() + "')";
                SqlCommand command = new SqlCommand(line, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Failed to be Created");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Data was created!");

            }
            con.Close();
        }

        //TODO: CREATE DELETE METHOD FOR POLICY

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
        public void UpdateProvider(int id, string Name, string Location, int rating)
        {

            try
            {

                string line = "Update Providers set Name='" + Name + "',Location= '" + Location + "', Rating='" + rating.ToString() + "' where id= '" + id.ToString() + "'";
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

        // create a new medical provider and insert it into the database
        public void CreateProvider(int id,string Name, string Location, int rating)
        {
            con.Open();
            try
            {

                string line = "INSERT INTO Providers (id,Name,Location,Rating) VALUES ('"+ id +"','" + Name + "','" + Location + "','" + rating.ToString() + "')";
                SqlCommand command = new SqlCommand(line, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create Provider");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Provider record was successfully created!");

            }
            con.Close();
        }

        //TODO: CREATE DELETE METHOD FOR PROVIDER

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
        public void UpdateMedicalConditions(int id, string Name, string description)
        {

            try
            {

                string line = "Update Medical_Conditions set Condition_Name='" + Name + "',Description= '" + description + "'  where id= '" + id.ToString() + "'";
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

        //create a new medical condition and insert it into the database
        public void CreateMedicalConditions(int id,string Name, string description)
        {
            con.Open();
            try
            {

                string line = "INSERT INTO Medical_Conditions (id,Condition_Name,Description) VALUES ('" +id+"','"+ Name + "','" + description + "')";
                SqlCommand command = new SqlCommand(line, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create Medical Condition");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Medical Condition record was successfully created!");

            }
            con.Close();
        }

        //TODO: CREATE DELETE METHOD FOR MEDICAL CONDITION

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
        public void UpdateTreatments(int id, string Name, string description)
        {

            try
            {

                string line = "Update Treatments set Treatment_Name='" + Name + "',Description= '" + description + "'  where id= '" + id.ToString() + "'";
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

        // create a new treatment and insert it into the database
        public void CreateTreatments(int id,string Name, string description)
        {
            con.Open();
            try
            {

                string line = "INSERT INTO Treatments (id,Treatment_Name,Description) VALUES ('" +id+ "','"+Name + "','" + description + "')";
                SqlCommand command = new SqlCommand(line, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create Treatment");
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                MessageBox.Show("Treatment record was successfully created!");

            }
            con.Close();
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



    

