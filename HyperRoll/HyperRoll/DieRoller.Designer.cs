namespace HyperRoll
{
    partial class DieRoller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.dieType = new System.Windows.Forms.ComboBox();
            this.dieAdjust = new System.Windows.Forms.ComboBox();
            this.dieMod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dieNum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "# of Die";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Die Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adjustment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(825, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modifier";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(825, 335);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(97, 29);
            this.output.TabIndex = 4;
            this.output.Text = "Output:";
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(650, 329);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(169, 43);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // dieType
            // 
            this.dieType.FormattingEnabled = true;
            this.dieType.Items.AddRange(new object[] {
            "(Select Die)",
            "D3",
            "D4",
            "D6",
            "D8",
            "D10",
            "D12",
            "D20",
            "D100"});
            this.dieType.Location = new System.Drawing.Point(277, 160);
            this.dieType.Name = "dieType";
            this.dieType.Size = new System.Drawing.Size(114, 24);
            this.dieType.TabIndex = 7;
            this.dieType.SelectedIndexChanged += new System.EventHandler(this.dieType_SelectedIndexChanged);
            // 
            // dieAdjust
            // 
            this.dieAdjust.FormattingEnabled = true;
            this.dieAdjust.Items.AddRange(new object[] {
            "(Select Adjustment)",
            "+",
            "-",
            "*",
            "/"});
            this.dieAdjust.Location = new System.Drawing.Point(553, 158);
            this.dieAdjust.Name = "dieAdjust";
            this.dieAdjust.Size = new System.Drawing.Size(137, 24);
            this.dieAdjust.TabIndex = 8;
            // 
            // dieMod
            // 
            this.dieMod.FormattingEnabled = true;
            this.dieMod.Items.AddRange(new object[] {
            "(Select Modifier)",
            "(none)",
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma",
            "Initiative",
            "Base Attack Bonus 1",
            "Base Attack Bonus 2",
            "Base Attack Bonus 3",
            "Base Attack Bonus 4"});
            this.dieMod.Location = new System.Drawing.Point(824, 158);
            this.dieMod.Name = "dieMod";
            this.dieMod.Size = new System.Drawing.Size(167, 24);
            this.dieMod.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(928, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 10;
            // 
            // dieNum
            // 
            this.dieNum.FormattingEnabled = true;
            this.dieNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.dieNum.Location = new System.Drawing.Point(17, 158);
            this.dieNum.Name = "dieNum";
            this.dieNum.Size = new System.Drawing.Size(121, 24);
            this.dieNum.TabIndex = 11;
            this.dieNum.SelectedIndexChanged += new System.EventHandler(this.dieNum_SelectedIndexChanged);
            // 
            // DieRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 384);
            this.Controls.Add(this.dieNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dieMod);
            this.Controls.Add(this.dieAdjust);
            this.Controls.Add(this.dieType);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DieRoller";
            this.Text = "HyperRoll";
            this.Load += new System.EventHandler(this.DieRoller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ComboBox dieType;
        private System.Windows.Forms.ComboBox dieAdjust;
        private System.Windows.Forms.ComboBox dieMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dieNum;
    }
}