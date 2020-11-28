using mdiExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CM = System.Configuration.ConfigurationManager;

namespace ComputerFields
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            Application.Run(new SplashScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = CM.ConnectionStrings["ComputerFieldsConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "Select * from Login Where username = '" + userName.Text.Trim() + "' and password = '" + password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                MDINBCC mdishow = new MDINBCC();
                this.Hide();
                mdishow.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }
    }
}
