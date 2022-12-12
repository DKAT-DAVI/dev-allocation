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
    public partial class FrmLogin : Form
    {
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

        private void pnlLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion


        //-- FrmMain
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Starting the database connection
            Repository dbContext = new Repository();

            this.ActiveControl = lblAcessForm;

            txbUser.Text = "Email";
            txbUser.ForeColor = Color.Gray;

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
            ptbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
        }
        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {
            ptbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
        }

        //-- ptbMinimize
        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //-- MouseHover
        private void ptbMinimize_MouseEnter(object sender, EventArgs e)
        {
            ptbMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
        }
        private void ptbMinimize_MouseLeave(object sender, EventArgs e)
        {
            ptbMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
        }
        //--//


        //-- txbUser
        //-- Placeholder
        private void txbUser_Enter(object sender, EventArgs e)
        {
            if (txbUser.Text == "Email")
            {
                txbUser.Text = "";
                txbUser.ForeColor = Color.Black;
            }
        }
        private void txbUser_Leave(object sender, EventArgs e)
        {
            if (txbUser.Text == "")
            {
                txbUser.Text = "Email";
                txbUser.ForeColor = Color.Gray;
            }
        }
        //-- Switch field
        private void txbUser_KeyUp(object sender, KeyEventArgs e)
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
            btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            btnLogin.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(9)))));
            btnLogin.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
        }

        // Click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funfou");
        }
        //--//


        //-- lblNewDev
        // MouseHover
        private void lblNewDev_MouseEnter(object sender, EventArgs e)
        {
            lblNewDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
        }
        private void lblNewDev_MouseLeave(object sender, EventArgs e)
        {
            lblNewDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
        }

        //--//


    }
}
