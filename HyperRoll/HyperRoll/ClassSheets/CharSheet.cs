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
    public partial class CharSheet : Form
    {
        //WORKING ON:
        //Setting up new set stat methods in this form

        //References
        
        //General Info
        public string playerName;
        public string characterName;
        public string charGender;
        public string charHeightFt;
        public int intcharHeightFt;
        public string charHeightIn;
        public int intcharHeightIn;
        public string charWeight;
        public int intcharWeight;
        public string charHair;
        public string charEye;
        public string charDeity;
        public string charHomeland;
        public string charAlignment;
        public string charAge;
        public int intcharAge;
        public string charRace;
        public string charSize;

        //Abilities
        public string strength;
        public string dexterity;
        public string constitution;
        public string intelligence;
        public string wisdom;
        public string charisma;
        public int strInt;
        public int dexInt;
        public int conInt;
        public int intInt;
        public int wisInt;
        public int chaInt;
        public string strMod;
        public string dexMod;
        public string conMod;
        public string intMod;
        public string wisMod;
        public string chaMod;
        public int strModInt;
        public int dexModInt;
        public int conModInt;
        public int intModInt;
        public int wisModInt;
        public int chaModInt;

        //Speed
        public string baseSpeed;
        public int baseSpeedInt;


        

        public CharSheet()
            
        {
            InitializeComponent();
        }

        //Methods
        //Reset Abilities
        public void SetStr()
        {
            if (strInt == 1)
            {
                strModInt = -5;
                strength = "1";
                strMod = "-5";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 2)
            {
                strModInt = -4;
                strength = "2";
                strMod = "-4";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 3)
            {
                strModInt = -4;
                strength = "3";
                strMod = "-4";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 4)
            {
                strModInt = -3;
                strength = "4";
                strMod = "-3";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 4)
            {
                strModInt = -3;
                strength = "4";
                strMod = "-4";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 5)
            {
                strModInt = -3;
                strength = "5";
                strMod = "-3";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 6)
            {
                strModInt = -2;
                strength = "6";
                strMod = "-2";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 7)
            {
                strModInt = -2;
                strength = "7";
                strMod = "-2";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 8)
            {
                strModInt = -1;
                strength = "8";
                strMod = "-1";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 9)
            {
                strModInt = -1;
                strength = "9";
                strMod = "-1";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 10)
            {
                strModInt = 0;
                strength = "10";
                strMod = "0";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 11)
            {
                strModInt = 0;
                strength = "11";
                strMod = "0";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 12)
            {
                strModInt = 1;
                strength = "12";
                strMod = "1";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 13)
            {
                strModInt = 1;
                strength = "13";
                strMod = "1";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 14)
            {
                strModInt = 2;
                strength = "14";
                strMod = "2";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 15)
            {
                strModInt = 2;
                strength = "15";
                strMod = "2";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 16)
            {
                strModInt = 3;
                strength = "16";
                strMod = "3";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 17)
            {
                strModInt = 3;
                strength = "17";
                strMod = "3";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 18)
            {
                strModInt = 4;
                strength = "18";
                strMod = "4";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 19)
            {
                strModInt = 4;
                strength = "19";
                strMod = "4";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 20)
            {
                strModInt = 5;
                strength = "20";
                strMod = "5";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 21)
            {
                strModInt = 5;
                strength = "21";
                strMod = "5";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 22)
            {
                strModInt = 6;
                strength = "22";
                strMod = "6";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 23)
            {
                strModInt = 6;
                strength = "23";
                strMod = "6";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 24)
            {
                strModInt = 7;
                strength = "24";
                strMod = "7";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 25)
            {
                strModInt = 7;
                strength = "25";
                strMod = "7";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 26)
            {
                strModInt = 8;
                strength = "26";
                strMod = "8";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 27)
            {
                strModInt = 8;
                strength = "27";
                strMod = "8";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 28)
            {
                strModInt = 9;
                strength = "28";
                strMod = "9";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 29)
            {
                strModInt = 9;
                strength = "29";
                strMod = "9";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 30)
            {
                strModInt = 10;
                strength = "30";
                strMod = "10";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
            }
            else if (strInt == 0)
            {
                strModInt = -5;
                strength = "1";
                strMod = "-5";
                txtbxStr.Text = strength;
                txtbxStrMod.Text = strMod;
                MessageBox.Show("Invalid Entry: Value cannot be 0 or empty.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SetDex()
        {
            if (dexInt == 1)
            {
                dexModInt = -5;
                dexterity = "1";
                dexMod = "-5";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 2)
            {
                dexModInt = -4;
                dexterity = "2";
                dexMod = "-4";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 3)
            {
                dexModInt = -4;
                dexterity = "3";
                dexMod = "-4";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 4)
            {
                dexModInt = -3;
                dexterity = "4";
                dexMod = "-3";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 5)
            {
                dexModInt = -3;
                dexterity = "5";
                dexMod = "-3";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 6)
            {
                dexModInt = -2;
                dexterity = "6";
                dexMod = "-2";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 7)
            {
                dexModInt = -2;
                dexterity = "7";
                dexMod = "-2";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 8)
            {
                dexModInt = -1;
                dexterity = "8";
                dexMod = "-1";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 9)
            {
                dexModInt = -1;
                dexterity = "9";
                dexMod = "-1";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 10)
            {
                dexModInt = 0;
                dexterity = "10";
                dexMod = "0";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 11)
            {
                dexModInt = 0;
                dexterity = "11";
                dexMod = "0";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 12)
            {
                dexModInt = 1;
                dexterity = "12";
                dexMod = "1";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 13)
            {
                dexModInt = 1;
                dexterity = "13";
                dexMod = "1";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 14)
            {
                dexModInt = 2;
                dexterity = "14";
                dexMod = "2";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 15)
            {
                dexModInt = 2;
                dexterity = "15";
                dexMod = "2";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 16)
            {
                dexModInt = 3;
                dexterity = "16";
                dexMod = "3";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 17)
            {
                dexModInt = 3;
                dexterity = "17";
                dexMod = "3";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 18)
            {
                dexModInt = 4;
                dexterity = "18";
                dexMod = "4";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 19)
            {
                dexModInt = 4;
                dexterity = "19";
                dexMod = "4";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 20)
            {
                dexModInt = 5;
                dexterity = "20";
                dexMod = "5";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 21)
            {
                dexModInt = 5;
                dexterity = "21";
                dexMod = "5";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 22)
            {
                dexModInt = 6;
                dexterity = "22";
                dexMod = "6";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 23)
            {
                dexModInt = 6;
                dexterity = "23";
                dexMod = "6";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 24)
            {
                dexModInt = 7;
                dexterity = "24";
                dexMod = "7";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 25)
            {
                dexModInt = 7;
                dexterity = "25";
                dexMod = "7";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 26)
            {
                dexModInt = 8;
                dexterity = "26";
                dexMod = "8";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 27)
            {
                dexModInt = 8;
                dexterity = "27";
                dexMod = "8";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 28)
            {
                dexModInt = 9;
                dexterity = "28";
                dexMod = "9";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 29)
            {
                dexModInt = 9;
                dexterity = "29";
                dexMod = "9";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 30)
            {
                dexModInt = 10;
                dexterity = "30";
                dexMod = "10";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
            }
            else if (dexInt == 0)
            {
                dexModInt = -5;
                dexterity = "1";
                dexMod = "-5";
                txtbxDex.Text = dexterity;
                txtbxDexMod.Text = dexMod;
                MessageBox.Show("Invalid Entrey: Value cannot be 0 or empty.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SetCon()
        {
            if (conInt == 1)
            {
                conModInt = -5;
                constitution = "1";
                conMod = "-5";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 2)
            {
                conModInt = -4;
                constitution = "2";
                conMod = "-4";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 3)
            {
                conModInt = -4;
                constitution = "3";
                conMod = "-4";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 4)
            {
                conModInt = -3;
                constitution = "4";
                conMod = "-3";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 5)
            {
                conModInt = -3;
                constitution = "5";
                conMod = "-3";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 6)
            {
                conModInt = -2;
                constitution = "6";
                conMod = "-2";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 7)
            {
                conModInt = -2;
                constitution = "7";
                conMod = "-2";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 8)
            {
                conModInt = -1;
                constitution = "8";
                conMod = "-1";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 9)
            {
                conModInt = -1;
                constitution = "9";
                conMod = "-1";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 10)
            {
                conModInt = 0;
                constitution = "10";
                conMod = "0";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 11)
            {
                conModInt = 0;
                constitution = "11";
                conMod = "0";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 12)
            {
                conModInt = 1;
                constitution = "12";
                conMod = "1";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 13)
            {
                conModInt = 1;
                constitution = "13";
                conMod = "1";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 14)
            {
                conModInt = 2;
                constitution = "14";
                conMod = "2";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 15)
            {
                conModInt = 2;
                constitution = "15";
                conMod = "2";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 16)
            {
                conModInt = 3;
                constitution = "16";
                conMod = "3";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 17)
            {
                conModInt = 3;
                constitution = "17";
                conMod = "3";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 18)
            {
                conModInt = 4;
                constitution = "18";
                conMod = "4";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 19)
            {
                conModInt = 4;
                constitution = "19";
                conMod = "4";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 20)
            {
                conModInt = 5;
                constitution = "20";
                conMod = "5";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 21)
            {
                conModInt = 5;
                constitution = "21";
                conMod = "5";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 22)
            {
                conModInt = 6;
                constitution = "22";
                conMod = "6";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 23)
            {
                conModInt = 6;
                constitution = "23";
                conMod = "6";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 24)
            {
                conModInt = 7;
                constitution = "24";
                conMod = "7";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 25)
            {
                conModInt = 7;
                constitution = "25";
                conMod = "7";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 26)
            {
                conModInt = 8;
                constitution = "26";
                conMod = "8";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 27)
            {
                conModInt = 8;
                constitution = "27";
                conMod = "8";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 28)
            {
                conModInt = 9;
                constitution = "28";
                conMod = "9";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 29)
            {
                conModInt = 9;
                constitution = "29";
                conMod = "9";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 30)
            {
                conModInt = 10;
                constitution = "30";
                conMod = "10";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
            }
            else if (conInt == 0)
            {
                conModInt = -5;
                constitution = "1";
                conMod = "-5";
                txtbxCon.Text = constitution;
                txtbxConMod.Text = conMod;
                MessageBox.Show("Invalid Entry: Value cannot be 0 or empty.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SetInt()
        {
            if (wisInt == 1)
            {
                wisModInt = -5;
                wisdom = "1";
                wisMod = "-5";
                txtbxWis.Text = wisdom;
                txtbxWisMod.Text = wisMod;
            }
        }
        public void SetWis()
        {

        }
        public void SetCha()
        {

        }



        private void CharSheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons confirmExit = MessageBoxButtons.OKCancel;
            DialogResult exiting = MessageBox.Show("Are you sure you want to quit? All progress will be lost.", "Warning", confirmExit, MessageBoxIcon.Warning);
            if (exiting == DialogResult.OK)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
            else if (exiting == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        public void CharSheet_Load(object sender, EventArgs e)
        {
            
        }

     
        //Transfers all existing equations from BuildCharacter to CharSheet, called in BuildCharacter
        public void Transfer()
        {

        }

        public void btnDieRoll_Click(object sender, EventArgs e)
        {
            DieRoller openDr = new DieRoller();
            openDr.Show();
        }
    }
}
