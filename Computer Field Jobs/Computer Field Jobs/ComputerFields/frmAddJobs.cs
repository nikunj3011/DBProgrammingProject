using ComputerFields.sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerFields
{
    public partial class frmAddJobs : Form
    {
        private IJobRepo jobRepo;
        public frmAddJobs()
        {
            InitializeComponent();
            jobRepo = JobFactory.jobRepo();
        }
        private FormState currentState;
        int currentRecord = 0;
        int currentJobId = 0;
        int firstJobId = 0;
        int lastJobId = 0;
        int? previousJobId;
        int? nextJobId;

        private void frmAddJobs_Load(object sender, EventArgs e)
        { 
            LoadFirstJob();
        }

        private void LoadFirstJob()
        {
            int JobId = jobRepo.GetFirstJob();
            firstJobId = Convert.ToInt32(JobId);
            currentJobId = firstJobId;
            LoadJobDetails();
        }

        private void LoadJobDetails()
        {
            //Clear any errors in the error provider
            //errProvider.Clear();
            DataSet ds = new DataSet();
            ds = jobRepo.statements(currentJobId);

            DataRow selectedJob = ds.Tables[0].Rows[0];

            txtJobID.Text = selectedJob["JobID"].ToString();
            txtJobName.Text = selectedJob["JobName"].ToString();
            txtJobLevel.Text = selectedJob["JobLevel"].ToString();
            txtEstimatedPay.Text = Convert.ToDouble(selectedJob["EstimatedPay"]).ToString("n2");
            txtType.Text = selectedJob["Typee"].ToString();
            txtDescription.Text = selectedJob["Descriptions"].ToString();

            firstJobId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstJobId"]);
            previousJobId = ds.Tables[1].Rows[0]["PreviousJobId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousJobId"]) : (int?)null;
            nextJobId = ds.Tables[1].Rows[0]["NextJobId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextJobId"]) : (int?)null;
            lastJobId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastJobId"]);
            currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);

            //Which item we are on in the count
            label6.Text = $"Displaying product {currentRecord} of ?";

        }

        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            label6.Text = string.Empty;

            switch (b.Name)
            {
                case "btnFirst":
                    currentJobId = firstJobId;
                    label6.Text = "The first Job is currently displayed";
                    break;
                case "btnLast":
                    currentJobId = lastJobId;
                    label6.Text = "The last Job is currently displayed";
                    break;
                case "btnPrevious":
                    currentJobId = previousJobId.Value;

                    if (currentRecord == 1)
                        label6.Text = "The first Job is currently displayed";
                    break;
                case "btnNext":
                    currentJobId = nextJobId.Value;

                    break;
            }

            LoadJobDetails();
            NextPreviousButtonManagement();
        }

        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousJobId != null;
            btnNext.Enabled = nextJobId != null;
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            ClearControls(this.grpAssignments.Controls);

            btnSave.Text = "Create";
            SetCurrentState(FormState.Add);

            NavigationState(false);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                ProgressBar();

                DeleteJob();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtJobID.Text))
                {
                    CreateJob();
                }
                saveJobChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            NavigationState(true);
        }  

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar();

                DeleteJob();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void SetCurrentState(FormState formState)
        {
            currentState = formState;
            LoadCurrentState(formState);
        }

        private void LoadCurrentState(FormState formState)
        {

            switch (formState)
            {
                case FormState.View:
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    btnSave.Enabled = true;
                    break;

                case FormState.Add:
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnSave.Enabled = true;
                    break;

            }

        }

        /// <summary>
        /// Helper method to set state of all nav buttons
        /// </summary>
        /// <param name="enableState"></param>
        private void NavigationState(bool enableState)
        {
            btnFirst.Enabled = enableState;
            btnLast.Enabled = enableState;
            btnNext.Enabled = enableState;
            btnPrevious.Enabled = enableState;
        }

        #region [NoQuery Execution]

        private void DeleteJob()
        {
            int rowsAffected = DeleteJob(txtJobID.Text.Trim());
            if (rowsAffected == 1)

            {
                MessageBox.Show("Job has been deleted", "Success");
                SetCurrentState(FormState.View);
                LoadFirstJob();
            }
            else
            {
                MessageBox.Show("The data base reported no rows affected", "Something Went wrong");
            }
        }


        private void saveJobChanges()
        {
            int rowsAffected = SaveJobChanges
                (
                txtJobID.Text,
                txtJobName.Text.Trim(),
                txtJobLevel.Text.Trim(),
                txtEstimatedPay.Text.Trim(),
                txtType.Text.Trim(),
                txtDescription.Text.Trim()
               );

            if (rowsAffected == 1)
            {
                MessageBox.Show("Job Updated");
            }
            else if (rowsAffected > 1)
            {
                MessageBox.Show("More than one Job Updated ??");
            }
            else
            {
                MessageBox.Show("Zero Job Updated??");
            }
        }

        private void CreateJob()
        {
            int rowsAffected = CreateNewJob
                ( 
                txtJobName.Text.Trim(),
                txtJobLevel.Text.Trim(),
                txtEstimatedPay.Text.Trim(),
                txtType.Text.Trim(),
                txtDescription.Text.Trim()
               );


            if (rowsAffected == 1)
            {
                MessageBox.Show("Job Updated");
                SetCurrentState(FormState.View);
                LoadFirstJob();

            }
            else if (rowsAffected > 1)
            {
                MessageBox.Show("More than one Job Updated ??");
            }
            else
            {
                MessageBox.Show("Zero Job Updated??");
            }
        }

        #endregion

        #region [Validation Events and Methods]

        /// <summary>
        /// ComboBox Validating Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string cmbName = cmb.Tag.ToString();

            string errMsg = null;
            bool failedValidation = false;

            if (cmb.SelectedIndex == -1 || String.IsNullOrEmpty(cmb.SelectedValue.ToString()))
            {
                errMsg = $"{cmbName} is required";
                failedValidation = true;
            }

            e.Cancel = failedValidation;
            errProvider.SetError(cmb, errMsg);
        }

        /// <summary>
        /// TextBox Validating event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string txtBoxName = txt.Tag.ToString();
            string errMsg = null;
            bool failedValidation = false;

            if (txt.Text == string.Empty)
            {
                errMsg = $"{txtBoxName} is required";
                failedValidation = true;
            }

            if (txt.Name == "txtUnitPrice"
                || txt.Name == "txtStock"
                || txt.Name == "txtOnOrder"
                || txt.Name == "txtReorder"
            )
            {
                if (!IsNumeric(txt.Text))
                {
                    errMsg = $"{txtBoxName} is required";
                    failedValidation = true;
                }
            }

            e.Cancel = failedValidation;

            errProvider.SetError(txt, errMsg);
        }

        /// <summary>
        /// Numeric validation 
        /// </summary>
        /// <param name="value">The value to validate</param>
        /// <returns>The result of the validation</returns>
        private bool IsNumeric(string value)
        {
            return Double.TryParse(value, out double a);
        }

        #endregion

        #region [Form Helpers]

        /// <summary>
        /// Clear the form inputs and set checkbox unchecked
        /// </summary>
        /// <param name="controls">Controls collection to clear</param>
        private void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                switch (ctl)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case GroupBox gB:
                        ClearControls(gB.Controls);
                        break;
                }
            }
        }

        /// <summary>
        /// Animate the progress bar
        /// This is ui thread blocking. Ok for this application.
        /// </summary>
        private void ProgressBar()
        {
            this.label6.Refresh();
            this.label6.Text = "Processed";
        }

        /// <summary>
        /// Allow an invalid form to close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmJobMaintenance_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        public int SaveJobChanges(
                string JobID,
                string JobName,
                string JobLevel,
                string EstimatedPay,
                string Type,
                string Description)
        {
            return jobRepo.SaveJobChanges(
                Convert.ToInt32(JobID),
                JobName,
                JobLevel,
                Convert.ToDouble(EstimatedPay),
                Type,
                Description);
        }

        private int CreateNewJob(
                string JobName,
                string JobLevel,
                string EstimatedPay,
                string Type,
                string Description
            )
        {
            return jobRepo.CreateNewJob( 
                JobName,
                JobLevel,
                Convert.ToDouble(EstimatedPay),
                Type,
                Description);
        }

        private int DeleteJob(string JobID)
        {
            return jobRepo.DeleteJob(Convert.ToInt32(JobID));
        }

        #endregion

    }
}
    