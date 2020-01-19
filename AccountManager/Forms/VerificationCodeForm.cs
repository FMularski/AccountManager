using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AccountManager
{
    public partial class VerificationCodeForm : Form
    {
        public enum Mode
        {
            Register, 
            Reminder,
            ChangePassword,
            ChangePin,
            Export
        }

        private Mode _Mode;
        private int VerificationCode;
        private User _User;
        private Control[] DisabledControls;
        public VerificationCodeForm( Mode mode, int code, Control[] controls, params string[] userData)
        {
            _Mode = mode;
            DisabledControls = new Control[controls.Length];
            controls.CopyTo(DisabledControls, 0);

            VerificationCode = code;

            switch (_Mode)
            {
                case Mode.Register:
                    _User = new User(userData[0], userData[1], userData[2], userData[3]);
                    break;
                case Mode.Reminder:
                    _User = new User(userData[0], userData[1], userData[2], "");
                    break;
                case Mode.ChangePassword:
                    _User = new User(userData[0], "", "", "");
                    break;
                case Mode.ChangePin:
                    _User = new User(userData[0], "", "", "");
                    break;
                case Mode.Export:
                    _User = new User(userData[0], "", "", "");
                    break;
            }

            InitializeComponent();
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            string enteredCode = CodeTextBox.Text;

            if (enteredCode.Equals(VerificationCode.ToString()))
            {
                switch (_Mode)
                {
                    case Mode.Register:
                        DBManager.AddUser(_User.Login, _User.Email, _User.Password, _User.Pin);
                        this.Close();
                        MessageBox.Show($"User \'{_User.Login}\' has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case Mode.Reminder:
                        EmailManager.SendEmail(_User.Email, "reminder", _User.Password);
                        this.Close();
                        MessageBox.Show("Your password has been sent to your email address.", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        break;
                    case Mode.ChangePassword:
                        this.Close();
                        ChangePasswordForm cpf = new ChangePasswordForm( _User, DisabledControls);
                        cpf.Show();
                        break;
                    case Mode.ChangePin:
                        this.Close();
                        ChangePinForm _cpf = new ChangePinForm( _User, DisabledControls);
                        _cpf.Show();
                        break;
                    case Mode.Export:
                        this.Close();
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.ShowDialog();

                        string path = sfd.FileName;

                        List<string> titles = DBManager.GetColumnValuesWhere("Accounts", "Title", "UserId", DBManager.GetSingleValueWhere("Users", "Id", "Login", _User.Login).ToString());

                        List<string> logins = DBManager.GetColumnValuesWhere("Accounts", "Login", "UserId", DBManager.GetSingleValueWhere("Users", "Id", "Login", _User.Login).ToString());

                        List<string> emails = DBManager.GetColumnValuesWhere("Accounts", "Associated_Email", "UserId", DBManager.GetSingleValueWhere("Users", "Id", "Login", _User.Login).ToString());

                        List<string> passwords = DBManager.GetColumnValuesWhere("Accounts", "Password", "UserId", DBManager.GetSingleValueWhere("Users", "Id", "Login", _User.Login).ToString());

                        try
                        {
                            using (StreamWriter sw = new StreamWriter(path))
                            {
                                for (int i = 0; i < titles.Count; i++)
                                {
                                    string accountRowForFile = "Title: " + titles[i] + "\tLogin: " + logins[i] + "\tAssociated email: " +
                                        emails[i] + "\tPassword: " + passwords[i];

                                    sw.WriteLine(accountRowForFile);
                                }
                            }

                            MessageBox.Show("Your data has been successfully exported.\n\nWarning: The exported file contains all of your accounts data. Be cautious when granting access to this file. Deleting the file\nfrom widely accessible disk space is recommended.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception) 
                        {
                            MessageBox.Show("Export has been cancelled.", "Export cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
            }
            else
            {
                FormUtilities.ClearTextBoxes(CodeTextBox);
                MessageBox.Show("Invalid verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificationCodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtilities.EnableControls(DisabledControls);
        }
    }
}
