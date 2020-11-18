namespace HyperRoll.ClassSheets
{
    partial class TestCS
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
            this.txtbxTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbxTest
            // 
            this.txtbxTest.Enabled = false;
            this.txtbxTest.Location = new System.Drawing.Point(290, 204);
            this.txtbxTest.Name = "txtbxTest";
            this.txtbxTest.ReadOnly = true;
            this.txtbxTest.Size = new System.Drawing.Size(202, 22);
            this.txtbxTest.TabIndex = 0;
            this.txtbxTest.TextChanged += new System.EventHandler(this.txtbxTest_TextChanged);
            // 
            // TestCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbxTest);
            this.Name = "TestCS";
            this.Text = "TestCS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbxTest;
    }
}