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
    public partial class LoadChar : Form
    {
        public LoadChar()
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
            StartUp toSU = new StartUp();
            this.Hide();
            toSU.Show();
        }

        private void btnNewChar_Click(object sender, EventArgs e)
        {
            BuildCharacter newChar = new BuildCharacter();
            this.Hide();
            newChar.Show();
        }

        private void LoadChar_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
