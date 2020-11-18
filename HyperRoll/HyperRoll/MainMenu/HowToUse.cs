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
    public partial class HowToUse : Form
    {
        public HowToUse()
        {
            InitializeComponent();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Info toInfo = new Info();
            this.Hide();
            toInfo.Show();
        }

        private void HowToUse_Load(object sender, EventArgs e)
        {

        }

        private void HowToUse_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
