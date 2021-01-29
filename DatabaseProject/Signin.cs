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
        public static string id, name, email, password, country;

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

                    id = dtUsers.Rows[0]["ID"].ToString();
                    name = dtUsers.Rows[0]["Name"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();
                    country = dtUsers.Rows[0]["Country"].ToString();


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

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
