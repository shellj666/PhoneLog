namespace PhoneLog
{
    partial class Form_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.TxtBx_About = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtBx_About
            // 
            this.TxtBx_About.Location = new System.Drawing.Point(13, 13);
            this.TxtBx_About.Multiline = true;
            this.TxtBx_About.Name = "TxtBx_About";
            this.TxtBx_About.ReadOnly = true;
            this.TxtBx_About.Size = new System.Drawing.Size(257, 228);
            this.TxtBx_About.TabIndex = 0;
            this.TxtBx_About.TabStop = false;
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.TxtBx_About);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBx_About;
    }
}