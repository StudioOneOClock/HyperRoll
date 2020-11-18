using HyperRoll.ClassSheets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperRoll
{
    public partial class BuildCharacter : Form
    {
        //WORKING ON
        //Started implementing functions for selected race, but finish GenerateAbilities() first
        //Working on Dwarf racial selection via character.whatever
        //Need to set new SetAb() methods for CharSheet class
        //Working on Die Roller

        //FIX
        //Fix dialog boxes for generating when values are invalid
        //For some reason you have to hit the save and generate button 4 times


        //REFERENCES
        CharSheet character = new CharSheet();
        //cacapoopoo


        //INFO
        public string playerName;
        public string charName;
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



        //ABILITIES

        //Ability Score Integers
        public static int intPlayerStr;
        public static int intPlayerDex;
        public static int intPlayerCon;
        public static int intPlayerInt;
        public static int intPlayerWis;
        public static int intPlayerCha;

        //Ability Score Strings
        public static string strPlayerStr;
        public static string strPlayerDex;
        public static string strPlayerCon;
        public static string strPlayerInt;
        public static string strPlayerWis;
        public static string strPlayerCha;

        //Modifier Integers
        public static int intPlayerStrMod;
        public static int intPlayerDexMod;
        public static int intPlayerConMod;
        public static int intPlayerIntMod;
        public static int intPlayerWisMod;
        public static int intPlayerChaMod;

        //Modifier Strings
        public static string strPlayerStrMod;
        public static string strPlayerDexMod;
        public static string strPlayerConMod;
        public static string strPlayerIntMod;
        public static string strPlayerWisMod;
        public static string strPlayerChaMod;

        //Size
        public static string playerSize;

        //Booleans
        public bool infoComplete = false;
        public bool raceComplete = false;
        public bool classComplete = false;
            
        public bool featComplete = false;
        public bool skillComplete = false;
        public bool spellComplete = false;
        public bool equipComplete = false;
        public bool strComplete = false;
        public bool dexComplete = false;
        public bool conComplete = false;
        public bool intComplete = false;
        public bool wisComplete = false;
        public bool chaComplete = false;

        public bool isHuman = false;
        public bool isElf = false;
        public bool isHalfling = false;
        public bool isHalfElf = false;
        public bool isHalfOrc = false;
        public bool isGnome = false;
        public bool isDwarf = false;

        


        public bool isSatan = false;

        //End of datatypes

        public BuildCharacter()
        {
            InitializeComponent();
        }

        
        //METHODS

        //User defined methods

        //Rolls random ability stats
        public void RollRandom()
        {
            //Initialize Randomizer
            Random abilityRandomizer = new Random();
            int minScore = 3;
            int maxScore = 19;

            //Set integer value
            intPlayerStr = abilityRandomizer.Next(minScore, maxScore);
            intPlayerDex =  abilityRandomizer.Next(minScore, maxScore);
            intPlayerCon = abilityRandomizer.Next(minScore, maxScore);
            intPlayerInt = abilityRandomizer.Next(minScore, maxScore);
            intPlayerWis = abilityRandomizer.Next(minScore, maxScore);
            intPlayerCha = abilityRandomizer.Next(minScore, maxScore);

            //Set string value
            strPlayerStr = intPlayerStr.ToString();
            strPlayerDex = intPlayerDex.ToString();
            strPlayerCon = intPlayerCon.ToString();
            strPlayerInt = intPlayerInt.ToString();
            strPlayerWis = intPlayerWis.ToString();
            strPlayerCha = intPlayerCha.ToString();

            //Set TextBoxes
            txtbxStr.Text = strPlayerStr;
            //txtbxStr.ReadOnly = true;
            txtbxDex.Text = strPlayerDex;
            //txtbxDex.ReadOnly = true;
            txtbxCon.Text = strPlayerCon;
            //txtbxCon.ReadOnly = true;
            txtbxInt.Text = strPlayerInt;
            //txtbxInt.ReadOnly = true;
            txtbxWis.Text = strPlayerWis;
            //txtbxWis.ReadOnly = true;
            txtbxCha.Text = strPlayerCha;
            //txtbxCha.ReadOnly = true;

            //Other
            //btnRollRandom.Enabled = false;
            //btnRollRandom.Text = "Random roll used";

        }

        //Sets readonly values for abilities and ability mods
        public void SetStr()
        {
            if (txtbxStr.Text == "1")
            {
                txtbxStrMod.Text = "-5";
                intPlayerStr = 1;
                strPlayerStr ="1";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = -5;
                strComplete = true;
            }
            else if (txtbxStr.Text == "2")
            {
                txtbxStrMod.Text = "-4";
                intPlayerStr = 2;
                strPlayerStr ="2";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = -4;
                strComplete = true;
            }
            else if (txtbxStr.Text == "3")
            {
                txtbxStrMod.Text = "-4";
                intPlayerStr = 3;
                strPlayerStr ="3";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = -4;
                strComplete = true;
            }
            else if (txtbxStr.Text == "4")
            {
                txtbxStrMod.Text = "-3";
                intPlayerStr = 4;
                strPlayerStr ="4";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = -3;
                strComplete = true;
            }
            else if (txtbxStr.Text == "5")
            {
                txtbxStrMod.Text = "-3";
                intPlayerStr = 5;
                strPlayerStr ="5";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = -3;
                strComplete = true;
            }
            else if (txtbxStr.Text == "6")
            {
                txtbxStrMod.Text = "-2";
                intPlayerStr = 6;
                strPlayerStr ="6";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = -2;
                strComplete = true;
            }
            else if (txtbxStr.Text == "7")
            {
                txtbxStrMod.Text ="-2";
                intPlayerStr = 7;
                strPlayerStr ="7";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = -2;
                strComplete = true;
            }
            else if (txtbxStr.Text == "8")
            {
                txtbxStrMod.Text = "-1";
                intPlayerStr = 8;
                strPlayerStr ="8";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = -1;
            }
            else if (txtbxStr.Text == "9")
            {
                txtbxStrMod.Text = "-1";
                intPlayerStr = 9;
                strPlayerStr ="9";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = -1;
                strComplete = true;
            }
            else if (txtbxStr.Text == "10")
            {
                txtbxStrMod.Text = "0";
                intPlayerStr = 10;
                strPlayerStr ="10";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 0;
                strComplete = true;
            }
            else if (txtbxStr.Text == "11")
            {
                txtbxStrMod.Text = "0";
                intPlayerStr = 11;
                strPlayerStr ="11";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 0;
                strComplete = true;
            }
            else if (txtbxStr.Text == "12")
            {
                txtbxStrMod.Text = "+1";
                intPlayerStr = 12;
                strPlayerStr ="12";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 1;
                strComplete = true;
            }
            else if (txtbxStr.Text == "13")
            {
                txtbxStrMod.Text = "+1";
                intPlayerStr = 13;
                strPlayerStr ="13";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 1;
                strComplete = true;
            }
            else if (txtbxStr.Text == "14")
            {
                txtbxStrMod.Text = "+2";
                intPlayerStr = 14;
                strPlayerStr ="14";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 2;
                strComplete = true;
            }
            else if (txtbxStr.Text == "15")
            {
                txtbxStrMod.Text = "+2";
                intPlayerStr = 15;
                strPlayerStr ="15";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 2;
                strComplete = true;
            }
            else if (txtbxStr.Text == "16")
            {
                txtbxStrMod.Text = "+3";
                intPlayerStr = 16;
                strPlayerStr ="16";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 3;
                strComplete = true;
            }
            else if (txtbxStr.Text == "17")
            {
                txtbxStrMod.Text = "+3";
                intPlayerStr = 17;
                strPlayerStr ="17";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 3;
                strComplete = true;
            }
            else if (txtbxStr.Text == "18")
            {
                txtbxStrMod.Text = "+4";
                intPlayerStr = 18;
                strPlayerStr ="18";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 4;
                strComplete = true;
            }
            else if (txtbxStr.Text == "19")
            {
                txtbxStrMod.Text = "+4";
                intPlayerStr = 19;
                strPlayerStr ="19";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 4;
                strComplete = true;
            }
            else if (txtbxStr.Text == "20")
            {
                txtbxStrMod.Text = "+5";
                intPlayerStr = 20;
                strPlayerStr ="20";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 5;
                strComplete = true;
            }
            else if (txtbxStr.Text == "21")
            {
                txtbxStrMod.Text = "+5";
                intPlayerStr = 21;
                strPlayerStr = "21";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 5;
                strComplete = true;
            }
            else if (txtbxStr.Text == "22")
            {
                txtbxStrMod.Text = "+6";
                intPlayerStr = 22;
                strPlayerStr = "22";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 6;
                strComplete = true;

            }
            else if (txtbxStr.Text == "23")
            {
                txtbxStrMod.Text = "+6";
                intPlayerStr = 23;
                strPlayerStr = "23";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 6;
                strComplete = true;
            }
            else if (txtbxStr.Text == "24")
            {
                txtbxStrMod.Text = "+7";
                intPlayerStr = 24;
                strPlayerStr = "24";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 7;
                strComplete = true;
            }
            else if (txtbxStr.Text == "25")
            {
                txtbxStrMod.Text = "+7";
                intPlayerStr = 25;
                strPlayerStr = "25";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 7;
                strComplete = true;
            }
            else if (txtbxStr.Text == "26")
            {
                txtbxStrMod.Text = "+8";
                intPlayerStr = 27;
                strPlayerStr = "27";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 8;
                strComplete = true;
            }
            else if (txtbxStr.Text == "27")
            {
                txtbxStrMod.Text = "+8";
                intPlayerStr = 27;
                strPlayerStr = "27";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 8;
                strComplete = true;
            }
            else if (txtbxStr.Text == "28")
            {
                txtbxStrMod.Text = "+9";
                intPlayerStr = 28;
                strPlayerStr = "28";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 9;
                strComplete = true;
            }
            else if (txtbxStr.Text == "29")
            {
                txtbxStrMod.Text = "+9";
                intPlayerStr = 29;
                strPlayerStr = "29";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 9;
                strComplete = true;
            }
            else if (txtbxStr.Text == "30")
            {
                txtbxStrMod.Text = "+10";
                intPlayerStr = 30;
                strPlayerStr = "30";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 10;
                strComplete = true;
            }
            else if (txtbxStr.Text == "")
            {
                txtbxStrMod.Text = "";
                intPlayerStr = 0;
                strPlayerStr = "";
                strPlayerStrMod = txtbxStrMod.Text;
                intPlayerStrMod = 0;
                strComplete = false;
            }
            else if (txtbxStr.Text == "0")
            {
                txtbxStr.Text = "";
                string errorMessage = "Input was invalid, value cannot be 0.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                strComplete = false;
            }
            else
            {
                txtbxStr.Text = "";
                string errorMessage = "Input was invalid, value must be a whole number greater than 0.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                strComplete = false;

            }
        }
        public void SetDex()
        {
            
            if (txtbxDex.Text == "1")
            {
                txtbxDexMod.Text = "-5";
                intPlayerDex = 1;
                strPlayerDex = "1";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = -5;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "2")
            {
                txtbxDexMod.Text = "-4";
                intPlayerDex = 2;
                strPlayerDex = "2";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = -4;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "3")
            {
                txtbxDexMod.Text = "-4";
                intPlayerDex = 3;
                strPlayerDex = "3";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = -4;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "4")
            {
                txtbxDexMod.Text = "-3";
                intPlayerDex = 4;
                strPlayerDex = "4";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = -3;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "5")
            {
                txtbxDexMod.Text = "-3";
                intPlayerDex = 5;
                strPlayerDex = "5";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = -3;
                dexComplete = true;
            }
            
            else if (txtbxDex.Text == "6")
            {
                txtbxDexMod.Text = "-2";
                intPlayerDex = 6;
                strPlayerDex = "6";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = -2;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "7")
            {
                txtbxDexMod.Text = "-2";
                intPlayerDex = 7;
                strPlayerDex = "7";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = -2;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "8")
            {
                txtbxDexMod.Text = "-1";
                intPlayerDex = 8;
                strPlayerDex = "8";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = -1;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "9")
            {
                txtbxDexMod.Text = "-1";
                intPlayerDex = 9;
                strPlayerDex = "9";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = -1;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "10")
            {
                txtbxDexMod.Text = "0";
                intPlayerDex = 10;
                strPlayerDex = "10";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 0;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "11")
            {
                txtbxDexMod.Text = "0";
                intPlayerDex = 11;
                strPlayerDex = "11";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 0;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "12")
            {
                txtbxDexMod.Text = "+1";
                intPlayerDex = 12;
                strPlayerDex = "12";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 1;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "13")
            {
                txtbxDexMod.Text = "+1";
                intPlayerDex = 13;
                strPlayerDex = "13";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 1;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "14")
            {
                txtbxDexMod.Text = "+2";
                intPlayerDex = 14;
                strPlayerDex = "14";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 2;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "15")
            {
                txtbxDexMod.Text = "+2";
                intPlayerDex = 15;
                strPlayerDex = "15";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 2;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "16")
            {
                txtbxDexMod.Text = "+3";
                intPlayerDex = 16;
                strPlayerDex = "16";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 3;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "17")
            {
                txtbxDexMod.Text = "+3";
                intPlayerDex = 17;
                strPlayerDex = "17";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 3;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "18")
            {
                txtbxDexMod.Text = "+4";
                intPlayerDex = 18;
                strPlayerDex = "18";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 4;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "19")
            {
                txtbxDexMod.Text = "+4";
                intPlayerDex = 19;
                strPlayerDex = "19";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 4;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "20")
            {
                txtbxDexMod.Text = "+5";
                intPlayerDex = 20;
                strPlayerDex = "20";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 5;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "21")
            {
                txtbxDexMod.Text = "+5";
                intPlayerDex = 21;
                strPlayerDex = "21";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 5;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "22")
            {
                txtbxDexMod.Text = "+6";
                intPlayerDex = 22;
                strPlayerDex = "22";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 6;
                dexComplete = true;

            }
            else if (txtbxDex.Text == "23")
            {
                txtbxDexMod.Text = "+6";
                intPlayerDex = 23;
                strPlayerDex = "23";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 6;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "24")
            {
                txtbxDexMod.Text = "+7";
                intPlayerDex = 24;
                strPlayerDex = "24";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 7;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "25")
            {
                txtbxDexMod.Text = "+7";
                intPlayerDex = 25;
                strPlayerDex = "25";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 7;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "26")
            {
                txtbxDexMod.Text = "+8";
                intPlayerDex = 27;
                strPlayerDex = "27";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 8;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "27")
            {
                txtbxDexMod.Text = "+8";
                intPlayerDex = 27;
                strPlayerDex = "27";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 8;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "28")
            {
                txtbxDexMod.Text = "+9";
                intPlayerDex = 28;
                strPlayerDex = "28";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 9;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "29")
            {
                txtbxDexMod.Text = "+9";
                intPlayerDex = 29;
                strPlayerDex = "29";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 9;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "30")
            {
                txtbxDexMod.Text = "+10";
                intPlayerDex = 30;
                strPlayerDex = "30";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 10;
                dexComplete = true;
            }
            else if (txtbxDex.Text == "0")
            {
                txtbxDex.Text = "";
                string errorMessage = "Input was invalid, value cannot be 0.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                dexComplete = false;
            }
            else if (txtbxDex.Text == "")
            {
                txtbxDexMod.Text = "";
                intPlayerDex = 0;
                strPlayerDex = "";
                strPlayerDexMod = txtbxDexMod.Text;
                intPlayerDexMod = 0;
                dexComplete = false;
            }
            else
            {
                txtbxDex.Text = "";
                string errorMessage = "Input was invalid, please make sure you type a number value.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                dexComplete = false;
            }
        }
        public void SetCon()
        {
            if (txtbxCon.Text == "1")
            {
                txtbxConMod.Text = "-5";
                intPlayerCon = 1;
                strPlayerCon = "1";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = -5;
                conComplete = true;
            }
            else if (txtbxCon.Text == "2")
            {
                txtbxConMod.Text = "-4";
                intPlayerCon = 2;
                strPlayerCon = "2";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = -4;
                conComplete = true;
            }
            else if (txtbxCon.Text == "3")
            {
                txtbxConMod.Text = "-4";
                intPlayerCon = 3;
                strPlayerCon = "3";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = -4;
                conComplete = true;
            }
            else if (txtbxCon.Text == "4")
            {
                txtbxConMod.Text = "-3";
                intPlayerCon = 4;
                strPlayerCon = "4";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = -3;
                conComplete = true;
            }
            else if (txtbxCon.Text == "5")
            {
                txtbxConMod.Text = "-3";
                intPlayerCon = 5;
                strPlayerCon = "5";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = -3;
                conComplete = true;
            }

            else if (txtbxCon.Text == "6")
            {
                txtbxConMod.Text = "-2";
                intPlayerCon = 6;
                strPlayerCon = "6";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = -2;
                conComplete = true;
            }
            else if (txtbxCon.Text == "7")
            {
                txtbxConMod.Text = "-2";
                intPlayerCon = 7;
                strPlayerCon = "7";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = -2;
                conComplete = true;
            }
            else if (txtbxCon.Text == "8")
            {
                txtbxConMod.Text = "-1";
                intPlayerCon = 8;
                strPlayerCon = "8";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = -1;
                conComplete = true;
            }
            else if (txtbxCon.Text == "9")
            {
                txtbxConMod.Text = "-1";
                intPlayerCon = 9;
                strPlayerCon = "9";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = -1;
                conComplete = true;
            }
            else if (txtbxCon.Text == "10")
            {
                txtbxConMod.Text = "0";
                intPlayerCon = 10;
                strPlayerCon = "10";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 0;
                conComplete = true;
            }
            else if (txtbxCon.Text == "11")
            {
                txtbxConMod.Text = "0";
                intPlayerCon = 11;
                strPlayerCon = "11";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 0;
                conComplete = true;
            }
            else if (txtbxCon.Text == "12")
            {
                txtbxConMod.Text = "+1";
                intPlayerCon = 12;
                strPlayerCon = "12";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 1;
                conComplete = true;
            }
            else if (txtbxCon.Text == "13")
            {
                txtbxConMod.Text = "+1";
                intPlayerCon = 13;
                strPlayerCon = "13";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 1;
                conComplete = true;
            }
            else if (txtbxCon.Text == "14")
            {
                txtbxConMod.Text = "+2";
                intPlayerCon = 14;
                strPlayerCon = "14";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 2;
                conComplete = true;
            }
            else if (txtbxCon.Text == "15")
            {
                txtbxConMod.Text = "+2";
                intPlayerCon = 15;
                strPlayerCon = "15";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 2;
                conComplete = true;
            }
            else if (txtbxCon.Text == "16")
            {
                txtbxConMod.Text = "+3";
                intPlayerCon = 16;
                strPlayerCon = "16";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 3;
                conComplete = true;
            }
            else if (txtbxCon.Text == "17")
            {
                txtbxConMod.Text = "+3";
                intPlayerCon = 17;
                strPlayerCon = "17";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 3;
                conComplete = true;
            }
            else if (txtbxCon.Text == "18")
            {
                txtbxConMod.Text = "+4";
                intPlayerCon = 18;
                strPlayerCon = "18";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 4;
                conComplete = true;
            }
            else if (txtbxCon.Text == "19")
            {
                txtbxConMod.Text = "+4";
                intPlayerCon = 19;
                strPlayerCon = "19";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 4;
                conComplete = true;
            }
            else if (txtbxCon.Text == "20")
            {
                txtbxConMod.Text = "+5";
                intPlayerCon = 20;
                strPlayerCon = "20";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 5;
                conComplete = true;
            }
            else if (txtbxCon.Text == "21")
            {
                txtbxConMod.Text = "+5";
                intPlayerCon = 21;
                strPlayerCon = "21";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 5;
                conComplete = true;
            }
            else if (txtbxCon.Text == "22")
            {
                txtbxConMod.Text = "+6";
                intPlayerCon = 22;
                strPlayerCon = "22";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 6;
                conComplete = true;

            }
            else if (txtbxCon.Text == "23")
            {
                txtbxConMod.Text = "+6";
                intPlayerCon = 23;
                strPlayerCon = "23";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 6;
                conComplete = true;
            }
            else if (txtbxCon.Text == "24")
            {
                txtbxConMod.Text = "+7";
                intPlayerCon = 24;
                strPlayerCon = "24";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 7;
                conComplete = true;
            }
            else if (txtbxCon.Text == "25")
            {
                txtbxConMod.Text = "+7";
                intPlayerCon = 25;
                strPlayerCon = "25";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 7;
                conComplete = true;
            }
            else if (txtbxCon.Text == "26")
            {
                txtbxConMod.Text = "+8";
                intPlayerCon = 27;
                strPlayerCon = "27";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 8;
                conComplete = true;
            }
            else if (txtbxCon.Text == "27")
            {
                txtbxConMod.Text = "+8";
                intPlayerCon = 27;
                strPlayerCon = "27";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 8;
                conComplete = true;
            }
            else if (txtbxCon.Text == "28")
            {
                txtbxConMod.Text = "+9";
                intPlayerCon = 28;
                strPlayerCon = "28";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 9;
                conComplete = true;
            }
            else if (txtbxCon.Text == "29")
            {
                txtbxConMod.Text = "+9";
                intPlayerCon = 29;
                strPlayerCon = "29";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 9;
                conComplete = true;
            }
            else if (txtbxCon.Text == "30")
            {
                txtbxConMod.Text = "+10";
                intPlayerCon = 30;
                strPlayerCon = "30";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 10;
                conComplete = true;
            }
            else if (txtbxCon.Text == "0")
            {
                txtbxCon.Text = "";
                string errorMessage = "Input was invalid, value cannot be 0.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                conComplete = false;
            }
            else if (txtbxCon.Text == "")
            {
                txtbxConMod.Text = "";
                intPlayerCon = 0;
                strPlayerCon = "";
                strPlayerConMod = txtbxConMod.Text;
                intPlayerConMod = 0;
                conComplete = false;
            }
            else
            {
                txtbxCon.Text = "";
                string errorMessage = "Input was invalid, please make sure you type a number value.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                conComplete = false;
            }
        }
        public void SetInt()
        {
            if (txtbxInt.Text == "1")
            {
                txtbxIntMod.Text = "-5";
                intPlayerInt = 1;
                strPlayerInt = "1";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = -5;
                intComplete = true;
            }
            else if (txtbxInt.Text == "2")
            {
                txtbxIntMod.Text = "-4";
                intPlayerInt = 2;
                strPlayerInt = "2";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = -4;
                intComplete = true;
            }
            else if (txtbxInt.Text == "3")
            {
                txtbxIntMod.Text = "-4";
                intPlayerInt = 3;
                strPlayerInt = "3";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = -4;
                intComplete = true;
            }
            else if (txtbxInt.Text == "4")
            {
                txtbxIntMod.Text = "-3";
                intPlayerInt = 4;
                strPlayerInt = "4";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = -3;
                intComplete = true;
            }
            else if (txtbxInt.Text == "5")
            {
                txtbxIntMod.Text = "-3";
                intPlayerInt = 5;
                strPlayerInt = "5";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = -3;
                intComplete = true;
            }

            else if (txtbxInt.Text == "6")
            {
                txtbxIntMod.Text = "-2";
                intPlayerInt = 6;
                strPlayerInt = "6";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = -2;
                intComplete = true;
            }
            else if (txtbxInt.Text == "7")
            {
                txtbxIntMod.Text = "-2";
                intPlayerInt = 7;
                strPlayerInt = "7";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = -2;
                intComplete = true;
            }
            else if (txtbxInt.Text == "8")
            {
                txtbxIntMod.Text = "-1";
                intPlayerInt = 8;
                strPlayerInt = "8";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = -1;
                intComplete = true;
            }
            else if (txtbxInt.Text == "9")
            {
                txtbxIntMod.Text = "-1";
                intPlayerInt = 9;
                strPlayerInt = "9";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = -1;
                intComplete = true;
            }
            else if (txtbxInt.Text == "10")
            {
                txtbxIntMod.Text = "0";
                intPlayerInt = 10;
                strPlayerInt = "10";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 0;
                intComplete = true;
            }
            else if (txtbxInt.Text == "11")
            {
                txtbxIntMod.Text = "0";
                intPlayerInt = 11;
                strPlayerInt = "11";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 0;
                intComplete = true;
            }
            else if (txtbxInt.Text == "12")
            {
                txtbxIntMod.Text = "+1";
                intPlayerInt = 12;
                strPlayerInt = "12";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 1;
                intComplete = true;
            }
            else if (txtbxInt.Text == "13")
            {
                txtbxIntMod.Text = "+1";
                intPlayerInt = 13;
                strPlayerInt = "13";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 1;
                intComplete = true;
            }
            else if (txtbxInt.Text == "14")
            {
                txtbxIntMod.Text = "+2";
                intPlayerInt = 14;
                strPlayerInt = "14";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 2;
                intComplete = true;
            }
            else if (txtbxInt.Text == "15")
            {
                txtbxIntMod.Text = "+2";
                intPlayerInt = 15;
                strPlayerInt = "15";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 2;
                intComplete = true;
            }
            else if (txtbxInt.Text == "16")
            {
                txtbxIntMod.Text = "+3";
                intPlayerInt = 16;
                strPlayerInt = "16";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 3;
                intComplete = true;
            }
            else if (txtbxInt.Text == "17")
            {
                txtbxIntMod.Text = "+3";
                intPlayerInt = 17;
                strPlayerInt = "17";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 3;
                intComplete = true;
            }
            else if (txtbxInt.Text == "18")
            {
                txtbxIntMod.Text = "+4";
                intPlayerInt = 18;
                strPlayerInt = "18";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 4;
                intComplete = true;
            }
            else if (txtbxInt.Text == "19")
            {
                txtbxIntMod.Text = "+4";
                intPlayerInt = 19;
                strPlayerInt = "19";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 4;
                intComplete = true;
            }
            else if (txtbxInt.Text == "20")
            {
                txtbxIntMod.Text = "+5";
                intPlayerInt = 20;
                strPlayerInt = "20";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 5;
                intComplete = true;
            }
            else if (txtbxInt.Text == "21")
            {
                txtbxIntMod.Text = "+5";
                intPlayerInt = 21;
                strPlayerInt = "21";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 5;
                intComplete = true;
            }
            else if (txtbxInt.Text == "22")
            {
                txtbxIntMod.Text = "+6";
                intPlayerInt = 22;
                strPlayerInt = "22";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 6;
                intComplete = true;

            }
            else if (txtbxInt.Text == "23")
            {
                txtbxIntMod.Text = "+6";
                intPlayerInt = 23;
                strPlayerInt = "23";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 6;
                intComplete = true;
            }
            else if (txtbxInt.Text == "24")
            {
                txtbxIntMod.Text = "+7";
                intPlayerInt = 24;
                strPlayerInt = "24";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 7;
                intComplete = true;
            }
            else if (txtbxInt.Text == "25")
            {
                txtbxIntMod.Text = "+7";
                intPlayerInt = 25;
                strPlayerInt = "25";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 7;
                intComplete = true;
            }
            else if (txtbxInt.Text == "26")
            {
                txtbxIntMod.Text = "+8";
                intPlayerInt = 27;
                strPlayerInt = "27";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 8;
                intComplete = true;
            }
            else if (txtbxInt.Text == "27")
            {
                txtbxIntMod.Text = "+8";
                intPlayerInt = 27;
                strPlayerInt = "27";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 8;
                intComplete = true;
            }
            else if (txtbxInt.Text == "28")
            {
                txtbxIntMod.Text = "+9";
                intPlayerInt = 28;
                strPlayerInt = "28";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 9;
                intComplete = true;
            }
            else if (txtbxInt.Text == "29")
            {
                txtbxIntMod.Text = "+9";
                intPlayerInt = 29;
                strPlayerInt = "29";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 9;
                intComplete = true;
            }
            else if (txtbxInt.Text == "30")
            {
                txtbxIntMod.Text = "+10";
                intPlayerInt = 30;
                strPlayerInt = "30";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 10;
                intComplete = true;
            }
            else if (txtbxInt.Text == "0")
            {
                txtbxInt.Text = "";
                string errorMessage = "Input was invalid, value cannot be 0.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                intComplete = false;
            }
            else if (txtbxInt.Text == "")
            {
                txtbxIntMod.Text = "";
                intPlayerInt= 0;
                strPlayerInt= "";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = 0;
                intComplete = false;
            }
            else
            {
                txtbxInt.Text = "";
                string errorMessage = "Input was invalid, please make sure you type a number value.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                intComplete = false;

            }
        }
        public void SetWis()
        {
            if (txtbxWis.Text == "1")
            {
                txtbxWisMod.Text = "-5";
                intPlayerWis = 1;
                strPlayerWis = "1";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = -5;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "2")
            {
                txtbxIntMod.Text = "-4";
                intPlayerInt = 2;
                strPlayerInt = "2";
                strPlayerIntMod = txtbxIntMod.Text;
                intPlayerIntMod = -4;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "3")
            {
                txtbxWisMod.Text = "-4";
                intPlayerWis = 3;
                strPlayerWis = "3";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = -4;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "4")
            {
                txtbxWisMod.Text = "-3";
                intPlayerWis = 4;
                strPlayerWis = "4";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = -3;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "5")
            {
                txtbxWisMod.Text = "-3";
                intPlayerWis = 5;
                strPlayerWis = "5";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = -3;
                wisComplete = true;
            }

            else if (txtbxWis.Text == "6")
            {
                txtbxWisMod.Text = "-2";
                intPlayerWis = 6;
                strPlayerWis = "6";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = -2;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "7")
            {
                txtbxWisMod.Text = "-2";
                intPlayerWis = 7;
                strPlayerWis = "7";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = -2;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "8")
            {
                txtbxWisMod.Text = "-1";
                intPlayerWis = 8;
                strPlayerWis = "8";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = -1;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "9")
            {
                txtbxWisMod.Text = "-1";
                intPlayerWis = 9;
                strPlayerWis = "9";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = -1;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "10")
            {
                txtbxWisMod.Text = "0";
                intPlayerWis = 10;
                strPlayerWis = "10";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 0;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "11")
            {
                txtbxWisMod.Text = "0";
                intPlayerWis = 11;
                strPlayerWis = "11";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 0;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "12")
            {
                txtbxWisMod.Text = "+1";
                intPlayerWis = 12;
                strPlayerWis = "12";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 1;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "13")
            {
                txtbxWisMod.Text = "+1";
                intPlayerWis = 13;
                strPlayerWis = "13";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 1;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "14")
            {
                txtbxWisMod.Text = "+2";
                intPlayerWis = 14;
                strPlayerWis = "14";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 2;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "15")
            {
                txtbxWisMod.Text = "+2";
                intPlayerWis = 15;
                strPlayerWis = "15";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 2;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "16")
            {
                txtbxWisMod.Text = "+3";
                intPlayerWis = 16;
                strPlayerWis = "16";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 3;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "17")
            {
                txtbxWisMod.Text = "+3";
                intPlayerWis = 17;
                strPlayerWis = "17";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 3;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "18")
            {
                txtbxWisMod.Text = "+4";
                intPlayerWis = 18;
                strPlayerWis = "18";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 4;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "19")
            {
                txtbxWisMod.Text = "+4";
                intPlayerWis = 19;
                strPlayerWis = "19";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 4;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "20")
            {
                txtbxWisMod.Text = "+5";
                intPlayerWis = 20;
                strPlayerWis = "20";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 5;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "21")
            {
                txtbxWisMod.Text = "+5";
                intPlayerWis = 21;
                strPlayerWis = "21";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 5;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "22")
            {
                txtbxWisMod.Text = "+6";
                intPlayerWis = 22;
                strPlayerWis = "22";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 6;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "23")
            {
                txtbxWisMod.Text = "+6";
                intPlayerWis = 23;
                strPlayerWis = "23";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 6;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "24")
            {
                txtbxWisMod.Text = "+7";
                intPlayerWis = 24;
                strPlayerWis = "24";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 7;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "25")
            {
                txtbxWisMod.Text = "+7";
                intPlayerWis = 25;
                strPlayerWis = "25";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 7;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "26")
            {
                txtbxWisMod.Text = "+8";
                intPlayerWis = 27;
                strPlayerWis = "27";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 8;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "27")
            {
                txtbxWisMod.Text = "+8";
                intPlayerWis = 27;
                strPlayerWis = "27";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 8;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "28")
            {
                txtbxWisMod.Text = "+9";
                intPlayerWis = 28;
                strPlayerWis = "28";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 9;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "29")
            {
                txtbxWisMod.Text = "+9";
                intPlayerWis = 29;
                strPlayerWis = "29";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 9;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "30")
            {
                txtbxWisMod.Text = "+10";
                intPlayerWis = 30;
                strPlayerWis = "30";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 10;
                wisComplete = true;
            }
            else if (txtbxWis.Text == "0")
            {
                txtbxWis.Text = "";
                string errorMessage = "Input was invalid, value cannot be 0.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                wisComplete = false;
            }
            else if (txtbxWis.Text == "")
            {
                txtbxWisMod.Text = "";
                intPlayerWis = 0;
                strPlayerWis = "";
                strPlayerWisMod = txtbxWisMod.Text;
                intPlayerWisMod = 0;
                wisComplete = false;
            }
            else
            {
                txtbxWis.Text = "";
                string errorMessage = "Input was invalid, please make sure you type a number value.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                wisComplete = false;

            }
        }
        public void SetCha()
        {
            if (txtbxCha.Text == "1")
            {
                txtbxChaMod.Text = "-5";
                intPlayerCha = 1;
                strPlayerCha = "1";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = -5;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "2")
            {
                txtbxChaMod.Text = "-4";
                intPlayerCha = 2;
                strPlayerCha = "2";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = -4;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "3")
            {
                txtbxChaMod.Text = "-4";
                intPlayerCha = 3;
                strPlayerCha = "3";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = -4;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "4")
            {
                txtbxChaMod.Text = "-3";
                intPlayerCha = 4;
                strPlayerCha = "4";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = -3;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "5")
            {
                txtbxChaMod.Text = "-3";
                intPlayerCha = 5;
                strPlayerCha = "5";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = -3;
                chaComplete = true;
            }

            else if (txtbxCha.Text == "6")
            {
                txtbxChaMod.Text = "-2";
                intPlayerCha = 6;
                strPlayerCha = "6";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = -2;
                chaComplete = true; ;
            }
            else if (txtbxCha.Text == "7")
            {
                txtbxChaMod.Text = "-2";
                intPlayerCha = 7;
                strPlayerCha = "7";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = -2;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "8")
            {
                txtbxChaMod.Text = "-1";
                intPlayerCha = 8;
                strPlayerCha = "8";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = -1;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "9")
            {
                txtbxChaMod.Text = "-1";
                intPlayerCha = 9;
                strPlayerCha = "9";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = -1;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "10")
            {
                txtbxChaMod.Text = "0";
                intPlayerCha = 10;
                strPlayerCha = "10";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 0;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "11")
            {
                txtbxChaMod.Text = "0";
                intPlayerCha = 11;
                strPlayerCha = "11";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 0;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "12")
            {
                txtbxChaMod.Text = "+1";
                intPlayerCha = 12;
                strPlayerCha = "12";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 1;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "13")
            {
                txtbxChaMod.Text = "+1";
                intPlayerCha = 13;
                strPlayerCha = "13";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 1;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "14")
            {
                txtbxChaMod.Text = "+2";
                intPlayerCha = 14;
                strPlayerCha = "14";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 2;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "15")
            {
                txtbxChaMod.Text = "+2";
                intPlayerCha = 15;
                strPlayerCha = "15";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 2;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "16")
            {
                txtbxChaMod.Text = "+3";
                intPlayerCha = 16;
                strPlayerCha = "16";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 3;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "17")
            {
                txtbxChaMod.Text = "+3";
                intPlayerCha = 17;
                strPlayerCha = "17";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 3;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "18")
            {
                txtbxChaMod.Text = "+4";
                intPlayerCha = 18;
                strPlayerCha = "18";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 4;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "19")
            {
                txtbxChaMod.Text = "+4";
                intPlayerCha = 19;
                strPlayerCha = "19";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 4;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "20")
            {
                txtbxChaMod.Text = "+5";
                intPlayerCha = 20;
                strPlayerCha = "20";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 5;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "21")
            {
                txtbxChaMod.Text = "+5";
                intPlayerCha = 21;
                strPlayerCha = "21";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 5;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "22")
            {
                txtbxChaMod.Text = "+6";
                intPlayerCha = 22;
                strPlayerCha = "22";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 6;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "23")
            {
                txtbxChaMod.Text = "+6";
                intPlayerCha = 23;
                strPlayerCha = "23";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 6;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "24")
            {
                txtbxChaMod.Text = "+7";
                intPlayerCha = 24;
                strPlayerCha = "24";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 7;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "25")
            {
                txtbxChaMod.Text = "+7";
                intPlayerCha = 25;
                strPlayerCha = "25";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 7;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "26")
            {
                txtbxChaMod.Text = "+8";
                intPlayerCha = 27;
                strPlayerCha = "27";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 8;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "27")
            {
                txtbxChaMod.Text = "+8";
                intPlayerCha = 27;
                strPlayerCha = "27";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 8;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "28")
            {
                txtbxChaMod.Text = "+9";
                intPlayerCha = 28;
                strPlayerCha = "28";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 9;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "29")
            {
                txtbxChaMod.Text = "+9";
                intPlayerCha = 29;
                strPlayerCha = "29";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 9;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "30")
            {
                txtbxChaMod.Text = "+10";
                intPlayerCha = 30;
                strPlayerCha = "30";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 10;
                chaComplete = true;
            }
            else if (txtbxCha.Text == "0")
            {
                txtbxCha.Text = "";
                string errorMessage = "Input was invalid, value cannot be 0.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                chaComplete = false;
            }
            else if (txtbxCha.Text == "")
            {
                txtbxChaMod.Text = "";
                intPlayerCha = 0;
                strPlayerCha = "";
                strPlayerChaMod = txtbxChaMod.Text;
                intPlayerChaMod = 0;
                chaComplete = false;
            }
            else
            {
                txtbxCha.Text = "";
                string errorMessage = "Input was invalid, please make sure you type a number value.";
                string errorTitle = "Warning!";
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                DialogResult errorResult = MessageBox.Show(errorMessage, errorTitle, errorButtons, MessageBoxIcon.Warning);
                chaComplete = false;
            }
        }

        

        //Checks if everything is generated before creating character sheet
        public void InfoCheck()
        {
            
            if (txtbxPlayerName.Text == "" || txtbxPlayerName.Text == " ")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Player Name", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxCharName.Text == "" || txtbxCharName.Text == " ")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Character Name", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxHeighFeet.Text == "" || txtbxHeighFeet.Text == " ")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Height, Feet", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxIn.Text == "" || txtbxIn.Text == " ")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Height, Inches", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxWeight.Text == "" || txtbxWeight.Text == " ")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Weight", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbAlignment.SelectedIndex.Equals(null) || cbAlignment.SelectedIndex.Equals(0))
            {
                MessageBox.Show("Cannot generate character. Missing values in: Alignment", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                infoComplete = true;
            }








        }
        public void StatCheck()
        {
            if (txtbxStr.Text == "" || txtbxStr.Text == " " || txtbxStr.Text == "0")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Strength", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxDex.Text == "" || txtbxDex.Text == " " || txtbxDex.Text == "0")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Dexterity", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxCon.Text == "" || txtbxCon.Text == " " || txtbxCon.Text == "0")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Constitution", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxInt.Text == "" || txtbxInt.Text == " " || txtbxInt.Text == "0")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Intelligence", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxWis.Text == "" || txtbxWis.Text == " " || txtbxWis.Text == "0")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Wisdom", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbxCha.Text == "" || txtbxCha.Text == " " || txtbxCha.Text == "0")
            {
                MessageBox.Show("Cannot generate character. Missing values in: Charisma", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                strComplete = true;
                dexComplete = true;
                conComplete = true;
                intComplete = true;
                wisComplete = true;
                chaComplete = true;
            }

        }
        public void RaceCheck()
        {
            if (lboxRace.SelectedIndex.Equals(0))
            {
                MessageBox.Show("Cannot generate character. Missing values in: Race", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                raceComplete = true;
            }
        }
        public void ClassCheck()
        {
            if (cbClassSelect1.Text == "Empty" || cbClassSelect1.SelectedIndex.Equals(0))
            {
                MessageBox.Show("Cannot generate character. Missing values in: Class 1", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                classComplete = true;
            }
        }
        public void FinalCheck()
        {
            /*if (!infoComplete || !strComplete || !dexComplete || !conComplete || !intComplete || !wisComplete || !chaComplete || !raceComplete || !classComplete)
            {
                MessageBox.Show("Cannot generate character. Missing values or values invalid.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        

        //WinForm defined methods

        //Generates user inputted Character Sheet
        public void btnSaveAndGenerate_Click(object sender, EventArgs e)
        {
            if (infoComplete == false || strComplete == false || dexComplete == false || conComplete == false || intComplete == false || wisComplete == false || chaComplete == false || raceComplete == false || classComplete == false)
            {
                InfoCheck();
                StatCheck();
                RaceCheck();
                ClassCheck();
                
            }
            
            else if (infoComplete == true && strComplete == true && dexComplete == true && conComplete == true && intComplete == true && wisComplete == true && chaComplete == true && raceComplete == true && classComplete == true)
            {
               // MessageBoxButtons confirmExit = MessageBoxButtons.OKCancel;
               // DialogResult exiting = MessageBox.Show("Hitting OK will generate character sheet with current values. Most of these can be modified later. Are you sure you want to continue?", "Warning", confirmExit, MessageBoxIcon.Warning);
               // if (exiting == DialogResult.OK)
                //{
                    GenerateCharacter();
                    GenerateAbilities();
                    SetRace();
                    
                    character.Show();
               // }
                //else if (exiting == DialogResult.Cancel)
                //{

               // }
            }
        }
        //Exit app
        public void BuildCharacter_FormClosing(object sender, FormClosingEventArgs e)
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
        //Back to LoadCharacter
        public void btnBack_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmExit = MessageBoxButtons.OKCancel;
            DialogResult exiting = MessageBox.Show("Are you sure you want to quit? All progress will be lost.", "Warning", confirmExit, MessageBoxIcon.Warning);
            if (exiting == DialogResult.OK)
            {
                LoadChar backToLoadChar = new LoadChar();
                backToLoadChar.Show();
                this.Hide();
            }
            else if (exiting == DialogResult.Cancel)
            {
               
            }
        }
        //Allows ability to import class and effectively import existing physical PFCS
        public void checkImportClass_Click(object sender, EventArgs e)
        {

            MessageBox.Show("This funcction is coming soon!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*if (checkImportClass.Checked)
            {

                btnAddClass.Show();
                btnRemoveClass.Show();
                lblSelectProgressionType.Show();
                cbProgressionType.Show();
                lblClassSelectCurrentXP.Show();
                txtbxCurrentExp.Show();

                txtbxClassSelectLvl1.ReadOnly = false;
                txtbxClassSelectLvl1.Text = "";
            }
            else
            {

                btnAddClass.Hide();
                btnRemoveClass.Hide();
                lblSelectProgressionType.Hide();
                cbProgressionType.Hide();
                lblClassSelectCurrentXP.Hide();
                txtbxCurrentExp.Hide();

                txtbxClassSelectLvl1.ReadOnly = true;
                txtbxClassSelectLvl1.Text = "1";
            }
            */



        }
        //Reset Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBoxButtons confirmExit = MessageBoxButtons.OKCancel;
            DialogResult exiting = MessageBox.Show("Are you sure you want to reset? All progress will be lost.", "Warning", confirmExit, MessageBoxIcon.Warning);
            if (exiting == DialogResult.OK)
            {
                   txtbxStr.Text = "";
                txtbxStrMod.Text = "";
                   txtbxDex.Text = "";
                     txtbxDexMod.Text = "";
                   txtbxCon.Text = "";
                txtbxConMod.Text = "";
                   txtbxInt.Text = "";
                txtbxIntMod.Text = "";
                   txtbxWis.Text = "";
                txtbxWisMod.Text = "";
                   txtbxCha.Text = "";
                txtbxChaMod.Text = "";
                  txtbxCharName.Text = "";
                txtbxPlayerName.Text = "";
                    txtbxGender.Text = "";
                 txtbxHeighFeet.Text = "";
                        txtbxIn.Text = "";
                    txtbxWeight.Text = "";
                     txtboxHair.Text = "";
                       txtbxEye.Text = "";
                     txtbxDeity.Text = "";
                 txtboxHomeland.Text = "";
                       txtbxAge.Text = "";
                intPlayerStr = 0;
                intPlayerStrMod = 0;
                intPlayerDex = 0;
                intPlayerDexMod = 0;
                intPlayerCon = 0;
                intPlayerConMod = 0;
                intPlayerInt = 0;
                intPlayerIntMod = 0;
                intPlayerWis = 0;
                intPlayerWisMod = 0;
                intPlayerCha = 0;
                intPlayerChaMod = 0;
                intcharAge = 0;
                intcharHeightFt = 0;
                intcharHeightIn = 0;
                intcharWeight = 0;
                lboxRace.ClearSelected();
                cbAlignment.SelectedIndex.Equals(0);
                cbClassSelect1 = null;
                cbClassSelect2 = null;
                cbClassSelect3 = null;
                txtbxClassSelectLvl1.Text = "1";
                txtbxClassSelectLvl2.Text = "";
                txtbxClassSelectLvl3.Text = "";
            }
            else if (exiting == DialogResult.Cancel)
            {

            }
            
        }
        //Random Stat Roller
        public void btnRollRandom_Click(object sender, EventArgs e)
        {
            //warningRandomRoll.Show();
            RollRandom();
        }
        //Set Strength Stat
        public void txtbxStr_TextChanged(object sender, EventArgs e)
        {
            SetStr();
        }
        //Set Dexterity stat
        public void txtbxDex_TextChanged(object sender, EventArgs e)
        {
            SetDex();
        }
        //Set Constitution stat
        public void txtbxCon_TextChanged(object sender, EventArgs e)
        {
            SetCon();
        }
        //Set Intelligence stat
        public void txtbxInt_TextChanged(object sender, EventArgs e)
        {
            SetInt();
        }
        //Set Wisdom stat
        public void txtbxWis_TextChanged(object sender, EventArgs e)
        {
            SetWis();
        }
        //Set Charisma stat
        public void txtbxCha_TextChanged(object sender, EventArgs e)
        {
            SetCha();
        }

        //Sets player info
        public void txtbxPlayerName_TextChanged(object sender, EventArgs e)
        {
            playerName = txtbxPlayerName.Text;
        }
        public void txtbxCharName_TextChanged(object sender, EventArgs e)
        {
            charName = txtbxCharName.Text;
        }
        public void txtbxGender_TextChanged(object sender, EventArgs e)
        {
            charGender = txtbxGender.Text;

        }
        public void txtbxHeighFeet_TextChanged(object sender, EventArgs e)
        {
            charHeightFt = txtbxHeighFeet.Text;
            
        }
        public void txtbxIn_TextChanged(object sender, EventArgs e)
        {
            charHeightIn = txtbxIn.Text;
        }
        public void txtboxHair_TextChanged(object sender, EventArgs e)
        {
            charHair = txtboxHair.Text;
        }
        public void txtbxWeight_TextChanged(object sender, EventArgs e)
        {
            charWeight = txtbxWeight.Text;
        }
        public void txtbxEye_TextChanged(object sender, EventArgs e)
        {
            charEye = txtbxEye.Text;
        }
        public void txtbxDeity_TextChanged(object sender, EventArgs e)
        {
            charDeity = txtbxDeity.Text;
        }
        public void txtboxHomeland_TextChanged(object sender, EventArgs e)
        {
            charHomeland = txtboxHomeland.Text;
        }
        public void cbAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            charAlignment = cbAlignment.SelectedItem.ToString();
        }
        public void txtbxAge_TextChanged(object sender, EventArgs e)
        {
            charAge = txtbxAge.Text;
            
        }
        public void lboxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (lboxRace.SelectedIndex.Equals(0))
            {
                cbClassSelect1.Visible = false;
                txtbxClassSelectLvl1.Visible = false;
                checkImportClass.Visible = false;
            }
            else
            {
                cbClassSelect1.Visible = true;
                txtbxClassSelectLvl1.Visible = true;
                checkImportClass.Visible = true;
            }

            if (lboxRace.SelectedIndex.Equals(1))
            {
                isHuman = false;
                isElf = false;
                isHalfling = false;
                isHalfElf = false;
                isHalfOrc = false;
                isGnome = false;
                isDwarf = true;
            }
            else if (lboxRace.SelectedIndex.Equals(2))
            {
                isHuman = false;
                isElf = false;
                isHalfling = true;
                isHalfElf = false;
                isHalfOrc = false;
                isGnome = false;
                isDwarf = false;
            }
            else if (lboxRace.SelectedIndex.Equals(3))
            {
                isHuman = false;
                isElf = true;
                isHalfling = false;
                isHalfElf = false;
                isHalfOrc = false;
                isGnome = false;
                isDwarf = false;
            }
            else if (lboxRace.SelectedIndex.Equals(4))
            {
                isHuman = true;
                isElf = false;
                isHalfling = false;
                isHalfElf = false;
                isHalfOrc = false;
                isGnome = false;
                isDwarf = false;
            }
            else if (lboxRace.SelectedIndex.Equals(5))
            {
                isHuman = false;
                isElf = false;
                isHalfling = false;
                isHalfElf = false;
                isHalfOrc = false;
                isGnome = true;
                isDwarf = false;
            }
            else if (lboxRace.SelectedIndex.Equals(6))
            {
                isHuman = false;
                isElf = false;
                isHalfling = false;
                isHalfElf = false;
                isHalfOrc = true;
                isGnome = false;
                isDwarf = false;
            }
            else if (lboxRace.SelectedIndex.Equals(7))
            {
                isHuman = false;
                isElf = false;
                isHalfling = false;
                isHalfElf = true;
                isHalfOrc = false;
                isGnome = false;
                isDwarf = false;
            }


            charRace = lboxRace.SelectedItem.ToString();
            

        }

        //Generates character sheet
        
        public void GenerateCharacter()
        {
            //Generate character info
            character.lblCharName.Text = charName;
            character.characterName = charName;

            character.txtbxPlayerName.Text = playerName;
            character.playerName = playerName;

            character.charGender = charGender;
            character.txtbxGender.Text = charGender;

            character.txtbxFeet.Text = charHeightFt;
            character.charHeightFt = charHeightFt;
            character.intcharHeightFt = Convert.ToInt32(character.charHeightFt);

            character.txtbxInches.Text = charHeightIn;
            character.charHeightIn = charHeightIn;
            character.intcharHeightIn = Convert.ToInt32(character.charHeightIn);

            character.txtbxWeight.Text = charWeight;
            character.charWeight = charWeight;
            character.intcharWeight = Convert.ToInt32(character.charWeight);

            character.txtbxHair.Text = charHair;
            character.charHair = charHair;
            character.txtbxEyes.Text = charEye;
            character.charEye = charHair;

            character.txtbxDeity.Text = charDeity;
            character.charDeity = charDeity;
            character.txtbxHomeland.Text = charHomeland;
            character.charHomeland = charHomeland;

            character.txtbxAlignment.Text = charAlignment;
            character.charAlignment = charAlignment;

            character.txtbxAge.Text = charAge;
            character.charAge = charAge;
            character.intcharAge = Convert.ToInt32(character.charAge);

            //Generate Character stats

        }
        public void GenerateSkills()
        {

        }
        public void GenerateFeats()
        {

        }
        public void GenerateAbilities()
        {
            //STR
            
            character.strength = strPlayerStr;
            character.strInt = intPlayerStr;

            character.strMod = strPlayerStrMod;
            character.strModInt = intPlayerStrMod;

            //DEX
            
            character.dexterity = strPlayerDex;
            character.dexInt = intPlayerDex;
           
            character.dexMod = strPlayerDexMod;
            character.dexModInt = intPlayerDexMod;
            

            //CON
            
            character.constitution = strPlayerCon;
            character.conInt = intPlayerCon;
            
            
            character.conMod = strPlayerConMod;
            character.conModInt = intPlayerConMod;
            

            //INT
            character.intelligence = strPlayerInt;
            character.intInt = intPlayerInt;

            character.intMod = strPlayerIntMod;
            character.intModInt = intPlayerIntMod;

            //WIS
            
            character.wisdom = strPlayerWis;
            character.wisInt = intPlayerWis;
            
            character.wisMod = strPlayerWisMod;
            character.wisModInt = intPlayerWisMod;

            //CHA
           
            character.charisma = strPlayerCha;
            character.chaInt = intPlayerCha;
           
            character.chaMod = strPlayerChaMod;
            character.chaModInt = intPlayerChaMod;
        }
        public void GenerateSpells()
        {

        }
        public void GenerateEquipment()
        {

        }

        //Sets any race related values
        public void SetRace()
        {
            if (isDwarf == true)
            {
                character.charRace = "Dwarf";
                character.txtbxRace.Text = character.charRace;
                //Size
                playerSize = "Medium";
                txtbxSize.Text = playerSize;
                character.charSize = playerSize;
                character.txtbxSize.Text = character.charSize;

                //Ability Racial Traits

                character.SetStr();
                character.SetDex();
                character.SetInt();
                if (txtbxClassSelectLvl1.Text == "1")
                {
                    character.conInt += 2;
                    character.SetCon();
                }
                else
                {
                    character.SetCon();
                }
                 
                character.wisInt += 2;
                character.wisdom = character.wisInt.ToString();
                character.SetWis();

                character.chaInt -= 2;
                character.charisma = character.chaInt.ToString();
                character.SetCha();

                //Slow and Steady Dwarves have a base speed of 20 feet, but their speed is never modified by armor
                character.baseSpeed = "20";
                character.txtbxBaseSpd.Text = character.baseSpeed;
                character.baseSpeedInt = 20;

                

            }
            else if (isElf == true)
            {

            }
            else if (isGnome == true)
            {

            }
            else if (isHalfElf == true)
            {

            }
            else if (isHalfOrc == true)
            {

            }
            else if (isHalfling == true)
            {

            }
            else if (isHuman == true)
            {

            }


        }
        //Sets any class related values
        public void SetClass()
        {

        }

        //Prevents user from typing invalid values
        private void txtbxGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {

                e.Handled = true;
                MessageBox.Show("Invalid input. Value cannot be a number or special character.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxGender.Text = null;
            }
        }
        private void txtbxHeighFeet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)  && char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Value cannot be a letter or special character.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxHeighFeet.Text = null;
                intcharHeightFt = 0;
            }
        }
        private void txtbxIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Value cannot be a letter or special character.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxIn.Text = null;
                intcharHeightIn = 0;
            }
        }
        private void txtbxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Value cannot be a letter or special character.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxWeight.Text = null;
                intcharWeight = 0;
            }
        }
        private void lblLbs_DoubleClick(object sender, EventArgs e)
        {
            if (intcharWeight >= 124000)
            {
                txtbxCharName.Text = "Sperm Whale";
                txtboxHomeland.Text = "Atlantic Ocean";
                txtbxHeighFeet.Text = "65";
                txtbxIn.Text = "1";
                txtbxSize.Text = "Massive";
            }
            else if (intcharWeight == 666)
            {
                isSatan = true;
                txtbxCharName.Text = "Satan";
                txtboxHomeland.Text = "Hell";
                txtbxHeighFeet.Text = "666";
                txtbxIn.Text = "666";
                txtbxSize.Text = "Unknown";
                cbAlignment.Text = "Very Evil";
            }
        }
        private void txtboxHair_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Value cannot be a number or special character.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxHair.Text = "";
            }
        }
        private void txtbxEye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Value cannot be a number or special character.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxEye.Text = "";
            }
        }
        private void txtbxDeity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Value cannot be a number or special character.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxDeity.Text = "";
            }
        }
        private void txtboxHomeland_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))

            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Value cannot be a number or special character.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxHomeland.Text = "";
            }
        }
        private void txtbxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))

            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Value cannot be a letter or special character.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxAge.Text = "";
                intcharAge = 0;
            }
        }

        private void BuildCharacter_Load(object sender, EventArgs e)
        {
            lboxRace.SelectedIndex = 0;
            cbAlignment.SelectedIndex = 0;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            txtbxPlayerName.Text = "Debug";
            txtbxCharName.Text = "Debug";
            txtbxGender.Text = "Male";
            txtbxHeighFeet.Text = "5";
            txtbxIn.Text = "11";
            txtbxWeight.Text = "150";
            txtboxHair.Text = "Brown";
            txtboxHomeland.Text = "Canada";
            txtbxEye.Text = "Blue";
            txtbxAge.Text = "50";
            cbAlignment.SelectedIndex.Equals(3);
            txtbxStr.Text = "10";
            txtbxDex.Text = "10";
            txtbxCon.Text = "10";
            txtbxInt.Text = "10";
            txtbxWis.Text = "10";
            txtbxCha.Text = "10";
            lboxRace.SelectedIndex.Equals(1);
            cbClassSelect1.SelectedIndex.Equals(2);

        }

        private void lblFt_DoubleClick(object sender, EventArgs e)
        {
           
        }
    } 
}
