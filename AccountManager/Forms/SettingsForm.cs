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

        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            _MainForm = mainForm;
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
    }
}
