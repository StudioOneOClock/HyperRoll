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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }
        private void StartUp_Load(object sender, EventArgs e)
        {
            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadChar toLoadChar = new LoadChar();
            Info infoExit = new Info();
            HowToUse htuExit = new HowToUse();
            VersionInfo viExit = new VersionInfo();
            this.Hide();
            toLoadChar.Show();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            
            Info toInfo = new Info();
            toInfo.Show();
            this.Hide();

        }
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        private void StartUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
