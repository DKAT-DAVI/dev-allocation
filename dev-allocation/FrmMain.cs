using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public FrmMain()
        {
            InitializeComponent();
        }
    }
}
