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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            StartUp toStartUp = new StartUp();
            
            toStartUp.Show();
            this.Hide();
        }

        private void btnVersionInfo_Click(object sender, EventArgs e)
        {
            VersionInfo toVersionInfo = new VersionInfo();
            toVersionInfo.Show();
            this.Hide();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnHowToUse_Click(object sender, EventArgs e)
        {
            HowToUse toHTU = new HowToUse();
            this.Hide();
            toHTU.Show();
        }

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
