using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AccountManager
{
    public partial class ForgotPasswordForm : Form
    {
        private Control[] DisabledControls;

        public ForgotPasswordForm(Control[] controls)
        {
            DisabledControls = new Control[3];
            controls.CopyTo(DisabledControls, 0);
            InitializeComponent();
        }

        private void RemindButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string email = EmailTextBox.Text;

            if ( login.Equals("") || email.Equals(""))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(email, "[^@]+@[^@]+\\.[^@]+"))
            {
                MessageBox.Show($"Invalid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(EmailTextBox);
                return;
            }

            if ( !DBManager.GetColumnValues("Users", "Login").Contains(login))
            {
                MessageBox.Show($"Invalid user \'{login}\'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(LoginTextBox);
                return;
            }

            if ( !DBManager.GetSingleValueWhere("Users", "Email", "Login", login).Equals(email))
            {
                MessageBox.Show($"Email \'{email}\' is not associated with user \'{login}\'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(EmailTextBox);
                return;
            }

            int verificationCode = new Random().Next(100000, 999999);


            EmailManager.SendEmail(email, "forgot", login, verificationCode.ToString());
            this.Close();

            VerificationCodeForm vcf = new VerificationCodeForm( VerificationCodeForm.Mode.Reminder, verificationCode, DisabledControls, login, email, /*password*/ DBManager.GetSingleValueWhere("Users", "Password", "Login", login));
            vcf.Show();
            FormUtilities.DisableControls(DisabledControls);
        }

        private void ForgotPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtilities.EnableControls(DisabledControls);
        }
    }
}
