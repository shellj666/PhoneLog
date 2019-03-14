namespace PhoneLog
{
    partial class Form_PhoneLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PhoneLog));
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_OpenPhoneLog = new System.Windows.Forms.Button();
            this.Btn_About = new System.Windows.Forms.Button();
            this.Btn_LogCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Snow;
            this.Btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Exit.FlatAppearance.BorderSize = 5;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Exit.Location = new System.Drawing.Point(231, 86);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(101, 34);
            this.Btn_Exit.TabIndex = 4;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            // 
            // Btn_OpenPhoneLog
            // 
            this.Btn_OpenPhoneLog.BackColor = System.Drawing.Color.Snow;
            this.Btn_OpenPhoneLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_OpenPhoneLog.FlatAppearance.BorderSize = 5;
            this.Btn_OpenPhoneLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_OpenPhoneLog.Location = new System.Drawing.Point(12, 69);
            this.Btn_OpenPhoneLog.Name = "Btn_OpenPhoneLog";
            this.Btn_OpenPhoneLog.Size = new System.Drawing.Size(152, 51);
            this.Btn_OpenPhoneLog.TabIndex = 2;
            this.Btn_OpenPhoneLog.Text = "Open Phone Log";
            this.Btn_OpenPhoneLog.UseVisualStyleBackColor = false;
            // 
            // Btn_About
            // 
            this.Btn_About.BackColor = System.Drawing.Color.Snow;
            this.Btn_About.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_About.FlatAppearance.BorderSize = 5;
            this.Btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_About.Location = new System.Drawing.Point(231, 12);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(101, 37);
            this.Btn_About.TabIndex = 3;
            this.Btn_About.Text = "About";
            this.Btn_About.UseVisualStyleBackColor = false;
            // 
            // Btn_LogCall
            // 
            this.Btn_LogCall.BackColor = System.Drawing.Color.Snow;
            this.Btn_LogCall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_LogCall.FlatAppearance.BorderSize = 5;
            this.Btn_LogCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_LogCall.Location = new System.Drawing.Point(12, 12);
            this.Btn_LogCall.Name = "Btn_LogCall";
            this.Btn_LogCall.Size = new System.Drawing.Size(152, 51);
            this.Btn_LogCall.TabIndex = 1;
            this.Btn_LogCall.Text = "Log Call";
            this.Btn_LogCall.UseVisualStyleBackColor = false;
            // 
            // Form_PhoneLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(354, 139);
            this.Controls.Add(this.Btn_LogCall);
            this.Controls.Add(this.Btn_About);
            this.Controls.Add(this.Btn_OpenPhoneLog);
            this.Controls.Add(this.Btn_Exit);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_PhoneLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Log";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_OpenPhoneLog;
        private System.Windows.Forms.Button Btn_About;
        private System.Windows.Forms.Button Btn_LogCall;
    }
}

