using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;


namespace AccountManager
{
    public partial class RegisterForm : Form
    {
        private Control[] DisabledControls;

        public RegisterForm(Control[] controls)
        {
            DisabledControls = new Control[3];
            InitializeComponent();
            controls.CopyTo(DisabledControls, 0);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirm = ConfirmTextBox.Text;
            string pin = PinTextBox.Text;

            /* CHECK IF ALL FIELDS HAS INPUT*/
            if (new string[] { login, email, password, confirm, pin}.Contains(""))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(PasswordTextBox, ConfirmTextBox, PinTextBox);
                return;
            }

            /* CHECK IF LOGIN IS AVAILABLE */
            if (DBManager.GetColumnValues("Users", "Login").Contains(login))
            {
                MessageBox.Show($"Login \'{login}\' is already used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes( LoginTextBox ,PasswordTextBox, ConfirmTextBox, PinTextBox);
                return;
            }

            /* CHECK EMAIL FORMAT */
            if (!Regex.IsMatch(email, "[^@]+@[^@]+\\.[^@]+"))
            {
                MessageBox.Show($"Invalid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(EmailTextBox, PasswordTextBox, ConfirmTextBox, PinTextBox);
                return;
            }

            /* CHECK PASSWORD LENGTH */
            if (password.Length < 8)
            {
                MessageBox.Show($"Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(PasswordTextBox, ConfirmTextBox, PinTextBox);
                return;
            }

            /* CHECK PASSWORD CONFIRMATION */
            if (!password.Equals(confirm))
            {
                MessageBox.Show("Password and password confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(PasswordTextBox, ConfirmTextBox, PinTextBox);
                return;
            }

            

            int verificationCode = new Random().Next(100000, 999999);


            EmailManager.SendEmail(email, "greeting", login, verificationCode.ToString());
            this.Close();
            
            VerificationCodeForm vcf = new VerificationCodeForm( VerificationCodeForm.Mode.Register, verificationCode, DisabledControls, login, email, password, pin);
            vcf.Show();
            FormUtilities.DisableControls(DisabledControls);
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtilities.EnableControls(DisabledControls);
        }
    }
}
