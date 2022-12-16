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

            txbNome.Text = "Insert your name";
            txbNome.ForeColor = Color.Gray;

            txbEmail.Text = "Insert your Email";
            txbEmail.ForeColor = Color.Gray;

            txbPassword.Text = "Enter a password greater than 8 and less than 12";
            txbNome.ForeColor = Color.Gray;
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
    }
}
