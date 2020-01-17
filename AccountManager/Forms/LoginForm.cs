using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountManager.Forms;


namespace AccountManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void DontHaveAccButton_Click(object sender, EventArgs e)
        {
            Control[] controlsToBeDisabled = new Control[] { DontHaveAccButton, ForgotPasswordLinkLabel, LogInButton };
            RegisterForm rf = new RegisterForm(controlsToBeDisabled);
            FormUtilities.DisableControls(DontHaveAccButton, ForgotPasswordLinkLabel, LogInButton);
            rf.Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            if (login.Equals("") || password.Equals(""))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DBManager.GetColumnValues("Users", "Login").Contains(login))
            {
                MessageBox.Show($"Invalid user \'{login}\'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(LoginTextBox, PasswordTextBox);
                return;
            }

            if (!DBManager.GetSingleValueWhere("Users", "Password", "Login", login).Equals(password))
            {
                MessageBox.Show("Invalid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(PasswordTextBox);
                return;
            }

            User loggedUser = new User(login, DBManager.GetSingleValueWhere("Users", "Email", "Login", login),
                password, DBManager.GetSingleValueWhere("Users", "Pin", "Login", login));
            loggedUser.Id = Convert.ToInt32(DBManager.GetSingleValueWhere("Users", "Id", "Login", login));

            EmailManager.SendEmail(loggedUser.Email, "alert", loggedUser.Login, DateTime.Now.ToString());

            this.Hide();
            MainForm mf = new MainForm(this, loggedUser);
            mf.Show();
            

        }

        private void ForgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Control[] controlsToBeDisabled = new Control[] { DontHaveAccButton, ForgotPasswordLinkLabel, LogInButton };
            ForgotPasswordForm fpf = new ForgotPasswordForm(controlsToBeDisabled);
            FormUtilities.DisableControls(controlsToBeDisabled);
            fpf.Show();
        }
    }
}
