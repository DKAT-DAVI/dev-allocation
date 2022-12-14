namespace dev_allocation.Interface
{
    partial class FrmNewDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewDev));
            this.pnlControlbox = new System.Windows.Forms.Panel();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblPasswordFormatMessage = new System.Windows.Forms.Label();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkAdministrator = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblNewDev = new System.Windows.Forms.Label();
            this.pnlControlbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControlbox
            // 
            this.pnlControlbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.pnlControlbox.Controls.Add(this.ptbMinimize);
            this.pnlControlbox.Controls.Add(this.ptbClose);
            this.pnlControlbox.Controls.Add(this.lblSignUp);
            this.pnlControlbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlbox.Location = new System.Drawing.Point(0, 0);
            this.pnlControlbox.Name = "pnlControlbox";
            this.pnlControlbox.Size = new System.Drawing.Size(729, 35);
            this.pnlControlbox.TabIndex = 5;
            this.pnlControlbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControlbox_MouseDown_1);
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(673, 5);
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
            this.ptbClose.Location = new System.Drawing.Point(698, 5);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(25, 25);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 1;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            this.ptbClose.MouseEnter += new System.EventHandler(this.ptbClose_MouseEnter);
            this.ptbClose.MouseLeave += new System.EventHandler(this.ptbClose_MouseLeave);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblSignUp.Location = new System.Drawing.Point(11, 8);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(70, 19);
            this.lblSignUp.TabIndex = 0;
            this.lblSignUp.Text = "Sign Up";
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.pnlForm.Controls.Add(this.lblPasswordFormatMessage);
            this.pnlForm.Controls.Add(this.cbxLevel);
            this.pnlForm.Controls.Add(this.label7);
            this.pnlForm.Controls.Add(this.chkActive);
            this.pnlForm.Controls.Add(this.chkAdministrator);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.dtpBirthDate);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.txbPassword);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.txbEmail);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Controls.Add(this.btnCancel);
            this.pnlForm.Controls.Add(this.btnSignUp);
            this.pnlForm.Controls.Add(this.txbName);
            this.pnlForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.pnlForm.Location = new System.Drawing.Point(142, 129);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(453, 249);
            this.pnlForm.TabIndex = 6;
            // 
            // lblPasswordFormatMessage
            // 
            this.lblPasswordFormatMessage.AutoSize = true;
            this.lblPasswordFormatMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordFormatMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblPasswordFormatMessage.Location = new System.Drawing.Point(93, 118);
            this.lblPasswordFormatMessage.Name = "lblPasswordFormatMessage";
            this.lblPasswordFormatMessage.Size = new System.Drawing.Size(294, 12);
            this.lblPasswordFormatMessage.TabIndex = 17;
            this.lblPasswordFormatMessage.Text = "The password must be at least 8 characters and at most 12 characters.";
            this.lblPasswordFormatMessage.Visible = false;
            // 
            // cbxLevel
            // 
            this.cbxLevel.Font = new System.Drawing.Font("Consolas", 14F);
            this.cbxLevel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Items.AddRange(new object[] {
            "J",
            "P",
            "S"});
            this.cbxLevel.Location = new System.Drawing.Point(375, 137);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(36, 30);
            this.cbxLevel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(321, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Level*";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Enabled = false;
            this.chkActive.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.chkActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.chkActive.Location = new System.Drawing.Point(350, 175);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(15, 14);
            this.chkActive.TabIndex = 6;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // chkAdministrator
            // 
            this.chkAdministrator.AutoSize = true;
            this.chkAdministrator.Enabled = false;
            this.chkAdministrator.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.chkAdministrator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.chkAdministrator.Location = new System.Drawing.Point(225, 175);
            this.chkAdministrator.Name = "chkAdministrator";
            this.chkAdministrator.Size = new System.Drawing.Size(15, 14);
            this.chkAdministrator.TabIndex = 5;
            this.chkAdministrator.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(107, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Administrator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(288, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Active";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Consolas", 10F);
            this.dtpBirthDate.Location = new System.Drawing.Point(92, 140);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(10, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "BirthDate";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Consolas", 14F);
            this.txbPassword.ForeColor = System.Drawing.Color.Gray;
            this.txbPassword.Location = new System.Drawing.Point(92, 88);
            this.txbPassword.MaxLength = 12;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(340, 29);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.Enter += new System.EventHandler(this.txbPassword_Enter);
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(5, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email*";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Consolas", 14F);
            this.txbEmail.Location = new System.Drawing.Point(92, 53);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(340, 29);
            this.txbEmail.TabIndex = 1;
            this.txbEmail.Enter += new System.EventHandler(this.txbEmail_Enter);
            this.txbEmail.Leave += new System.EventHandler(this.txbEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name*";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(75, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 39);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnSignUp.Location = new System.Drawing.Point(255, 200);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(130, 39);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            this.btnSignUp.MouseEnter += new System.EventHandler(this.btnSignUp_MouseEnter);
            this.btnSignUp.MouseLeave += new System.EventHandler(this.btnSignUp_MouseLeave);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Consolas", 14F);
            this.txbName.Location = new System.Drawing.Point(92, 18);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(340, 29);
            this.txbName.TabIndex = 0;
            this.txbName.Enter += new System.EventHandler(this.txbNome_Enter);
            this.txbName.Leave += new System.EventHandler(this.txbNome_Leave);
            // 
            // lblNewDev
            // 
            this.lblNewDev.AutoSize = true;
            this.lblNewDev.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Bold);
            this.lblNewDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblNewDev.Location = new System.Drawing.Point(210, 66);
            this.lblNewDev.Name = "lblNewDev";
            this.lblNewDev.Size = new System.Drawing.Size(321, 40);
            this.lblNewDev.TabIndex = 4;
            this.lblNewDev.Text = "REGISTER NEW DEV";
            // 
            // FrmNewDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(729, 428);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.lblNewDev);
            this.Controls.Add(this.pnlControlbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.FrmNewDev_Load);
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

        private System.Windows.Forms.Panel pnlControlbox;
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblNewDev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAdministrator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.ComboBox cbxLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPasswordFormatMessage;
    }
}