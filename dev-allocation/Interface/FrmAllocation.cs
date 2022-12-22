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
    public partial class FrmAllocation : Form
    {
        #region Singleton in Window
        private static FrmAllocation _instance;
        public static FrmAllocation GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmAllocation();
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

        private void pnlControlbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private FrmAllocation()
        {
            InitializeComponent();
        }


    }
}
