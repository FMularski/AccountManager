using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            List<string> passwords = DBManager.GetColumnValuesWhere("Accounts", "Password", "UserId", DBManager.GetSingleValueWhere("Users", "Id", "Login", LoggedUser.Login).ToString());

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

                Label password = new Label() { Text = passwords[i] };
                password.AutoSize = true;
                password.Font = new Font(new FontFamily("Century Gothic"), 9f);
                password.Location = new Point() { X = PasswordLabel.Location.X, Y = i * title.PreferredHeight * 2 };
                AccountsPanel.Controls.Add(password);



            }
        }
    }
}
