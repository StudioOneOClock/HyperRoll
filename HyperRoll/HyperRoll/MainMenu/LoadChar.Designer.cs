namespace HyperRoll
{
    partial class LoadChar
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
            this.btnLoadChar = new System.Windows.Forms.Button();
            this.btnNewChar = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadChar
            // 
            this.btnLoadChar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadChar.Location = new System.Drawing.Point(176, 253);
            this.btnLoadChar.Name = "btnLoadChar";
            this.btnLoadChar.Size = new System.Drawing.Size(492, 112);
            this.btnLoadChar.TabIndex = 0;
            this.btnLoadChar.Text = "Load Character";
            this.btnLoadChar.UseVisualStyleBackColor = false;
            // 
            // btnNewChar
            // 
            this.btnNewChar.Location = new System.Drawing.Point(176, 371);
            this.btnNewChar.Name = "btnNewChar";
            this.btnNewChar.Size = new System.Drawing.Size(492, 112);
            this.btnNewChar.TabIndex = 1;
            this.btnNewChar.Text = "New Character";
            this.btnNewChar.UseVisualStyleBackColor = true;
            this.btnNewChar.Click += new System.EventHandler(this.btnNewChar_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExitApp.Location = new System.Drawing.Point(12, 592);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(75, 23);
            this.btnExitApp.TabIndex = 8;
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
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LoadChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HyperRoll.Properties.Resources.wp2427531;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 627);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnNewChar);
            this.Controls.Add(this.btnLoadChar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoadChar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HyperRoll";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadChar_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadChar;
        private System.Windows.Forms.Button btnNewChar;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnBack;
    }
}