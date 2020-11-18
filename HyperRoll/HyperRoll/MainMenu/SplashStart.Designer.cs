namespace HyperRoll
{
    partial class SplashStart
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
            this.loader = new System.Windows.Forms.ProgressBar();
            this.lblSplashTitle = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loader
            // 
            this.loader.Location = new System.Drawing.Point(12, 177);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(601, 23);
            this.loader.TabIndex = 0;
            // 
            // lblSplashTitle
            // 
            this.lblSplashTitle.AutoSize = true;
            this.lblSplashTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSplashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplashTitle.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSplashTitle.Location = new System.Drawing.Point(162, 74);
            this.lblSplashTitle.Name = "lblSplashTitle";
            this.lblSplashTitle.Size = new System.Drawing.Size(317, 44);
            this.lblSplashTitle.TabIndex = 1;
            this.lblSplashTitle.Text = "HyperRoll v0.1.4";
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.BackColor = System.Drawing.Color.Transparent;
            this.lblBy.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblBy.Location = new System.Drawing.Point(473, 221);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(140, 17);
            this.lblBy.TabIndex = 2;
            this.lblBy.Text = "Michaël Landry 2020";
            // 
            // SplashStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HyperRoll.Properties.Resources.splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 247);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.lblSplashTitle);
            this.Controls.Add(this.loader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HyperRoll v0.2";
            this.Shown += new System.EventHandler(this.SplashStart_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loader;
        private System.Windows.Forms.Label lblSplashTitle;
        private System.Windows.Forms.Label lblBy;
    }
}