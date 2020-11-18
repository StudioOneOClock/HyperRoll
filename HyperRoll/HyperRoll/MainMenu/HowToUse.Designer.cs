namespace HyperRoll
{
    partial class HowToUse
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
            System.Windows.Forms.TextBox txtHowToUse;
            this.lblHowToUse = new System.Windows.Forms.Label();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            txtHowToUse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtHowToUse
            // 
            txtHowToUse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            txtHowToUse.Location = new System.Drawing.Point(12, 129);
            txtHowToUse.Multiline = true;
            txtHowToUse.Name = "txtHowToUse";
            txtHowToUse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtHowToUse.Size = new System.Drawing.Size(792, 442);
            txtHowToUse.TabIndex = 1;
            // 
            // lblHowToUse
            // 
            this.lblHowToUse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHowToUse.AutoSize = true;
            this.lblHowToUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToUse.Location = new System.Drawing.Point(327, 51);
            this.lblHowToUse.Name = "lblHowToUse";
            this.lblHowToUse.Size = new System.Drawing.Size(168, 32);
            this.lblHowToUse.TabIndex = 0;
            this.lblHowToUse.Text = "How To Use";
            // 
            // btnExitApp
            // 
            this.btnExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExitApp.Location = new System.Drawing.Point(12, 592);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(75, 23);
            this.btnExitApp.TabIndex = 7;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(729, 592);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HowToUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HyperRoll.Properties.Resources.pathfinder_art_by_aurelie_laget_d807yn6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 627);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(txtHowToUse);
            this.Controls.Add(this.lblHowToUse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HowToUse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HyperRoll";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HowToUse_FormClosed);
            this.Load += new System.EventHandler(this.HowToUse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHowToUse;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnBack;
    }
}