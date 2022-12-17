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
    public partial class FrmNewProject : Form
    {
        #region Singleton in the window
        private static FrmNewProject _instance;
        public static FrmNewProject GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmNewProject();
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

        private FrmNewProject()
        {
            InitializeComponent();
        }

        //--

        private void FrmNewProject_Load(object sender, EventArgs e)
        {
            // Remove focus from textbox
            this.ActiveControl = lblCreateNewproject;

            txbName.Text = "Insert the project name";
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
            this.Close();
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
        //Placeholder
        private void txbName_Enter(object sender, EventArgs e)
        {
            if (txbName.Text == "Insert the project name")
            {
                txbName.Text = "";
                txbName.ForeColor = Color.Black;
            }
        }
        private void txbName_Leave(object sender, EventArgs e)
        {
            if (txbName.Text == "")
            {
                txbName.Text = "Insert the project name";
                txbName.ForeColor = Color.Gray;
            }
        }
        //--//


        //-- btnCancel
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //--//


        //-- btnCreate
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Project project = new Project(txbName.Text, dbtStart.Value.Date, dbtPlannedTermination.Value.Date, dbtTermination.Value.Date);

                ProjectRepository.SaveProject(project);

                // Succes Message
                MessageBox.Show($"Project created successfully", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Error message
                MessageBox.Show($"Fill in all required fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_MouseEnter(object sender, EventArgs e)
        {
            btnCreate.BackColor = System.Drawing.Color.FromArgb(5, 5, 20);
            btnCreate.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
        }
        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.BackColor = System.Drawing.Color.FromArgb(4, 4, 9);
            btnCreate.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
        }
        //--//

        //-- Methods()

        /// Method to check if the fields are filled
        private Boolean ValidateFields()
        {
            if (txbName.Text == "Insert the project name"
                || txbName.Text == "")
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
