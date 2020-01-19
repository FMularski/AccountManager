﻿using System;
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

        public MainForm(LoginForm loginForm, User loggedUser)
        {
            LoggedUser = loggedUser;
            _LoginForm = loginForm;
            InitializeComponent();

            LoggedInAsLabel.Text += LoggedUser.Login;

            //for ( int i = 0; i < 40; i++)
            //{
            //    CheckBox c = new CheckBox();
            //    c.Text = i.ToString();
            //    c.Location = new Point(10, AccountsPanel.Controls.Count * 20);

            //    AccountsPanel.Controls.Add(c);
            //}


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
            AccountForm af = new AccountForm();
            af.Show();
        }
    }
}
