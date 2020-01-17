using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager
{
    public partial class VerificationCodeForm : Form
    {
        private int VerificationCode;
        private Button ButtonToEnable;
        private User UserToBeAdded;
        public VerificationCodeForm(int code, Button button, params string[] userData)
        {
            ButtonToEnable = button;
            ButtonToEnable.Enabled = false;
            VerificationCode = code;

            UserToBeAdded = new User(userData[0], userData[1], userData[2], userData[3]);
            
            InitializeComponent();
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            string enteredCode = CodeTextBox.Text;

            if (enteredCode.Equals(VerificationCode.ToString()))
            {
                DBManager.AddUser(UserToBeAdded.Login, UserToBeAdded.Email, UserToBeAdded.Password, UserToBeAdded.Pin);
                this.Close();
                MessageBox.Show($"User \'{UserToBeAdded.Login}\' has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormUtilities.ClearTextBoxes(CodeTextBox);
                MessageBox.Show("Invalid verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificationCodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtilities.EnableButtons(ButtonToEnable);
        }
    }
}
