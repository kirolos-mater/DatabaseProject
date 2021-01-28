using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProject
{
    public partial class SignUp : Form
    {

        DBAccess dBAccess = new DBAccess();

        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userEmail = txtEmail.Text;
            string userPassword = txtPassword.Text;
            string userCountry = txtCountry.Text;

            if (userName.Equals(""))
            {
                MessageBox.Show("Please enter your user name.");
            }
            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your user email.");
            } 
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your user password.");
            }
            else if (userCountry.Equals(""))
            {
                MessageBox.Show("Please enter your user country.");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Users(Name,Email,Password,Country) values (@userName, @userEmail, @userPassword, @userCountry)");
            }

        }
    }
}
