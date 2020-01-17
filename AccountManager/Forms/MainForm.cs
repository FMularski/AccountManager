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
        private LoginForm _LoginForm;

        public MainForm(LoginForm loginForm, User loggedUser)
        {
            LoggedUser = loggedUser;
            _LoginForm = loginForm;
            InitializeComponent();

            LoggedInAsLabel.Text += LoggedUser.Login;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _LoginForm.Close();
        }
    }
}
