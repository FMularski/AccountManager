namespace AccountManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DontHaveAccButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.ForgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.LightYellow;
            this.LoginLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginLabel.Location = new System.Drawing.Point(333, 78);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(55, 21);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Login:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.LightYellow;
            this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordLabel.Location = new System.Drawing.Point(334, 140);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 21);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginTextBox.Location = new System.Drawing.Point(337, 102);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(128, 26);
            this.LoginTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.Location = new System.Drawing.Point(337, 164);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(128, 26);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // DontHaveAccButton
            // 
            this.DontHaveAccButton.BackColor = System.Drawing.Color.White;
            this.DontHaveAccButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DontHaveAccButton.Location = new System.Drawing.Point(337, 327);
            this.DontHaveAccButton.Name = "DontHaveAccButton";
            this.DontHaveAccButton.Size = new System.Drawing.Size(128, 43);
            this.DontHaveAccButton.TabIndex = 7;
            this.DontHaveAccButton.Text = "Don\'t have an account yet?";
            this.DontHaveAccButton.UseVisualStyleBackColor = false;
            this.DontHaveAccButton.Click += new System.EventHandler(this.DontHaveAccButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.White;
            this.LogInButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(337, 277);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(127, 28);
            this.LogInButton.TabIndex = 8;
            this.LogInButton.Text = "Log in";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // ForgotPasswordLinkLabel
            // 
            this.ForgotPasswordLinkLabel.AutoSize = true;
            this.ForgotPasswordLinkLabel.Location = new System.Drawing.Point(335, 193);
            this.ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel";
            this.ForgotPasswordLinkLabel.Size = new System.Drawing.Size(91, 13);
            this.ForgotPasswordLinkLabel.TabIndex = 9;
            this.ForgotPasswordLinkLabel.TabStop = true;
            this.ForgotPasswordLinkLabel.Text = "Forgot password?";
            this.ForgotPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPasswordLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ForgotPasswordLinkLabel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.DontHaveAccButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Account Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button DontHaveAccButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.LinkLabel ForgotPasswordLinkLabel;
    }
}

