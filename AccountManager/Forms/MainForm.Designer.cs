namespace AccountManager.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AccountsPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.AssociatedEmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EditButtonsLabel = new System.Windows.Forms.Label();
            this.DeleteButtonsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoggedInAsLabel.Location = new System.Drawing.Point(12, 9);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(132, 22);
            this.LoggedInAsLabel.TabIndex = 0;
            this.LoggedInAsLabel.Text = "Logged in as ";
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddAccountButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddAccountButton.Location = new System.Drawing.Point(12, 34);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(128, 33);
            this.AddAccountButton.TabIndex = 1;
            this.AddAccountButton.Text = "+ Add Account";
            this.AddAccountButton.UseVisualStyleBackColor = false;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.White;
            this.ExportButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExportButton.Location = new System.Drawing.Point(146, 34);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(128, 33);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Export as txt";
            this.ExportButton.UseVisualStyleBackColor = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.White;
            this.SettingsButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingsButton.Location = new System.Drawing.Point(660, 34);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(128, 33);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AccountsPanel
            // 
            this.AccountsPanel.AutoScroll = true;
            this.AccountsPanel.Location = new System.Drawing.Point(0, 94);
            this.AccountsPanel.Name = "AccountsPanel";
            this.AccountsPanel.Size = new System.Drawing.Size(800, 344);
            this.AccountsPanel.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(16, 74);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(34, 16);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Title";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginLabel.Location = new System.Drawing.Point(143, 74);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(43, 16);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Login";
            // 
            // AssociatedEmailLabel
            // 
            this.AssociatedEmailLabel.AutoSize = true;
            this.AssociatedEmailLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AssociatedEmailLabel.Location = new System.Drawing.Point(297, 74);
            this.AssociatedEmailLabel.Name = "AssociatedEmailLabel";
            this.AssociatedEmailLabel.Size = new System.Drawing.Size(120, 16);
            this.AssociatedEmailLabel.TabIndex = 7;
            this.AssociatedEmailLabel.Text = "Associated Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordLabel.Location = new System.Drawing.Point(503, 74);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(68, 16);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password";
            // 
            // EditButtonsLabel
            // 
            this.EditButtonsLabel.AutoSize = true;
            this.EditButtonsLabel.Location = new System.Drawing.Point(645, 77);
            this.EditButtonsLabel.Name = "EditButtonsLabel";
            this.EditButtonsLabel.Size = new System.Drawing.Size(0, 13);
            this.EditButtonsLabel.TabIndex = 9;
            // 
            // DeleteButtonsLabel
            // 
            this.DeleteButtonsLabel.AutoSize = true;
            this.DeleteButtonsLabel.Location = new System.Drawing.Point(722, 76);
            this.DeleteButtonsLabel.Name = "DeleteButtonsLabel";
            this.DeleteButtonsLabel.Size = new System.Drawing.Size(0, 13);
            this.DeleteButtonsLabel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButtonsLabel);
            this.Controls.Add(this.EditButtonsLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.AssociatedEmailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AccountsPanel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.LoggedInAsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoggedInAsLabel;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel AccountsPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label AssociatedEmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EditButtonsLabel;
        private System.Windows.Forms.Label DeleteButtonsLabel;
    }
}