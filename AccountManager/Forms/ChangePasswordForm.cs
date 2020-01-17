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
    public partial class ChangePasswordForm : Form
    {
        private Control[] DisabledControls;

        public ChangePasswordForm(Control[] controls)
        {
            InitializeComponent();
            DisabledControls = new Control[4];
            controls.CopyTo(DisabledControls, 0);

            FormUtilities.DisableControls(DisabledControls);

        }

        private void ChangePasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtilities.EnableControls(DisabledControls);
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {

        }
    }
}
