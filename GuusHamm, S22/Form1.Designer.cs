namespace GuusHamm__S22
{
    partial class Form1
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
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Location = new System.Drawing.Point(6, 71);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(107, 23);
            this.BtnLogIn.TabIndex = 0;
            this.BtnLogIn.Text = "Log In";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.tbUsername);
            this.gbLogin.Controls.Add(this.BtnLogIn);
            this.gbLogin.Location = new System.Drawing.Point(755, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(119, 100);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(7, 20);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(7, 45);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 365);
            this.Controls.Add(this.gbLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
    }
}

