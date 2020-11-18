namespace HyperRoll
{
    partial class Info
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
            this.btnHowToUse = new System.Windows.Forms.Button();
            this.btnVersionInfo = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHowToUse
            // 
            this.btnHowToUse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHowToUse.FlatAppearance.BorderSize = 5;
            this.btnHowToUse.Location = new System.Drawing.Point(152, 178);
            this.btnHowToUse.Name = "btnHowToUse";
            this.btnHowToUse.Size = new System.Drawing.Size(494, 98);
            this.btnHowToUse.TabIndex = 0;
            this.btnHowToUse.Text = "How To Use";
            this.btnHowToUse.UseVisualStyleBackColor = true;
            this.btnHowToUse.Click += new System.EventHandler(this.btnHowToUse_Click);
            // 
            // btnVersionInfo
            // 
            this.btnVersionInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVersionInfo.Location = new System.Drawing.Point(152, 282);
            this.btnVersionInfo.Name = "btnVersionInfo";
            this.btnVersionInfo.Size = new System.Drawing.Size(494, 98);
            this.btnVersionInfo.TabIndex = 1;
            this.btnVersionInfo.Text = "Version Info";
            this.btnVersionInfo.UseVisualStyleBackColor = true;
            this.btnVersionInfo.Click += new System.EventHandler(this.btnVersionInfo_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack1.Location = new System.Drawing.Point(152, 386);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(494, 98);
            this.btnBack1.TabIndex = 2;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExitApp.Location = new System.Drawing.Point(12, 592);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(75, 23);
            this.btnExitApp.TabIndex = 6;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HyperRoll.Properties.Resources.PZO1134_EvilNemesis;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 627);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.btnVersionInfo);
            this.Controls.Add(this.btnHowToUse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HyperRoll";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Info_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHowToUse;
        private System.Windows.Forms.Button btnVersionInfo;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Button btnExitApp;
    }
}