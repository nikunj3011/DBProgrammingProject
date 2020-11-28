namespace mdiExample
{
    partial class MDINBCC
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.iTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseJobsToolStripMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectRelatedJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTToolStripMenuItem,
            this.viewMenu,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1476, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // iTToolStripMenuItem
            // 
            this.iTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignmentsToolStripMenuItem,
            this.browseJobsToolStripMenuItems,
            this.instructorsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.subjectRelatedJobsToolStripMenuItem});
            this.iTToolStripMenuItem.Name = "iTToolStripMenuItem";
            this.iTToolStripMenuItem.Size = new System.Drawing.Size(35, 24);
            this.iTToolStripMenuItem.Text = "IT";
            // 
            // assignmentsToolStripMenuItem
            // 
            this.assignmentsToolStripMenuItem.Name = "assignmentsToolStripMenuItem";
            this.assignmentsToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.assignmentsToolStripMenuItem.Tag = "addSubjects";
            this.assignmentsToolStripMenuItem.Text = "Add Subject";
            this.assignmentsToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // browseJobsToolStripMenuItems
            // 
            this.browseJobsToolStripMenuItems.Name = "browseJobsToolStripMenuItems";
            this.browseJobsToolStripMenuItems.Size = new System.Drawing.Size(229, 26);
            this.browseJobsToolStripMenuItems.Tag = "addJobs";
            this.browseJobsToolStripMenuItems.Text = "Add Jobs";
            this.browseJobsToolStripMenuItems.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // instructorsToolStripMenuItem
            // 
            this.instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            this.instructorsToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.instructorsToolStripMenuItem.Tag = "browseSubjects";
            this.instructorsToolStripMenuItem.Text = "Browse Subjects";
            this.instructorsToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.coursesToolStripMenuItem.Tag = "browseJobs";
            this.coursesToolStripMenuItem.Text = "Browse Jobs";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // subjectRelatedJobsToolStripMenuItem
            // 
            this.subjectRelatedJobsToolStripMenuItem.Name = "subjectRelatedJobsToolStripMenuItem";
            this.subjectRelatedJobsToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.subjectRelatedJobsToolStripMenuItem.Tag = "subjectRelatedJobs";
            this.subjectRelatedJobsToolStripMenuItem.Text = "Subject Related Jobs";
            this.subjectRelatedJobsToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(55, 24);
            this.viewMenu.Text = "&View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.toolBarToolStripMenuItem.Text = "&Toolbar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(84, 24);
            this.windowsMenu.Text = "&Windows";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(133, 26);
            this.about.Tag = "about";
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1476, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1029);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1476, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDINBCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1055);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDINBCC";
            this.Text = "Welcome";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem iTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseJobsToolStripMenuItems;
        private System.Windows.Forms.ToolStripMenuItem subjectRelatedJobsToolStripMenuItem;
    }
}



