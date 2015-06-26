namespace GuusHamm__S22
{
    partial class MainMenuForm
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreateaMission = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbActiveMissions = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.gbLogin.Location = new System.Drawing.Point(442, 2);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(119, 100);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(7, 45);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(7, 20);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            // 
            // btnCreateaMission
            // 
            this.btnCreateaMission.Location = new System.Drawing.Point(266, 73);
            this.btnCreateaMission.Name = "btnCreateaMission";
            this.btnCreateaMission.Size = new System.Drawing.Size(123, 23);
            this.btnCreateaMission.TabIndex = 4;
            this.btnCreateaMission.Text = "Create Mission";
            this.btnCreateaMission.UseVisualStyleBackColor = true;
            this.btnCreateaMission.Click += new System.EventHandler(this.btnCreateaMission_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Fill All Ships";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbActiveMissions
            // 
            this.lbActiveMissions.FormattingEnabled = true;
            this.lbActiveMissions.Location = new System.Drawing.Point(12, 12);
            this.lbActiveMissions.Name = "lbActiveMissions";
            this.lbActiveMissions.Size = new System.Drawing.Size(247, 251);
            this.lbActiveMissions.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Go To Mission";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(266, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Delete Mission";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 365);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbActiveMissions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateaMission);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbLogin);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateaMission;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbActiveMissions;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

