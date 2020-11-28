namespace ComputerFields
{
    partial class frmAddJobs
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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStrip();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtEstimatedPay = new System.Windows.Forms.TextBox();
            this.txtJobLevel = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpAssignments = new System.Windows.Forms.GroupBox();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.grpAssignments.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatusLabel1.Location = new System.Drawing.Point(0, 0);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(774, 25);
            this.toolStripStatusLabel1.TabIndex = 12;
            this.toolStripStatusLabel1.Text = "toolStrip1";
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // txtEstimatedPay
            // 
            this.txtEstimatedPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstimatedPay.Location = new System.Drawing.Point(56, 238);
            this.txtEstimatedPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstimatedPay.Name = "txtEstimatedPay";
            this.txtEstimatedPay.Size = new System.Drawing.Size(455, 23);
            this.txtEstimatedPay.TabIndex = 37;
            this.txtEstimatedPay.Tag = "Term";
            // 
            // txtJobLevel
            // 
            this.txtJobLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobLevel.Location = new System.Drawing.Point(53, 174);
            this.txtJobLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobLevel.Name = "txtJobLevel";
            this.txtJobLevel.Size = new System.Drawing.Size(455, 23);
            this.txtJobLevel.TabIndex = 36;
            this.txtJobLevel.Tag = "Term";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(53, 368);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(455, 23);
            this.txtDescription.TabIndex = 35;
            this.txtDescription.Tag = "Term";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(53, 304);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(455, 23);
            this.txtType.TabIndex = 33;
            this.txtType.Tag = "Term";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Type:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(404, 482);
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
            this.btnAdd.Location = new System.Drawing.Point(56, 482);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 58);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(172, 482);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 58);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // grpAssignments
            // 
            this.grpAssignments.Controls.Add(this.txtJobID);
            this.grpAssignments.Controls.Add(this.label7);
            this.grpAssignments.Controls.Add(this.label6);
            this.grpAssignments.Controls.Add(this.txtEstimatedPay);
            this.grpAssignments.Controls.Add(this.txtJobLevel);
            this.grpAssignments.Controls.Add(this.txtDescription);
            this.grpAssignments.Controls.Add(this.label5);
            this.grpAssignments.Controls.Add(this.txtType);
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
            this.grpAssignments.Controls.Add(this.txtJobName);
            this.grpAssignments.Controls.Add(this.label2);
            this.grpAssignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAssignments.Location = new System.Drawing.Point(82, 29);
            this.grpAssignments.Margin = new System.Windows.Forms.Padding(4);
            this.grpAssignments.Name = "grpAssignments";
            this.grpAssignments.Padding = new System.Windows.Forms.Padding(4);
            this.grpAssignments.Size = new System.Drawing.Size(581, 585);
            this.grpAssignments.TabIndex = 11;
            this.grpAssignments.TabStop = false;
            this.grpAssignments.Text = "Jobs";
            // 
            // txtJobID
            // 
            this.txtJobID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobID.Location = new System.Drawing.Point(53, 69);
            this.txtJobID.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(455, 23);
            this.txtJobID.TabIndex = 39;
            this.txtJobID.Tag = "Term";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "JobID: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Description:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(288, 482);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 58);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Estimated Pay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Job Level:";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(404, 422);
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
            this.btnFirst.Location = new System.Drawing.Point(56, 422);
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
            this.btnPrevious.Location = new System.Drawing.Point(172, 422);
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
            this.btnNext.Location = new System.Drawing.Point(288, 422);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 53);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // txtJobName
            // 
            this.txtJobName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobName.Location = new System.Drawing.Point(53, 122);
            this.txtJobName.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(455, 23);
            this.txtJobName.TabIndex = 1;
            this.txtJobName.Tag = "Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Job Name: ";
            // 
            // frmAddJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 627);
            this.Controls.Add(this.toolStripStatusLabel1);
            this.Controls.Add(this.grpAssignments);
            this.Name = "frmAddJobs";
            this.Text = "frmAddJobs";
            this.Load += new System.EventHandler(this.frmAddJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.grpAssignments.ResumeLayout(false);
            this.grpAssignments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.GroupBox grpAssignments;
        private System.Windows.Forms.TextBox txtEstimatedPay;
        private System.Windows.Forms.TextBox txtJobLevel;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label label7;
    }
}