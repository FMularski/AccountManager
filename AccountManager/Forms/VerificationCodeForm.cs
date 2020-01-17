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
        public enum Mode
        {
            Register, 
            Reminder,
            ChangePassword,
            ChangePin
        }

        private Mode _Mode;
        private int VerificationCode;
        private User _User;
        private Control[] DisabledControls;
        public VerificationCodeForm( Mode mode, int code, Control[] controls, params string[] userData)
        {
            _Mode = mode;
            DisabledControls = new Control[4];
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
                        ChangePasswordForm cpf = new ChangePasswordForm(DisabledControls);
                        cpf.Show();
                        break;
                    case Mode.ChangePin:
                        this.Close();
                        ChangePinForm _cpf = new ChangePinForm(DisabledControls);
                        _cpf.Show();
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
