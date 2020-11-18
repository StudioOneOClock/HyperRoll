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
    public partial class SplashStart : Form
    {
        Timer tmr;
        public SplashStart()
        {
            InitializeComponent();
        }
        private void SplashStart_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 2000;
            //starts the timer
            tmr.Start();
            for (int i = 0; i < 100; i++)
            {
                loader.Value += 1;
            }
            tmr.Tick += tmr_Tick;
            
        }
        void tmr_Tick(object sender, EventArgs e)

        {
            //after 3 sec stop the timer
            tmr.Stop();
            //display mainform
            StartUp mf = new StartUp();
            mf.Show();
            //hide this form
            this.Hide();
        }
    }
}
