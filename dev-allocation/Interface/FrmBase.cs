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
    public partial class FrmBase : Form
    {
        #region Singleton in the window
        private static FrmBase _instance;
        public static FrmBase GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmBase();
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

        public FrmBase()
        {
            InitializeComponent();
        }

        //-- ControlBox
        //-- ptbClose
        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-- MouseHover
        private void ptbClose_MouseEnter(object sender, EventArgs e)
        {
            ptbClose.BackColor = System.Drawing.Color.FromArgb(150, 35, 66);
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

    }
}
