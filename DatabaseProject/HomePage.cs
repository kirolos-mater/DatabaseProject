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
    public partial class HomePage : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lblWelcomeName.Text = "Welcome " + Signin.name;
            txtNameHome.Text = Signin.name;
            txtEmailHome.Text = Signin.email;
            txtPasswordHome.Text = Signin.password;
            txtCountryHome.Text = Signin.country;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string newUserName = txtNameHome.Text;
            string newUserEmail = txtEmailHome.Text;
            string newUserPassword = txtPasswordHome.Text;
            string newUserCountry = txtCountryHome.Text;

            if(newUserName.Equals(""))
            {
                MessageBox.Show("please write your name.");
            } 
            else if (newUserEmail.Equals(""))
            {
                MessageBox.Show("please write your email.");
            } 
            else if (newUserPassword.Equals(""))
            {
                MessageBox.Show("please write your password.");
            } 
            else if (newUserCountry.Equals(""))
            {
                MessageBox.Show("please write your country.");
            }
            else
            {
                string query = "Update Users SET " +
                    "Name = '" + @newUserName + "', " +
                    "Email = '" + @newUserEmail + "', " +
                    "Password = '" + @newUserPassword + "', " +
                    "Country = '" + @newUserCountry + "' " +
                    "where ID = '" + Signin.id + "' ";

                // la @ serve a criptare

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@userName", @newUserName);
                updateCommand.Parameters.AddWithValue("@userEmail", @newUserEmail);
                updateCommand.Parameters.AddWithValue("@userPassword", @newUserPassword);
                updateCommand.Parameters.AddWithValue("@userCountry", @newUserCountry);

                int row = objDBAccess.executeQuery(updateCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Information Updated Successfully.");

                    this.Hide();
                    Signin login = new Signin();
                    login.Show();

                }
                else
                {
                    MessageBox.Show("Error Occured. Try Again.");
                }

            }


        }

        private void txtCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dialog == DialogResult.Yes)
            {
                string query = "DELETE from Users Where ID = '" + Signin.id + "' ";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objDBAccess.executeQuery(deleteCommand);

                if (row == 1)
                {
                    MessageBox.Show("Account Deleted Successfully.");

                    this.Hide();
                    Signin login = new Signin();
                    login.Show();

                }
                else
                {
                    MessageBox.Show("Error Occured. Try Again.");
                }
            }
        }
    }
}
