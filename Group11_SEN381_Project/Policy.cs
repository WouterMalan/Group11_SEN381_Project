using Group11_SEN381_Project.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11_SEN381_Project
{
    public partial class Policy : Form
    {
        public Policy()
        {
            InitializeComponent();
        }

        private void Policy_Load(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            dataGridView1.DataSource = dataHandler.getPolicy();//getPolicy() is a method in DataHandler.cs
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit button
            this.Close();
        }
    }
}
