namespace dev_allocation
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ptbMaximize = new System.Windows.Forms.PictureBox();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.ptbNormal = new System.Windows.Forms.PictureBox();
            this.mnuFrmMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuNewDev = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuNewAllocation = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuNewTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNormal)).BeginInit();
            this.mnuFrmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbMaximize
            // 
            this.ptbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.ptbMaximize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximize.Image")));
            this.ptbMaximize.Location = new System.Drawing.Point(778, 6);
            this.ptbMaximize.Name = "ptbMaximize";
            this.ptbMaximize.Size = new System.Drawing.Size(25, 25);
            this.ptbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMaximize.TabIndex = 5;
            this.ptbMaximize.TabStop = false;
            this.ptbMaximize.Click += new System.EventHandler(this.ptbMaximize_Click);
            this.ptbMaximize.MouseEnter += new System.EventHandler(this.ptbMaximize_MouseEnter);
            this.ptbMaximize.MouseLeave += new System.EventHandler(this.ptbMaximize_MouseLeave);
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(752, 6);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(25, 25);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 3;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            this.ptbMinimize.MouseEnter += new System.EventHandler(this.ptbMinimize_MouseEnter);
            this.ptbMinimize.MouseLeave += new System.EventHandler(this.ptbMinimize_MouseLeave);
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(804, 6);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(25, 25);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 1;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            this.ptbClose.MouseEnter += new System.EventHandler(this.ptbClose_MouseEnter);
            this.ptbClose.MouseLeave += new System.EventHandler(this.ptbClose_MouseLeave);
            // 
            // ptbNormal
            // 
            this.ptbNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.ptbNormal.Image = ((System.Drawing.Image)(resources.GetObject("ptbNormal.Image")));
            this.ptbNormal.Location = new System.Drawing.Point(778, 6);
            this.ptbNormal.Name = "ptbNormal";
            this.ptbNormal.Size = new System.Drawing.Size(25, 25);
            this.ptbNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbNormal.TabIndex = 6;
            this.ptbNormal.TabStop = false;
            this.ptbNormal.Click += new System.EventHandler(this.ptbNormal_Click);
            this.ptbNormal.MouseEnter += new System.EventHandler(this.ptbNormal_MouseEnter);
            this.ptbNormal.MouseLeave += new System.EventHandler(this.ptbNormal_MouseLeave);
            // 
            // mnuFrmMain
            // 
            this.mnuFrmMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.mnuFrmMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRegistration,
            this.tmnuAbout});
            this.mnuFrmMain.Location = new System.Drawing.Point(0, 0);
            this.mnuFrmMain.Name = "mnuFrmMain";
            this.mnuFrmMain.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.mnuFrmMain.Size = new System.Drawing.Size(832, 35);
            this.mnuFrmMain.TabIndex = 3;
            this.mnuFrmMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mnuFrmMain_MouseDown);
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuExit});
            this.mnuFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.mnuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(48, 23);
            this.mnuFile.Text = "File";
            // 
            // tmnuExit
            // 
            this.tmnuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.tmnuExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tmnuExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.tmnuExit.Name = "tmnuExit";
            this.tmnuExit.Size = new System.Drawing.Size(180, 22);
            this.tmnuExit.Text = "Exit";
            this.tmnuExit.Click += new System.EventHandler(this.tmnuExit_Click);
            // 
            // mnuRegistration
            // 
            this.mnuRegistration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuNewDev,
            this.tmnuNewAllocation,
            this.tmnuNewProject,
            this.tmnuNewTask});
            this.mnuRegistration.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.mnuRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.mnuRegistration.Name = "mnuRegistration";
            this.mnuRegistration.Size = new System.Drawing.Size(114, 23);
            this.mnuRegistration.Text = "Registration";
            // 
            // tmnuNewDev
            // 
            this.tmnuNewDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.tmnuNewDev.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tmnuNewDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.tmnuNewDev.Name = "tmnuNewDev";
            this.tmnuNewDev.Size = new System.Drawing.Size(178, 22);
            this.tmnuNewDev.Text = "New Dev";
            this.tmnuNewDev.Click += new System.EventHandler(this.tmnuNewDev_Click);
            // 
            // tmnuNewAllocation
            // 
            this.tmnuNewAllocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.tmnuNewAllocation.Enabled = false;
            this.tmnuNewAllocation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tmnuNewAllocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.tmnuNewAllocation.Name = "tmnuNewAllocation";
            this.tmnuNewAllocation.Size = new System.Drawing.Size(178, 22);
            this.tmnuNewAllocation.Text = "New Allocation";
            // 
            // tmnuNewProject
            // 
            this.tmnuNewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.tmnuNewProject.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tmnuNewProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.tmnuNewProject.Name = "tmnuNewProject";
            this.tmnuNewProject.Size = new System.Drawing.Size(178, 22);
            this.tmnuNewProject.Text = "New Project";
            this.tmnuNewProject.Click += new System.EventHandler(this.tmnuNewProject_Click);
            // 
            // tmnuNewTask
            // 
            this.tmnuNewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.tmnuNewTask.Enabled = false;
            this.tmnuNewTask.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tmnuNewTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.tmnuNewTask.Name = "tmnuNewTask";
            this.tmnuNewTask.Size = new System.Drawing.Size(178, 22);
            this.tmnuNewTask.Text = "New Task";
            // 
            // tmnuAbout
            // 
            this.tmnuAbout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tmnuAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.tmnuAbout.Name = "tmnuAbout";
            this.tmnuAbout.Size = new System.Drawing.Size(67, 23);
            this.tmnuAbout.Text = "About";
            this.tmnuAbout.Click += new System.EventHandler(this.tmnuAbout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 518);
            this.ControlBox = false;
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.ptbNormal);
            this.Controls.Add(this.ptbMinimize);
            this.Controls.Add(this.mnuFrmMain);
            this.Controls.Add(this.ptbMaximize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuFrmMain;
            this.MinimumSize = new System.Drawing.Size(828, 518);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "Dev Allocation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNormal)).EndInit();
            this.mnuFrmMain.ResumeLayout(false);
            this.mnuFrmMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.PictureBox ptbMaximize;
        private System.Windows.Forms.PictureBox ptbNormal;
        private System.Windows.Forms.MenuStrip mnuFrmMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem tmnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistration;
        private System.Windows.Forms.ToolStripMenuItem tmnuNewDev;
        private System.Windows.Forms.ToolStripMenuItem tmnuNewProject;
        private System.Windows.Forms.ToolStripMenuItem tmnuNewAllocation;
        private System.Windows.Forms.ToolStripMenuItem tmnuNewTask;
        private System.Windows.Forms.ToolStripMenuItem tmnuAbout;
    }
}

