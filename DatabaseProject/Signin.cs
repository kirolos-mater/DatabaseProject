using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Signin : Form
    {

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public Signin()
        {
            InitializeComponent();
        }

        private void Signin_Load(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmailLogin.Text;
            string userPassword = txtPasswordLogin.Text;

            if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your user email.");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your user password.");
            }
            else
            {
                string query = "Select * from Users Where Email = '" + userEmail + "' AND Password = '" +  userPassword + "'";

                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if(dtUsers.Rows.Count == 1)
                {
                    MessageBox.Show("Congratulations, you are logged in Succcessfully!");
                    objDBAccess.closeConn();


                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.");
                }
            }
        }
    }
}
