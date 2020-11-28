namespace mdiExample
{
    partial class frmAddSubject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpAssignments = new System.Windows.Forms.GroupBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtSubjectLevel = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStrip();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAssignments
            // 
            this.grpAssignments.Controls.Add(this.txtSubjectID);
            this.grpAssignments.Controls.Add(this.label7);
            this.grpAssignments.Controls.Add(this.label6);
            this.grpAssignments.Controls.Add(this.txtDuration);
            this.grpAssignments.Controls.Add(this.txtSubjectLevel);
            this.grpAssignments.Controls.Add(this.txtLanguage);
            this.grpAssignments.Controls.Add(this.label5);
            this.grpAssignments.Controls.Add(this.txtDescription);
            this.grpAssignments.Controls.Add(this.label4);
            this.grpAssignments.Controls.Add(this.btnCancel);
            this.grpAssignments.Controls.Add(this.btnAdd);
            this.grpAssignments.Controls.Add(this.btnDelete);
            this.grpAssignments.Controls.Add(this.btnSave);
            this.grpAssignments.Controls.Add(this.label3);
            this.grpAssignments.Controls.Add(this.label1);
            this.grpAssignments.Controls.Add(this.btnLast);
            this.grpAssignments.Controls.Add(this.btnFirst);
            this.grpAssignments.Controls.Add(this.btnPrevious);
            this.grpAssignments.Controls.Add(this.btnNext);
            this.grpAssignments.Controls.Add(this.txtSubjectName);
            this.grpAssignments.Controls.Add(this.label2);
            this.grpAssignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAssignments.Location = new System.Drawing.Point(109, 42);
            this.grpAssignments.Margin = new System.Windows.Forms.Padding(4);
            this.grpAssignments.Name = "grpAssignments";
            this.grpAssignments.Padding = new System.Windows.Forms.Padding(4);
            this.grpAssignments.Size = new System.Drawing.Size(574, 595);
            this.grpAssignments.TabIndex = 9;
            this.grpAssignments.TabStop = false;
            this.grpAssignments.Text = "Subjects";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(41, 255);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(455, 23);
            this.txtDuration.TabIndex = 37;
            this.txtDuration.Tag = "Term";
            // 
            // txtSubjectLevel
            // 
            this.txtSubjectLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectLevel.Location = new System.Drawing.Point(38, 191);
            this.txtSubjectLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectLevel.Name = "txtSubjectLevel";
            this.txtSubjectLevel.Size = new System.Drawing.Size(455, 23);
            this.txtSubjectLevel.TabIndex = 36;
            this.txtSubjectLevel.Tag = "Term";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage.Location = new System.Drawing.Point(38, 385);
            this.txtLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(455, 23);
            this.txtLanguage.TabIndex = 35;
            this.txtLanguage.Tag = "Term";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Primary Language:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(38, 321);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(455, 23);
            this.txtDescription.TabIndex = 33;
            this.txtDescription.Tag = "Term";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Description:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(389, 499);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 58);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(41, 499);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 58);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(157, 499);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 58);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(273, 499);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 58);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Duration:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "SubjectLevel:";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(389, 439);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(108, 53);
            this.btnLast.TabIndex = 22;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(41, 439);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(108, 53);
            this.btnFirst.TabIndex = 21;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(157, 439);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(108, 53);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(273, 439);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 53);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(38, 134);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(455, 23);
            this.txtSubjectName.TabIndex = 1;
            this.txtSubjectName.Tag = "Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "SubjectName: ";
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatusLabel1.Location = new System.Drawing.Point(0, 0);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(764, 31);
            this.toolStripStatusLabel1.TabIndex = 10;
            this.toolStripStatusLabel1.Text = "toolStrip1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectID.Location = new System.Drawing.Point(38, 77);
            this.txtSubjectID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.ReadOnly = true;
            this.txtSubjectID.Size = new System.Drawing.Size(455, 23);
            this.txtSubjectID.TabIndex = 39;
            this.txtSubjectID.Tag = "Term";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "SubjectID: ";
            // 
            // frmAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(764, 650);
            this.Controls.Add(this.toolStripStatusLabel1);
            this.Controls.Add(this.grpAssignments);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Subjects";
            this.Load += new System.EventHandler(this.frmAddSubject_Load);
            this.grpAssignments.ResumeLayout(false);
            this.grpAssignments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox grpAssignments;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtSubjectLevel;
        private System.Windows.Forms.ToolStrip toolStripStatusLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.Label label7;
    }
}