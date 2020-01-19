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

namespace AccountManager.Forms
{
    public partial class MainForm : Form
    {
        private User LoggedUser;
        public LoginForm _LoginForm;
        public List<Control> DisabledControls;

        public MainForm(LoginForm loginForm, User loggedUser)
        {
            LoggedUser = loggedUser;
            _LoginForm = loginForm;
            InitializeComponent();
            DisabledControls = new List<Control>() { AddAccountButton, ExportButton, SettingsButton };
            LoggedInAsLabel.Text += LoggedUser.Login;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateAccountsDisplay();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _LoginForm.Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm(this, LoggedUser);
            sf.Show();
            this.Hide();
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            AccountForm af = new AccountForm( AccountForm.Mode.Add, LoggedUser, UpdateAccountsDisplay, DisabledControls);
            af.Show();
            FormUtilities.DisableControls(DisabledControls.ToArray());

        }

        private void UpdateAccountsDisplay()
        {
            AccountsPanel.Controls.Clear();

            List<string> titles = DBManager.GetColumnValuesWhere("Accounts", "Title", "UserId", DBManager.GetSingleValueWhere("Users", "Id", "Login", LoggedUser.Login).ToString());

            List<string> logins = DBManager.GetColumnValuesWhere("Accounts", "Login", "UserId", DBManager.GetSingleValueWhere("Users", "Id", "Login", LoggedUser.Login).ToString());

            List<string> emails = DBManager.GetColumnValuesWhere("Accounts", "Associated_Email", "UserId", DBManager.GetSingleValueWhere("Users", "Id", "Login", LoggedUser.Login).ToString());

            List<string> ids = DBManager.GetColumnValuesWhere("Accounts", "Id", "UserId", DBManager.GetSingleValueWhere("Users", "Id", "Login", LoggedUser.Login).ToString());

            for ( int i = 0; i < titles.Count; i++)
            {
                Label title = new Label() { Text = titles[i] };
                title.AutoSize = true;
                title.Font = new Font(new FontFamily("Century Gothic"), 9f);
                title.Location = new Point() { X = TitleLabel.Location.X, Y = i * title.PreferredHeight * 2};
                AccountsPanel.Controls.Add(title);

                Label login = new Label() { Text = logins[i] };
                login.AutoSize = true;
                login.Font = new Font(new FontFamily("Century Gothic"), 9f);
                login.Location = new Point() { X = LoginLabel.Location.X, Y = i * title.PreferredHeight * 2 };
                AccountsPanel.Controls.Add(login);

                Label email = new Label() { Text = emails[i] };
                email.AutoSize = true;
                email.Font = new Font(new FontFamily("Century Gothic"), 9f);
                email.Location = new Point() { X = AssociatedEmailLabel.Location.X, Y = i * title.PreferredHeight * 2 };
                AccountsPanel.Controls.Add(email);

                Label password = new Label() { Text = "Click to show" };
                password.AutoSize = true;
                password.Font = new Font(new FontFamily("Century Gothic"), 9f);
                password.Location = new Point() { X = PasswordLabel.Location.X, Y = i * title.PreferredHeight * 2 };
                password.Click += Password_Click;
                password.ImageIndex = Convert.ToInt32(ids[i]);
                DisabledControls.Add(password);
                AccountsPanel.Controls.Add(password);

                Button editButton = new Button();
                editButton.Text = "Edit";
                editButton.Font = new Font(new FontFamily("Century Gothic"), 9f);
                editButton.BackColor = Color.White;
                editButton.Location = new Point() { X = EditButtonsLabel.Location.X, Y = i * title.PreferredHeight * 2 };
                editButton.Size = editButton.PreferredSize;
                editButton.ImageIndex = Convert.ToInt32(ids[i]);
                editButton.Click += EditButton_Click;
                DisabledControls.Add(editButton);
                AccountsPanel.Controls.Add(editButton);

                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Font = new Font(new FontFamily("Century Gothic"), 9f);
                deleteButton.BackColor = Color.IndianRed;
                deleteButton.ForeColor = Color.White;
                deleteButton.Location = new Point() { X = DeleteButtonsLabel.Location.X, Y = i * title.PreferredHeight * 2 };
                deleteButton.Size = deleteButton.PreferredSize;
                deleteButton.ImageIndex = Convert.ToInt32(ids[i]);
                deleteButton.Click += DeleteButton_Click;
                DisabledControls.Add(deleteButton);
                AccountsPanel.Controls.Add(deleteButton);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Deleting account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DBManager.DeleteAccountById(button.ImageIndex);
                UpdateAccountsDisplay();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Button editButton = sender as Button;
            string[] accountData = {
                DBManager.GetSingleValueWhere("Accounts", "Title", "Id", editButton.ImageIndex.ToString()),
                DBManager.GetSingleValueWhere("Accounts", "Login", "Id", editButton.ImageIndex.ToString()),
                DBManager.GetSingleValueWhere("Accounts", "Associated_Email", "Id", editButton.ImageIndex.ToString()),
                DBManager.GetSingleValueWhere("Accounts", "Password", "Id", editButton.ImageIndex.ToString()),
                editButton.ImageIndex.ToString() /* id */
            };

            AccountForm af = new AccountForm(AccountForm.Mode.Edit, LoggedUser, UpdateAccountsDisplay, DisabledControls, accountData);
            af.Show();
            FormUtilities.DisableControls(DisabledControls.ToArray());
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Label password = sender as Label;

            PinForm pf = new PinForm(LoggedUser, password, DisabledControls, Password_Click);
            pf.Show();
            FormUtilities.DisableControls(DisabledControls.ToArray());
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

            int verificationCode = new Random().Next(100000, 999999);

            EmailManager.SendEmail(DBManager.GetSingleValueWhere("Users", "Email", "Login", LoggedUser.Login), "export", LoggedUser.Login, verificationCode.ToString());

            VerificationCodeForm vcf = new VerificationCodeForm(VerificationCodeForm.Mode.Export, verificationCode, DisabledControls.ToArray(),
                LoggedUser.Login);
            vcf.Show();
            FormUtilities.DisableControls(DisabledControls.ToArray());
        }
    }
}
