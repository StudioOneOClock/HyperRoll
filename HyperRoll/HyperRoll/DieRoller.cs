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
    public partial class DieRoller : Form
    {
        CharSheet refCs = new CharSheet();

        public string dieNumber;
        public int dieNumberInt;

        public Random dieRand = new Random();
        public int minDie;
        public int maxDie;

        public int dieRoll;
        public int dieModification;
        public string dieOutput;
        public int roll;
        public int rollResult;

        public DieRoller()
        {
            InitializeComponent();
        }

     

        

        private void dieNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dieNum.SelectedIndex.Equals(0))
            {
                dieNumber = "0";
                dieNumberInt = 0;
            }
            else if (dieNum.SelectedIndex.Equals(1))
            {
                dieNumber = "1";
                dieNumberInt = 1;
            }
            else if (dieNum.SelectedIndex.Equals(3))
            {
                  dieNumber = "3";
                dieNumberInt = 3;
            }
            else if (dieNum.SelectedIndex.Equals(4))
            {
                dieNumber = "4";
                dieNumberInt = 4;
            }
            else if (dieNum.SelectedIndex.Equals(5))
            {
                dieNumber = "5";
                dieNumberInt = 5;
            }
            else if (dieNum.SelectedIndex.Equals(6))
            {
                dieNumber = "6";
                dieNumberInt = 6;
            }
            else if (dieNum.SelectedIndex.Equals(7))
            {
                dieNumber = "7";
                dieNumberInt = 7;
            }
            else if (dieNum.SelectedIndex.Equals(8))
            {
                dieNumber = "8";
                dieNumberInt = 8;
            }
            else if (dieNum.SelectedIndex.Equals(9))
            {
                dieNumber = "9";
                dieNumberInt = 9;
            }
            else if (dieNum.SelectedIndex.Equals(10))
            {
                dieNumber = "10";
                dieNumberInt = 10;
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (dieNum.SelectedIndex.Equals(0))
            {

            }
            else if (dieType.SelectedIndex.Equals(0))
            {

            }
            else if (dieAdjust.SelectedIndex.Equals(0))
            {

            }
            else if (dieMod.SelectedIndex.Equals(0))
            {

            }
            else
            {
                if (dieAdjust.SelectedIndex.Equals(1))
                {
                    AdjustAdd();
                }
                else if (dieAdjust.SelectedIndex.Equals(2))
                {
                    AdjustMin();
                }
                else if (dieAdjust.SelectedIndex.Equals(3))
                {
                    AdjustMul();
                }
                else if (dieAdjust.SelectedIndex.Equals(4))
                {
                    AdjustDiv();
                }
            }
        }

        public void dieType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //D3
            if (dieType.SelectedIndex.Equals(1))
            {
                minDie = 1;
                maxDie = 4;
                dieRoll = dieRand.Next(minDie, maxDie);
            }
            // D4
            else if (dieType.SelectedIndex.Equals(2))
            {
                minDie = 1;
                maxDie = 5;
                dieRoll = dieRand.Next(minDie, maxDie);
            }
            // D6
            else if (dieType.SelectedIndex.Equals(3))
            {
                minDie = 1;
                maxDie = 7;
                dieRoll = dieRand.Next(minDie, maxDie);
            }
            // D8
            else if (dieType.SelectedIndex.Equals(4))
            {
                minDie = 1;
                maxDie = 9;
                dieRoll = dieRand.Next(minDie, maxDie);
            }
            // D10
            else if (dieType.SelectedIndex.Equals(5))
            {
                minDie = 1;
                maxDie = 11;
                dieRoll = dieRand.Next(minDie, maxDie);
            }
            // D12
            else if (dieType.SelectedIndex.Equals(6))
            {
                minDie = 1;
                maxDie = 13;
                dieRoll = dieRand.Next(minDie, maxDie);
            }
            // D20
            else if (dieType.SelectedIndex.Equals(7))
            {
                minDie = 1;
                maxDie = 21;
                dieRoll = dieRand.Next(minDie, maxDie);
            }
            // D100
            else if (dieType.SelectedIndex.Equals(2))
            {
                minDie = 1;
                maxDie = 101;
                dieRoll = dieRand.Next(minDie, maxDie);
            }
        }
        public void AdjustAdd()
        {
            roll = dieNumberInt * (dieRoll);
            rollResult = roll + dieModification;
            dieOutput = rollResult.ToString();
            output.Text = dieOutput;
        }
        public void AdjustMin()
        {
            roll = dieNumberInt * (dieRoll);
            rollResult = roll - dieModification;
            dieOutput = rollResult.ToString();
            output.Text = dieOutput;
        }
        public void AdjustDiv()
        {
            roll = dieNumberInt * (dieRoll);
            rollResult = roll / dieModification;
            dieOutput = rollResult.ToString();
            output.Text = dieOutput;
        }
        public void AdjustMul()
        {
            roll = dieNumberInt * (dieRoll);
            rollResult = roll * dieModification;
            dieOutput = rollResult.ToString();
            output.Text = dieOutput;
        }

        private void DieRoller_Load(object sender, EventArgs e)
        {
            dieNum.Select();
            dieType.SelectedIndex.Equals(1);
            dieAdjust.SelectedIndex.Equals(1);
        }
    }
}
