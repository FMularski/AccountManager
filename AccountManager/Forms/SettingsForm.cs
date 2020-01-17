using AccountManager.Forms;
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
    public partial class SettingsForm : Form
    {
        private MainForm _MainForm;
        private User LoggedUser;

        public SettingsForm(MainForm mainForm, User loggedUser)
        {
            InitializeComponent();
            _MainForm = mainForm;
            LoggedUser = loggedUser;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _MainForm.Show();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            _MainForm.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            _MainForm._LoginForm.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            Control[] controlsToDisable = { ChangePasswordButton, ChangePinButton, LogOutButton, BackButton };
            FormUtilities.DisableControls(controlsToDisable);

            int verificationCode = new Random().Next(100000, 999999);

            EmailManager.SendEmail(LoggedUser.Email, "changePassword", LoggedUser.Login, verificationCode.ToString());

            VerificationCodeForm vcf = new VerificationCodeForm(VerificationCodeForm.Mode.ChangePassword, verificationCode, controlsToDisable, LoggedUser.Login);
            vcf.Show();
        }

        private void ChangePinButton_Click(object sender, EventArgs e)
        {
            Control[] controlsToDisable = { ChangePasswordButton, ChangePinButton, LogOutButton, BackButton };
            FormUtilities.DisableControls(controlsToDisable);

            int verificationCode = new Random().Next(100000, 999999);

            EmailManager.SendEmail(LoggedUser.Email, "changePin", LoggedUser.Login, verificationCode.ToString());

            VerificationCodeForm vcf = new VerificationCodeForm(VerificationCodeForm.Mode.ChangePin, verificationCode, controlsToDisable, LoggedUser.Login);
            vcf.Show();
        }
    }
}
