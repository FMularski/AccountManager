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
    public partial class MainForm : Form
    {
        public MainForm()
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
