namespace dev_allocation.Interface
{
    partial class FrmNewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewProject));
            this.lblCreateNewproject = new System.Windows.Forms.Label();
            this.pnlControlbox = new System.Windows.Forms.Panel();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.lblNewProject = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.dbtTermination = new System.Windows.Forms.DateTimePicker();
            this.dbtPlannedTermination = new System.Windows.Forms.DateTimePicker();
            this.lblTermination = new System.Windows.Forms.Label();
            this.lblPlannedTermination = new System.Windows.Forms.Label();
            this.dbtStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.pnlControlbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateNewproject
            // 
            this.lblCreateNewproject.AutoSize = true;
            this.lblCreateNewproject.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Bold);
            this.lblCreateNewproject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblCreateNewproject.Location = new System.Drawing.Point(138, 60);
            this.lblCreateNewproject.Name = "lblCreateNewproject";
            this.lblCreateNewproject.Size = new System.Drawing.Size(359, 40);
            this.lblCreateNewproject.TabIndex = 6;
            this.lblCreateNewproject.Text = "CREATE NEW PROJECT";
            // 
            // pnlControlbox
            // 
            this.pnlControlbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.pnlControlbox.Controls.Add(this.ptbMinimize);
            this.pnlControlbox.Controls.Add(this.ptbClose);
            this.pnlControlbox.Controls.Add(this.lblNewProject);
            this.pnlControlbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlbox.Location = new System.Drawing.Point(0, 0);
            this.pnlControlbox.Name = "pnlControlbox";
            this.pnlControlbox.Size = new System.Drawing.Size(628, 35);
            this.pnlControlbox.TabIndex = 7;
            this.pnlControlbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControlbox_MouseDown);
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(572, 5);
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
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(597, 5);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(25, 25);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 1;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            this.ptbClose.MouseEnter += new System.EventHandler(this.ptbClose_MouseEnter);
            this.ptbClose.MouseLeave += new System.EventHandler(this.ptbClose_MouseLeave);
            // 
            // lblNewProject
            // 
            this.lblNewProject.AutoSize = true;
            this.lblNewProject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNewProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblNewProject.Location = new System.Drawing.Point(11, 8);
            this.lblNewProject.Name = "lblNewProject";
            this.lblNewProject.Size = new System.Drawing.Size(101, 19);
            this.lblNewProject.TabIndex = 0;
            this.lblNewProject.Text = "New Project";
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.pnlForm.Controls.Add(this.dbtTermination);
            this.pnlForm.Controls.Add(this.dbtPlannedTermination);
            this.pnlForm.Controls.Add(this.lblTermination);
            this.pnlForm.Controls.Add(this.lblPlannedTermination);
            this.pnlForm.Controls.Add(this.dbtStart);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.lblStart);
            this.pnlForm.Controls.Add(this.lblName);
            this.pnlForm.Controls.Add(this.btnCancel);
            this.pnlForm.Controls.Add(this.btnCreate);
            this.pnlForm.Controls.Add(this.txbName);
            this.pnlForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.pnlForm.Location = new System.Drawing.Point(35, 122);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(548, 181);
            this.pnlForm.TabIndex = 8;
            // 
            // dbtTermination
            // 
            this.dbtTermination.Font = new System.Drawing.Font("Consolas", 10F);
            this.dbtTermination.Location = new System.Drawing.Point(179, 136);
            this.dbtTermination.Name = "dbtTermination";
            this.dbtTermination.Size = new System.Drawing.Size(200, 23);
            this.dbtTermination.TabIndex = 20;
            // 
            // dbtPlannedTermination
            // 
            this.dbtPlannedTermination.Font = new System.Drawing.Font("Consolas", 10F);
            this.dbtPlannedTermination.Location = new System.Drawing.Point(179, 99);
            this.dbtPlannedTermination.Name = "dbtPlannedTermination";
            this.dbtPlannedTermination.Size = new System.Drawing.Size(200, 23);
            this.dbtPlannedTermination.TabIndex = 19;
            // 
            // lblTermination
            // 
            this.lblTermination.AutoSize = true;
            this.lblTermination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTermination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblTermination.Location = new System.Drawing.Point(70, 138);
            this.lblTermination.Name = "lblTermination";
            this.lblTermination.Size = new System.Drawing.Size(99, 19);
            this.lblTermination.TabIndex = 18;
            this.lblTermination.Text = "Termination";
            // 
            // lblPlannedTermination
            // 
            this.lblPlannedTermination.AutoSize = true;
            this.lblPlannedTermination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlannedTermination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblPlannedTermination.Location = new System.Drawing.Point(7, 101);
            this.lblPlannedTermination.Name = "lblPlannedTermination";
            this.lblPlannedTermination.Size = new System.Drawing.Size(162, 19);
            this.lblPlannedTermination.TabIndex = 17;
            this.lblPlannedTermination.Text = "Planned termination";
            // 
            // dbtStart
            // 
            this.dbtStart.Font = new System.Drawing.Font("Consolas", 10F);
            this.dbtStart.Location = new System.Drawing.Point(179, 62);
            this.dbtStart.Name = "dbtStart";
            this.dbtStart.Size = new System.Drawing.Size(200, 23);
            this.dbtStart.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(5, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 8;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblStart.Location = new System.Drawing.Point(124, 64);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(45, 19);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Start";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(110, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 19);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name*";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(391, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 39);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnCreate.Location = new System.Drawing.Point(391, 120);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(130, 39);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            this.btnCreate.MouseEnter += new System.EventHandler(this.btnCreate_MouseEnter);
            this.btnCreate.MouseLeave += new System.EventHandler(this.btnCreate_MouseLeave);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Consolas", 14F);
            this.txbName.Location = new System.Drawing.Point(179, 21);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(342, 29);
            this.txbName.TabIndex = 0;
            this.txbName.Enter += new System.EventHandler(this.txbName_Enter);
            this.txbName.Leave += new System.EventHandler(this.txbName_Leave);
            // 
            // FrmNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(628, 338);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblCreateNewproject);
            this.Controls.Add(this.pnlControlbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Project";
            this.Load += new System.EventHandler(this.FrmNewProject_Load);
            this.pnlControlbox.ResumeLayout(false);
            this.pnlControlbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateNewproject;
        private System.Windows.Forms.Panel pnlControlbox;
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.Label lblNewProject;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.DateTimePicker dbtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.DateTimePicker dbtTermination;
        private System.Windows.Forms.DateTimePicker dbtPlannedTermination;
        private System.Windows.Forms.Label lblTermination;
        private System.Windows.Forms.Label lblPlannedTermination;
    }
}