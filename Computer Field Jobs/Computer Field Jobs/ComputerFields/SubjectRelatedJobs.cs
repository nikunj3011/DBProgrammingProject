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
    public partial class SubjectRelatedJobs : Form
    {
        ComputerFields.DataAccess access = new ComputerFields.DataAccess();
        public SubjectRelatedJobs()
        {
            InitializeComponent();
        }

        private void SubjectRelatedJobs_Load(object sender, EventArgs e)
        {
            String command = "SELECT JobName,SubjectName FROM Subject_RelatedJobs SR JOIN CSSubjects sub ON sub.SubjectID = SR.SubjectID JOIN Jobs job ON job.JobID = SR.JobID ORDER BY JobName; ";
            SqlCommand sql = new SqlCommand(command);
            DataTable videoGame = access.GetDataTable(sql);

            dataGridView1.DataSource = videoGame;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoResizeColumns();
        }
    }
}
