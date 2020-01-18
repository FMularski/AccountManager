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
    public partial class ChangePasswordForm : Form
    {
        private Control[] DisabledControls;
        private User LoggedUser;

        public ChangePasswordForm(User loggedUser, Control[] controls)
        {
            InitializeComponent();
            DisabledControls = new Control[4];
            controls.CopyTo(DisabledControls, 0);
            LoggedUser = loggedUser;

            FormUtilities.DisableControls(DisabledControls);

        }

        private void ChangePasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtilities.EnableControls(DisabledControls);
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            string oldPassword = OldPasswordTextBox.Text;
            string newPassword = NewPasswordTextBox.Text;
            string confirmPassword = ConfirmTextBox.Text;

            if ( oldPassword.Equals("") || newPassword.Equals("") || confirmPassword.Equals(""))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(OldPasswordTextBox, NewPasswordTextBox, ConfirmTextBox);
                return;
            }

            if ( !oldPassword.Equals(DBManager.GetSingleValueWhere("Users", "Password", "Login", LoggedUser.Login)))
            {
                MessageBox.Show("Invalid old password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(OldPasswordTextBox, NewPasswordTextBox, ConfirmTextBox);
                return;
            }

            if ( newPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(OldPasswordTextBox, NewPasswordTextBox, ConfirmTextBox);
                return;
            }

            if ( !newPassword.Equals(confirmPassword))
            {
                MessageBox.Show("New password and password confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(OldPasswordTextBox, NewPasswordTextBox, ConfirmTextBox);
                return;
            }

            DBManager.UpdateValueWhere("Users", "Password", newPassword, "Login", LoggedUser.Login);
            MessageBox.Show("Password has been successfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            FormUtilities.EnableControls(DisabledControls);


        }
    }
}
