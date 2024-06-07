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
    public partial class InputBoxForm : Form
    {
        public string InputText { get; set; }
        public InputBoxForm()
        {
            InitializeComponent();
        }

        private void SaveNameButton_Click(object sender, EventArgs e)
        {
            InputText = collectionTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(InputText))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть назву колекції.");
            }
        }

        private void CancelNameButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
