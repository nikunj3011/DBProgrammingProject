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

namespace ComputerFields
{
    public partial class frmJobs : Form
    {
        ComputerFields.DataAccess access = new ComputerFields.DataAccess();
        public frmJobs()
        {
            InitializeComponent();
        }

        private void frmJobs_Load(object sender, EventArgs e)
        {
            String command = "SELECT * FROM Jobs";
            SqlCommand sql = new SqlCommand(command);
            DataTable videoGame = access.GetDataTable(sql);

            dataGridView1.DataSource = videoGame;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
        }
    }
}
