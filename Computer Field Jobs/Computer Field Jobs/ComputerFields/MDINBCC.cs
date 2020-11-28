using ComputerFields;
using System;
using System.Windows.Forms;

namespace mdiExample
{
    public partial class MDINBCC : Form
    {
        public MDINBCC()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
           

            var m = (ToolStripMenuItem)sender;

            Form childForm = GetLinkedChildForm(m);
            

            if(childForm != null)
            {
                foreach(Form f in MdiChildren)
                {
                   
                    if (IsSameFormType(f, childForm))
                    {
                        f.Activate();
                        return;
                    }
                }
            }

            childForm.MdiParent = this;
            childForm.Show();
        }

        private Form GetLinkedChildForm(ToolStripMenuItem m)
        {
            Form childForm = null;
           switch (m.Tag) 
            {
                case "addSubjects":
                    childForm = new frmAddSubject();
                    break;
                case "addJobs":
                    childForm = new frmAddJobs();
                    break;
                case "about":
                    childForm = new about();
                    break;
                case "browseSubjects":
                    childForm = new frmSubjects();
                    break;
                case "browseJobs":
                    childForm = new frmJobs();
                    break;                    
                case "subjectRelatedJobs":
                    childForm = new SubjectRelatedJobs();
                    break;

            }
            return childForm;
        }

        private bool IsSameFormType(Form f, Form childForm)
        {
           return f.GetType() == childForm.GetType();
        }


        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Form childForm = null;
        //    childForm = new frmAssignments();
        //    childForm.Show();
        //}
    }
}
