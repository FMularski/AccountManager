namespace AccountManager
{
    partial class VerificationCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationCodeForm));
            this.VerifyLabel = new System.Windows.Forms.Label();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VerifyLabel
            // 
            this.VerifyLabel.AutoSize = true;
            this.VerifyLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VerifyLabel.Location = new System.Drawing.Point(12, 9);
            this.VerifyLabel.Name = "VerifyLabel";
            this.VerifyLabel.Size = new System.Drawing.Size(289, 32);
            this.VerifyLabel.TabIndex = 0;
            this.VerifyLabel.Text = "A verification code has been sent to your email\naddress. Please verify it by ente" +
    "ring the code below.";
            this.VerifyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VerifyButton
            // 
            this.VerifyButton.BackColor = System.Drawing.Color.White;
            this.VerifyButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VerifyButton.Location = new System.Drawing.Point(113, 100);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(75, 23);
            this.VerifyButton.TabIndex = 1;
            this.VerifyButton.Text = "Verify";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CodeTextBox.Location = new System.Drawing.Point(75, 53);
            this.CodeTextBox.MaxLength = 6;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(149, 31);
            this.CodeTextBox.TabIndex = 2;
            this.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VerificationCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(308, 135);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.VerifyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerificationCodeForm";
            this.Text = "Verify email address";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerificationCodeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VerifyLabel;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.TextBox CodeTextBox;
    }
}