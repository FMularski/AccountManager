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
    public partial class PinForm : Form
    {
        private System.EventHandler PasswordClick;

        private List<Control> DisabledControls;
        private Label PasswordLabel;
        private User LoggedUser;
        public PinForm(User loggedUser, Label password, List<Control> controls, System.EventHandler click)
        {
            InitializeComponent();
            DisabledControls = controls;
            PasswordLabel = password;
            LoggedUser = loggedUser;
            PasswordClick = click;
        }

        private void PinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtilities.EnableControls(DisabledControls.ToArray());
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string pin = PinTextBox.Text;

            if ( pin.Equals(""))
            {
                MessageBox.Show("PIN is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!pin.Equals(DBManager.GetSingleValueWhere("Users", "Pin", "Login", LoggedUser.Login)))
            {
                MessageBox.Show("Invalid PIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(PinTextBox);
                return;
            }

            PasswordLabel.Text = DBManager.GetSingleValueWhere("Accounts", "Password", "Id", PasswordLabel.ImageIndex.ToString());
            PasswordLabel.Click -= PasswordClick;

            this.Close();
        }
    }
}
