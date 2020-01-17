namespace AccountManager
{
    partial class ChangePinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePinForm));
            this.ChangePinButton = new System.Windows.Forms.Button();
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.NewPinTextBox = new System.Windows.Forms.TextBox();
            this.NewPinLabel = new System.Windows.Forms.Label();
            this.ChangePinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangePinButton
            // 
            this.ChangePinButton.BackColor = System.Drawing.Color.White;
            this.ChangePinButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChangePinButton.Location = new System.Drawing.Point(112, 186);
            this.ChangePinButton.Name = "ChangePinButton";
            this.ChangePinButton.Size = new System.Drawing.Size(175, 32);
            this.ChangePinButton.TabIndex = 15;
            this.ChangePinButton.Text = "Change PIN";
            this.ChangePinButton.UseVisualStyleBackColor = false;
            this.ChangePinButton.Click += new System.EventHandler(this.ChangePinButton_Click);
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmTextBox.Location = new System.Drawing.Point(111, 121);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new System.Drawing.Size(174, 23);
            this.ConfirmTextBox.TabIndex = 14;
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmLabel.Location = new System.Drawing.Point(107, 101);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(121, 17);
            this.ConfirmLabel.TabIndex = 13;
            this.ConfirmLabel.Text = "Confirm new PIN:";
            // 
            // NewPinTextBox
            // 
            this.NewPinTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewPinTextBox.Location = new System.Drawing.Point(111, 75);
            this.NewPinTextBox.Name = "NewPinTextBox";
            this.NewPinTextBox.Size = new System.Drawing.Size(174, 23);
            this.NewPinTextBox.TabIndex = 12;
            // 
            // NewPinLabel
            // 
            this.NewPinLabel.AutoSize = true;
            this.NewPinLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewPinLabel.Location = new System.Drawing.Point(109, 53);
            this.NewPinLabel.Name = "NewPinLabel";
            this.NewPinLabel.Size = new System.Drawing.Size(67, 17);
            this.NewPinLabel.TabIndex = 11;
            this.NewPinLabel.Text = "New PIN:";
            // 
            // ChangePinLabel
            // 
            this.ChangePinLabel.AutoSize = true;
            this.ChangePinLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChangePinLabel.Location = new System.Drawing.Point(138, 9);
            this.ChangePinLabel.Name = "ChangePinLabel";
            this.ChangePinLabel.Size = new System.Drawing.Size(122, 22);
            this.ChangePinLabel.TabIndex = 8;
            this.ChangePinLabel.Text = "Change PIN";
            // 
            // ChangePinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(395, 231);
            this.Controls.Add(this.ChangePinButton);
            this.Controls.Add(this.ConfirmTextBox);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.NewPinTextBox);
            this.Controls.Add(this.NewPinLabel);
            this.Controls.Add(this.ChangePinLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePinForm";
            this.Text = "Change Pin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePinForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangePinButton;
        private System.Windows.Forms.TextBox ConfirmTextBox;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.TextBox NewPinTextBox;
        private System.Windows.Forms.Label NewPinLabel;
        private System.Windows.Forms.Label ChangePinLabel;
    }
}