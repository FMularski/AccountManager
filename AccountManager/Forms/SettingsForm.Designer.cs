namespace AccountManager
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.SecurityGroupBox = new System.Windows.Forms.GroupBox();
            this.ChangePinLabel = new System.Windows.Forms.Label();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.ChangePinButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.OtherGroupBox = new System.Windows.Forms.GroupBox();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.SecurityGroupBox.SuspendLayout();
            this.OtherGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsLabel.Location = new System.Drawing.Point(12, 9);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(80, 22);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Settings";
            // 
            // SecurityGroupBox
            // 
            this.SecurityGroupBox.Controls.Add(this.ChangePinLabel);
            this.SecurityGroupBox.Controls.Add(this.ChangePasswordLabel);
            this.SecurityGroupBox.Controls.Add(this.ChangePinButton);
            this.SecurityGroupBox.Controls.Add(this.ChangePasswordButton);
            this.SecurityGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SecurityGroupBox.Location = new System.Drawing.Point(16, 67);
            this.SecurityGroupBox.Name = "SecurityGroupBox";
            this.SecurityGroupBox.Size = new System.Drawing.Size(772, 145);
            this.SecurityGroupBox.TabIndex = 1;
            this.SecurityGroupBox.TabStop = false;
            this.SecurityGroupBox.Text = "Security";
            // 
            // ChangePinLabel
            // 
            this.ChangePinLabel.AutoSize = true;
            this.ChangePinLabel.Location = new System.Drawing.Point(166, 90);
            this.ChangePinLabel.Name = "ChangePinLabel";
            this.ChangePinLabel.Size = new System.Drawing.Size(207, 17);
            this.ChangePinLabel.TabIndex = 3;
            this.ChangePinLabel.Text = "Here you can change your PIN.";
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(166, 43);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(248, 17);
            this.ChangePasswordLabel.TabIndex = 2;
            this.ChangePasswordLabel.Text = "Here you can change your password.";
            // 
            // ChangePinButton
            // 
            this.ChangePinButton.BackColor = System.Drawing.Color.White;
            this.ChangePinButton.Location = new System.Drawing.Point(6, 83);
            this.ChangePinButton.Name = "ChangePinButton";
            this.ChangePinButton.Size = new System.Drawing.Size(138, 31);
            this.ChangePinButton.TabIndex = 1;
            this.ChangePinButton.Text = "Change PIN";
            this.ChangePinButton.UseVisualStyleBackColor = false;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.White;
            this.ChangePasswordButton.Location = new System.Drawing.Point(6, 36);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(138, 31);
            this.ChangePasswordButton.TabIndex = 0;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(708, 407);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 31);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "<< Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.LightCoral;
            this.LogOutButton.Location = new System.Drawing.Point(6, 31);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(144, 31);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            // 
            // OtherGroupBox
            // 
            this.OtherGroupBox.Controls.Add(this.LogOutLabel);
            this.OtherGroupBox.Controls.Add(this.LogOutButton);
            this.OtherGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OtherGroupBox.Location = new System.Drawing.Point(16, 218);
            this.OtherGroupBox.Name = "OtherGroupBox";
            this.OtherGroupBox.Size = new System.Drawing.Size(772, 82);
            this.OtherGroupBox.TabIndex = 4;
            this.OtherGroupBox.TabStop = false;
            this.OtherGroupBox.Text = "Other";
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.AutoSize = true;
            this.LogOutLabel.Location = new System.Drawing.Point(166, 38);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(485, 17);
            this.LogOutLabel.TabIndex = 4;
            this.LogOutLabel.Text = "Here you can log out if you want to use other Account Manager account.";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OtherGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SecurityGroupBox);
            this.Controls.Add(this.SettingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Account Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.SecurityGroupBox.ResumeLayout(false);
            this.SecurityGroupBox.PerformLayout();
            this.OtherGroupBox.ResumeLayout(false);
            this.OtherGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.GroupBox SecurityGroupBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ChangePinButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.GroupBox OtherGroupBox;
        private System.Windows.Forms.Label ChangePinLabel;
        private System.Windows.Forms.Label ChangePasswordLabel;
        private System.Windows.Forms.Label LogOutLabel;
    }
}