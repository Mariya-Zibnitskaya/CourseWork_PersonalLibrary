using ExampleCourseWork.Programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleCourseWork.Forms
{
    public partial class LoginForm : Form
    {
        private Librarian librarian;
        public LoginForm(Librarian librarian)
        {
            InitializeComponent();
            this.librarian = librarian;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (librarian.Authenticate(UsernameTextBox.Text, PasswordTextBox.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
