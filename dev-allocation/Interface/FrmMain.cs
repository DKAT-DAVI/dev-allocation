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
    public partial class FrmMain : Form
    {
        #region Singleton in the window
        private static FrmMain _instance;
        public static FrmMain GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmMain();
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

        private void mnuFrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        //-- Frm Main
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ChangeBgColor();

            if (!FrmLogin.DevLoggedIn.Credential.Administrator)
            {
                mnuRegistration.Visible = false;
            }
        }

        // Close the window
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //--//

        //-- pnlControlBox
        //
        //-- ptbClose
        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-- ptbNormal
        private void ptbNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            ptbMaximize.BringToFront();
        }

        //-- ptbMaximize
        private void ptbMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbNormal.BringToFront();
        }

        //-- ptbMinimize
        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // MouseHover
        // ptbClose mouseHover
        private void ptbClose_MouseEnter(object sender, EventArgs e)
        {
            ptbClose.BackColor = Color.FromArgb(32, 35, 66);
        }
        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {
            ptbClose.BackColor = Color.FromArgb(17, 16, 52);
        }

        // ptbNormal mouseHover
        private void ptbNormal_MouseEnter(object sender, EventArgs e)
        {
            ptbNormal.BackColor = Color.FromArgb(32, 35, 66);
        }
        private void ptbNormal_MouseLeave(object sender, EventArgs e)
        {
            ptbNormal.BackColor = Color.FromArgb(17, 16, 52);
        }

        // ptbMaxime mouseHover
        private void ptbMaximize_MouseEnter(object sender, EventArgs e)
        {
            ptbMaximize.BackColor = Color.FromArgb(32, 35, 66);
        }
        private void ptbMaximize_MouseLeave(object sender, EventArgs e)
        {
            ptbMaximize.BackColor = Color.FromArgb(17, 16, 52);
        }

        // ptbMinimize mouseHover
        private void ptbMinimize_MouseEnter(object sender, EventArgs e)
        {
            ptbMinimize.BackColor = Color.FromArgb(32, 35, 66);
        }
        private void ptbMinimize_MouseLeave(object sender, EventArgs e)
        {
            ptbMinimize.BackColor = Color.FromArgb(17, 16, 52);
        }
        //--//

        //-- mnuFrmMain
        //
        // tmnuExit
        private void tmnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--//

        //-- Methods()

        // Change the background color of the MDI container
        private void ChangeBgColor()
        {
            // Get a reference to the MDI container control
            MdiClient mdiContainer = this.Controls.OfType<MdiClient>().FirstOrDefault();

            // Check if the control was found
            if (mdiContainer != null)
            {
                // Set the background color of the MDI container control
                mdiContainer.BackColor = Color.FromArgb(32, 35, 66);
            }
        }
        //--//
    }
}
