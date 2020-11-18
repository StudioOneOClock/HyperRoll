namespace HyperRoll
{
    partial class StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTitleVersion = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWelcome.CausesValidation = false;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(245, 289);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(333, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to HyperRoll !";
            // 
            // lblTitleVersion
            // 
            this.lblTitleVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleVersion.AutoSize = true;
            this.lblTitleVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleVersion.Location = new System.Drawing.Point(716, 601);
            this.lblTitleVersion.Name = "lblTitleVersion";
            this.lblTitleVersion.Size = new System.Drawing.Size(92, 17);
            this.lblTitleVersion.TabIndex = 1;
            this.lblTitleVersion.Text = "Version 0.1.4";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(228, 419);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(366, 59);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInfo.Location = new System.Drawing.Point(228, 484);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(366, 59);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExitApp.Location = new System.Drawing.Point(12, 595);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(75, 23);
            this.btnExitApp.TabIndex = 5;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 627);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitleVersion);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HyperRoll Alpha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartUp_FormClosed);
            this.Load += new System.EventHandler(this.StartUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTitleVersion;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExitApp;
    }
}

