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
    public partial class frmSubjects : Form
    {
        ComputerFields.DataAccess access = new ComputerFields.DataAccess();
        public frmSubjects()
        {
            InitializeComponent();
        }

        private void frmSubjects_Load(object sender, EventArgs e)
        {
            String command = "SELECT * FROM CSSubjects";
            SqlCommand sql = new SqlCommand(command);
            DataTable videoGame = access.GetDataTable(sql);

            dataGridView1.DataSource = videoGame;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
        }
    }
}
