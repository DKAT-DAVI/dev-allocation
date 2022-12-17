using dev_allocation.Data;
using dev_allocation.Data.Repositorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dev_allocation.Interface
{
    internal partial class FrmNewDev : Form
    {
        #region Singleton in the window
        private static FrmNewDev _instance;
        public static FrmNewDev GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmNewDev();
            }

            return _instance;
        }
        #endregion

        #region Move Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlControlbox_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        //-- FrmNewDev
        private FrmNewDev()
        {
            InitializeComponent();
            if(FrmLogin.DevLoggedIn != null)
            {
                if (FrmLogin.DevLoggedIn.Credential.Administrator)
                {
                    chkActive.Enabled = true;
                    chkAdministrator.Enabled = true;
                }
            }
            
        }

        private void FrmNewDev_Load(object sender, EventArgs e)
        {
            // Remove focus from textbox
            this.ActiveControl = lblAcessForm;

            txbName.Text = "Insert your name";
            txbName.ForeColor = Color.Gray;

            txbEmail.Text = "Insert your Email";
            txbEmail.ForeColor = Color.Gray;

            txbPassword.Text = "Password";
            txbName.ForeColor = Color.Gray;
        }

        //--//

        //-- ptbClose
        private void ptbClose_MouseEnter(object sender, EventArgs e)
        {
            ptbClose.BackColor = System.Drawing.Color.FromArgb(32, 35, 66);
        }
        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {
            ptbClose.BackColor = System.Drawing.Color.FromArgb(17, 16, 52);
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            if (FrmLogin.DevLoggedIn != null)
            {
                if (FrmLogin.DevLoggedIn.Credential.Administrator)
                {
                    this.Close();

                }
            }
            else
            {
                this.Close();
                FrmLogin.GetInstance().Show();
            }
        }
        //--//

        //-- ptbMinimize
        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //-- MouseHover
        private void ptbMinimize_MouseEnter(object sender, EventArgs e)
        {
            ptbMinimize.BackColor = System.Drawing.Color.FromArgb(32, 35, 66);
        }
        private void ptbMinimize_MouseLeave(object sender, EventArgs e)
        {
            ptbMinimize.BackColor = System.Drawing.Color.FromArgb(17, 16, 52);
        }
        //--//


        //-- txbNome
        //
        // Placeholder
        private void txbNome_Enter(object sender, EventArgs e)
        {
            if (txbName.Text == "Insert your name")
            {
                txbName.Text = "";
                txbName.ForeColor = Color.Black;
            }
        }
        private void txbNome_Leave(object sender, EventArgs e)
        {
            if (txbName.Text == "")
            {
                txbName.Text = "Insert your name";
                txbName.ForeColor = Color.Gray;
            }
        }
        //--//


        //-- txbEmail
        //
        // Placeholder
        private void txbEmail_Enter(object sender, EventArgs e)
        {
            if (txbEmail.Text == "Insert your Email")
            {
                txbEmail.Text = "";
                txbEmail.ForeColor = Color.Black;
            }
        }
        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                txbEmail.Text = "Insert your Email";
                txbEmail.ForeColor = Color.Gray;
            }
        }
        //--//


        //-- txbPassword
        //
        // Placeholder
        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = Color.Black;
            }

            // Password formatting message
            lblPasswordFormatMessage.Visible = true;

            // HidePassword
            txbPassword.UseSystemPasswordChar = true;
        }
        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "Password";
                txbPassword.ForeColor = Color.Gray;

                /// HidePassword
                txbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Password formatting message
                lblPasswordFormatMessage.Visible = false;
            }
        }
        //--//


        //-- btnSignUp
        //MouseHover
        private void btnSignUp_MouseEnter(object sender, EventArgs e)
        {
            btnSignUp.BackColor = System.Drawing.Color.FromArgb(5, 5, 20);
            btnSignUp.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
        }
        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = System.Drawing.Color.FromArgb(4, 4, 9);
            btnSignUp.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
        }
        // Click
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean verifyEmail = CredentialRepository.EmailIsValid(txbEmail.Text);
                
                // Check if the fields are filled
                if (ValidateFields())
                {
                    // Check if the email exists
                    if (verifyEmail)
                    {
                        // Creating a new Dev
                        Developer dev = new Developer(txbName.Text, dtpBirthDate.Value.Date, Convert.ToChar(cbxLevel.SelectedItem));
                        Credential credential = new Credential(txbEmail.Text, txbPassword.Text, chkActive.Checked, chkAdministrator.Checked);

                        // Relationship dev to credential
                        dev.Credential = credential;
                        credential.Developer = dev;

                        // Saving the new Dev
                        DeveloperRepository.SaveDeveloper(dev, credential);

                        // Modifying the window according to administrator permissions
                        if (FrmLogin.DevLoggedIn != null)
                        {
                            if (FrmLogin.DevLoggedIn.Credential.Administrator)
                            {
                                // Succes Message
                                MessageBox.Show($"User created successfully", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();

                            }
                        }
                        else
                        {
                            // Succes Message
                            MessageBox.Show($"User created successfully", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            FrmLogin.GetInstance().Show();
                        }
                    }
                    else
                    {
                        // Clear fields
                        txbName.Text = "";
                        txbEmail.Text = "";
                        txbPassword.Text = "";
                        dtpBirthDate.Value = DateTime.Now;
                        cbxLevel.SelectedItem = null;
                        chkActive.Checked = false;
                        chkAdministrator.Checked = false;
                    }
                }
                else
                {
                    // Error message
                    MessageBox.Show($"Fill in all required fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch ( Exception error)
            {
                // Error message
                MessageBox.Show($"{error.Message}", "EMAIL ALREADY USED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //--//


        //-- btnCancel
        //Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // If is usage user
            if (FrmLogin.DevLoggedIn != null)
            {
                if (FrmLogin.DevLoggedIn.Credential.Administrator)
                {
                    this.Close();
                }
            }

            // If is administrator
            else
            {
                this.Close();
                FrmLogin.GetInstance().Show();
            }
        }
        //Mousehover
        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = System.Drawing.Color.FromArgb(5, 5, 20);
            btnCancel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
        }
        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = System.Drawing.Color.FromArgb(4, 4, 9);
            btnCancel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
        }
        //-//

        //-- Methods()

        /// Method to check if the fields are filled
        private Boolean ValidateFields()
        {
            if (txbName.Text == "Insert yout name" 
                || txbName.Text == "" 
                || txbEmail.Text == "Insert your Email"
                || txbEmail.Text == ""
                || cbxLevel.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //--//
    }
}
