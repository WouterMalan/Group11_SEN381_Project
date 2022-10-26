﻿using Group11_SEN381_Project.DataAccess;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11_SEN381_Project.Presentation
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            
        }

        private void Client_Load(object sender, EventArgs e)
        {
            clientTabSelected();
        }

        public void clientTabSelected()
        {
            DataHandler dataHandler = new DataHandler();

            //the listview of the client tab
            materialListView1.Items.Clear();
            foreach (DataRow row in dataHandler.getClient().Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["Name_Surname"].ToString());
                item.SubItems.Add(row["Address"].ToString());
                item.SubItems.Add(row["Phone_Number"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Dependents"].ToString());
                item.SubItems.Add(row["National_id"].ToString());
                materialListView1.Items.Add(item);
            }
            //display the selected listview item in the textboxes
            materialListView1.SelectedIndexChanged += (s, args) =>
            {
                if (materialListView1.SelectedItems.Count > 0)
                {
                    ListViewItem item = materialListView1.SelectedItems[0];
                    txtBoxId.Text = item.SubItems[0].Text;
                    txtBoxFullName.Text = item.SubItems[1].Text;
                    txtBoxAddress.Text = item.SubItems[2].Text;
                    txtBoxPhoneNumber.Text = item.SubItems[3].Text;
                    txtBoxEmail.Text = item.SubItems[4].Text;
                    txtBoxDependents.Text = item.SubItems[5].Text;
                    txtBoxNationalId.Text = item.SubItems[6].Text;

                }
            };
            materialListView1.GridLines = false;
            materialListView1.FullRowSelect = true;
            materialListView1.MultiSelect = false;
            materialListView1.View = View.Details;
        }
    }
}