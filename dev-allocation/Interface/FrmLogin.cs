using dev_allocation.Data;
using dev_allocation.Data.Repositorys;
using dev_allocation.Interface;
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

namespace dev_allocation
{
    internal partial class FrmLogin : Form
    {
        // Store de logged dev
        public static Developer DevLoggedIn { get; set; }

        #region Singleton in the window
        private static FrmLogin _instance;
        public static FrmLogin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmLogin();
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

        private void pnlControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        //-- FrmMain
        private FrmLogin()
        {
            InitializeComponent();
            //DevLoggedIn = CredentialRepository.AuthenticateDeveloper(txbEmail.Text, txbPassword.Text);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        { 
            // Starting the database connection
            Repository dbContext = new Repository();

            // Remove focus from textbox
            this.ActiveControl = lblAcessForm;

            txbEmail.Text = "Email";
            txbEmail.ForeColor = Color.Gray;

            txbPassword.Text = "Password";
            txbPassword.ForeColor = Color.Gray;
        }
        //--//

        //-- ControlBox
        //-- ptbClose
        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-- MouseHover
        private void ptbClose_MouseEnter(object sender, EventArgs e)
        {
            ptbClose.BackColor = System.Drawing.Color.FromArgb(32, 35, 66);
        }
        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {
            ptbClose.BackColor = System.Drawing.Color.FromArgb(17, 16, 52);
        }

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


        //-- txbUser
        //-- Placeholder
        private void txbEmail_Enter(object sender, EventArgs e)
        {
            if (txbEmail.Text == "Email")
            {
                txbEmail.Text = "";
                txbEmail.ForeColor = Color.Black;
            }
        }
        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                txbEmail.Text = "Email";
                txbEmail.ForeColor = Color.Gray;
            }
        }
        //-- Switch field
        private void txbEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbPassword.Focus();
            }
        }
        //--//


        //-- txbPassword
        // Placeholder
        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = Color.Black;
            }

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
        }
        //-- Switch field 
        private void txbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        //--//


        //-- btnLogin
        // MouseHover
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.FromArgb(5, 5, 20);
            btnLogin.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.FromArgb(4, 4, 9);
            btnLogin.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
        }

        // Click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DevLoggedIn = CredentialRepository.AuthenticateDeveloper(txbEmail.Text, txbPassword.Text);

                if (DevLoggedIn != null)
                {
                    this.Hide();
                    FrmMain.GetInstance().Show();

                    txbEmail.Text = "Email";
                    txbEmail.ForeColor = Color.Gray;
                    txbPassword.Text = "Password";
                    txbPassword.ForeColor = Color.Gray;
                    txbPassword.UseSystemPasswordChar = false;

                    // Remove focus from textbox
                    this.ActiveControl = lblAcessForm;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "AUTHENTICATION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        //--//


        //-- lblNewDev
        // MouseHover
        private void lblNewDev_MouseEnter(object sender, EventArgs e)
        {
            lblNewDev.ForeColor = System.Drawing.Color.FromArgb(100, 100, 200);
        }
        private void lblNewDev_MouseLeave(object sender, EventArgs e)
        {
            lblNewDev.ForeColor = System.Drawing.Color.FromArgb(231, 231, 255);
        }

        private void lblNewDev_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNewDev.GetInstance().Show();

        }
        //--//

    }
}
