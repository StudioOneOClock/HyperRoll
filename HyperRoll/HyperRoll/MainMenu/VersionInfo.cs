using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperRoll
{
    public partial class VersionInfo : Form
    {
        public VersionInfo()
        {
            InitializeComponent();
        }

        private void lblVersionInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Info toInfoFromVersionInfo = new Info();
            this.Hide();
            toInfoFromVersionInfo.Show();
        }

        private void VersionInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void VersionInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
