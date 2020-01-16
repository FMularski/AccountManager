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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void DontHaveAccButton_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            DontHaveAccButton.Enabled = false;
            rf.Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

        }
    }
}
