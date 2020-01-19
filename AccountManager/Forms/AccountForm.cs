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

namespace AccountManager
{
    public partial class AccountForm : Form
    {
        public enum Mode
        {
            Add,
            Edit
        }

        private List<Control> DisabledControls;
        private Mode _Mode;
        private User LoggedUser;

        public delegate void UpdateAccountDisplayDel();
        private UpdateAccountDisplayDel UpdateDisplay;

        public AccountForm(Mode mode, User loggedUser, UpdateAccountDisplayDel callback, List<Control> controls)
        {
            InitializeComponent();
            DisabledControls = controls;

            _Mode = mode;
            LoggedUser = loggedUser;

            AddEditAccountLabel.Text = "Add account";
            this.Text = "Add account";
            AddEditButton.Text = "Add";
            UpdateDisplay = callback;
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtilities.EnableControls(DisabledControls.ToArray());
        }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string login = LoginTextBox.Text;
            string associatedEmail = AssociatedEmailTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirm = ConfirmTextBox.Text;

            if ( title.Equals(""))
            {
                MessageBox.Show("Title is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(PasswordTextBox, ConfirmTextBox);
                return;
            }

            if ( login.Equals("") && associatedEmail.Equals(""))
            {
                MessageBox.Show("Login or associated email is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(PasswordTextBox, ConfirmTextBox);
                return;
            }

            if (!associatedEmail.Equals("") && !Regex.IsMatch(associatedEmail, "[^@]+@[^@]+\\.[^@]+"))
            {
                MessageBox.Show($"Invalid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(AssociatedEmailTextBox, PasswordTextBox, ConfirmTextBox);
                return;
            }

            if (password.Equals(""))
            {
                MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(PasswordTextBox, ConfirmTextBox);
                return;
            }

            if (!password.Equals(confirm))
            {
                MessageBox.Show("Password and password confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(PasswordTextBox, ConfirmTextBox);
                return;
            }


            DBManager.AddAccount(title, login, associatedEmail, password, DBManager.GetSingleValueWhere("Users", "Id", "Login", LoggedUser.Login));
            MessageBox.Show("Account has beed successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            UpdateDisplay();
        }
    }
}
