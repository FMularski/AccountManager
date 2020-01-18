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
    public partial class ChangePinForm : Form
    {
        private Control[] DisabledControls;
        private User LoggedUser;

        public ChangePinForm(User loggedUser, Control[] controls)
        {
            InitializeComponent();
            DisabledControls = new Control[4];
            controls.CopyTo(DisabledControls, 0);
            LoggedUser = loggedUser;

            FormUtilities.DisableControls(DisabledControls);
        }

        
        private void ChangePinButton_Click(object sender, EventArgs e)
        {
            string newPin = NewPinTextBox.Text;
            string confirmPin = ConfirmTextBox.Text;

            if (newPin.Equals("") || confirmPin.Equals(""))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(NewPinTextBox, ConfirmTextBox, ConfirmTextBox);
                return;
            }

            if (!newPin.Equals(confirmPin))
            {
                MessageBox.Show("New PIN and PIN confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes( NewPinTextBox, ConfirmTextBox);
                return;
            }

            DBManager.UpdateValueWhere("Users", "Pin", newPin, "Login", LoggedUser.Login);
            MessageBox.Show("PIN has been successfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            FormUtilities.EnableControls(DisabledControls);
        }

        private void ChangePinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtilities.EnableControls(DisabledControls);
        }
    }
}
