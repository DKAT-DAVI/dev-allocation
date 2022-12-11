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

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Repository dbContext = new Repository();
        }
    }
}
