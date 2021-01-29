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
    public partial class CommandBuilderForm : Form
    {

        DBAccess objDbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public CommandBuilderForm()
        {
            InitializeComponent();
        }

        private void CommandBuilderForm_Load(object sender, EventArgs e)
        {
            string query = "Select * from Users";

            objDbAccess.readDatathroughAdapter(query, dtUsers);

            dataGridView1.DataSource = dtUsers;

            objDbAccess.closeConn();

        }

        private void performOperBtn_Click(object sender, EventArgs e)
        {
            string query = "Select * from Users";

            int changes = objDbAccess.executeDataAdapter(dtUsers, query);

            MessageBox.Show("count: " + changes);
        }
    }
}
