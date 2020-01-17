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

        public ChangePinForm(Control[] controls)
        {
            InitializeComponent();
            DisabledControls = new Control[4];
            controls.CopyTo(DisabledControls, 0);

            FormUtilities.DisableControls(DisabledControls);
        }

        
        private void ChangePinButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangePinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtilities.EnableControls(DisabledControls);
        }
    }
}
