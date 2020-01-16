using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace AccountManager
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();

            //using (SQLiteCommand command = Connection.CreateCommand())
            //{
            //    command.CommandText = "SELECT * FROM Users";
            //    command.CommandType = CommandType.Text;
            //    SQLiteDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //        LoginTextBox.AppendText(reader.GetString(2).ToString());
            //}

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string[] userInput = { LoginTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text, PinTextBox.Text};

            if (userInput.Contains(""))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormUtilities.ClearTextBoxes(PasswordTextBox, ConfirmTextBox, PinTextBox);
                return;
            }


            DBManager.AddUser(LoginTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text, PinTextBox.Text);
        }
    }
}
