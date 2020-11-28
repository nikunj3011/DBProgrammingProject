using ComputerFields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiExample
{
    public partial class frmAddSubject : Form
    {
        public frmAddSubject()
        {
            InitializeComponent();
        }
        private FormState currentState;
        int currentRecord = 0;
        int currentSubjectId = 0;
        int firstSubjectId = 0;
        int lastSubjectId = 0;
        int? previousSubjectId;
        int? nextSubjectId;

        private void frmAddSubject_Load(object sender, EventArgs e)
        {
            LoadFirstSubject();
        }

        private void LoadFirstSubject()
        {
            var subjectId = DataAccess.GetValue("SELECT TOP (1) SubjectID FROM CSSubjects ORDER BY SubjectName");
            firstSubjectId = Convert.ToInt32(subjectId);
            currentSubjectId = firstSubjectId;
            LoadSubjectDetails();
        }

        private void LoadSubjectDetails()
        {
            //Clear any errors in the error provider
            errProvider.Clear();

            string[] sqlStatements = new string[]
            {
                $"SELECT * FROM CSSubjects WHERE SubjectID = {currentSubjectId}",
                $@"
                SELECT 
                (
                    SELECT TOP(1) SubjectID as FirstSubjectId FROM CSSubjects ORDER BY SubjectName
                ) as FirstSubjectId,
                q.PreviousSubjectId,
                q.NextSubjectId,
                (
                    SELECT TOP(1) SubjectID as LastSubjectId FROM CSSubjects ORDER BY SubjectName Desc
                ) as LastSubjectId,
                q.RowNumber
                FROM
                (
                    SELECT SubjectID, SubjectName,
                    LEAD(SubjectID) OVER(ORDER BY SubjectName) AS NextSubjectId,
                    LAG(SubjectID) OVER(ORDER BY SubjectName) AS PreviousSubjectId,
                    ROW_NUMBER() OVER(ORDER BY SubjectName) AS 'RowNumber'
                    FROM CSSubjects
                ) AS q
                WHERE q.SubjectID = {currentSubjectId}
                ORDER BY q.SubjectName".Replace(System.Environment.NewLine," "),
                "SELECT COUNT(SubjectID) as SubjectCount FROM CSSubjects"
            };


            DataSet ds = new DataSet();
            ds = DataAccess.GetDataa(sqlStatements);

            DataRow selectedSubject = ds.Tables[0].Rows[0];

            txtSubjectID.Text = selectedSubject["SubjectID"].ToString();
            txtSubjectName.Text = selectedSubject["SubjectName"].ToString();
            txtSubjectLevel.Text = selectedSubject["SubjectLevel"].ToString();
            txtDuration.Text = Convert.ToDouble(selectedSubject["Duration"]).ToString("n2");
            txtDescription.Text = selectedSubject["Descriptions"].ToString();
            txtLanguage.Text = selectedSubject["PrimaryLanguage"].ToString();

            firstSubjectId = Convert.ToInt32(ds.Tables[1].Rows[0]["FirstSubjectId"]);
            previousSubjectId = ds.Tables[1].Rows[0]["PreviousSubjectId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["PreviousSubjectId"]) : (int?)null;
            nextSubjectId = ds.Tables[1].Rows[0]["NextSubjectId"] != DBNull.Value ? Convert.ToInt32(ds.Tables["Table1"].Rows[0]["NextSubjectId"]) : (int?)null;
            lastSubjectId = Convert.ToInt32(ds.Tables[1].Rows[0]["LastSubjectId"]);
            currentRecord = Convert.ToInt32(ds.Tables[1].Rows[0]["RowNumber"]);

            //Which item we are on in the count
            label6.Text = $"Displaying Subject {currentRecord} of ?";

        }

        private void Navigation_Handler(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            label6.Text = string.Empty;

            switch (b.Name)
            {
                case "btnFirst":
                    currentSubjectId = firstSubjectId;
                    label6.Text = "The first Subject is currently displayed";
                    break;
                case "btnLast":
                    currentSubjectId = lastSubjectId;
                    label6.Text = "The last Subject is currently displayed";
                    break;
                case "btnPrevious":
                    currentSubjectId = previousSubjectId.Value;

                    if (currentRecord == 1)
                        label6.Text = "The first Subject is currently displayed";
                    break;
                case "btnNext":
                    currentSubjectId = nextSubjectId.Value;

                    break;
            }

            LoadSubjectDetails();
            NextPreviousButtonManagement();
        }

        private void NextPreviousButtonManagement()
        {
            btnPrevious.Enabled = previousSubjectId != null;
            btnNext.Enabled = nextSubjectId != null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearControls(this.grpAssignments.Controls);

            btnSave.Text = "Create";
            SetCurrentState(FormState.Add);

            NavigationState(false);

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar();

                DeleteSubject();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSubjectID.Text))
                {
                    CreateSubject();
                }
                saveSubjectChanges();
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

                DeleteSubject();

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

        private void DeleteSubject()
        {
            int rowsAffected = DeleteSubject(txtSubjectID.Text.Trim());
            if (rowsAffected == 1)

            {
                MessageBox.Show("Subject has been deleted", "Success");
                SetCurrentState(FormState.View);
                LoadFirstSubject();
            }
            else
            {
                MessageBox.Show("The data base reported no rows affected", "Something Went wrong");
            }
        }


        private void saveSubjectChanges()
        {
            int rowsAffected = SaveSubjectChanges
                ( 
                txtSubjectID.Text,
                txtSubjectName.Text.Trim(),
                txtSubjectLevel.Text.Trim(),
                txtDuration.Text.Trim(),
                txtDescription.Text.Trim(),
                txtLanguage.Text.Trim()
               );

            if (rowsAffected == 1)
            {
                MessageBox.Show("Subject Updated");
            }
            else if (rowsAffected > 1)
            {
                MessageBox.Show("More than one Subject Updated ??");
            }
            else
            {
                MessageBox.Show("Zero Subject Updated??");
            }
        }

        private void CreateSubject()
        {
            int rowsAffected = CreateNewSubject
                (
                txtSubjectName.Text.Trim(),
                txtSubjectLevel.Text.Trim(),
                txtDuration.Text.Trim(),
                txtDescription.Text.Trim(),
                txtLanguage.Text.Trim()
               );


            if (rowsAffected == 1)
            {
                MessageBox.Show("Subject Updated");
                SetCurrentState(FormState.View);
                LoadFirstSubject();

            }
            else if (rowsAffected > 1)
            {
                MessageBox.Show("More than one Subject Updated ??");
            }
            else
            {
                MessageBox.Show("Zero Subject Updated??");
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
        private void frmSubjectMaintenance_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        public int SaveSubjectChanges(
                string SubjectID,
                string SubjectName,
                string SubjectLevel,
                string Duration,
                string Description,
                string Language)
        {
            return sqlSubjectMaintenance.SaveSubjectChanges(
                Convert.ToInt32(SubjectID),
                SubjectName,
                SubjectLevel,
                Convert.ToDouble(Duration),
                Description,
                Language);
        }

        private int CreateNewSubject(
                string SubjectName,
                string SubjectLevel,
                string Duration,
                string Description,
                string Language
            )
        {
            return sqlSubjectMaintenance.CreateNewSubject(
                SubjectName,
                SubjectLevel,
                Convert.ToDouble(Duration),
                Description,
                Language);
        }

        private int DeleteSubject(string SubjectID)
        {
            return sqlSubjectMaintenance.DeleteSubject(Convert.ToInt32(SubjectID));
        }

        #endregion
    }
}