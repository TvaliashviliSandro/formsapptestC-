using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace savarjisho
{
    public partial class UserDialogForm : Form
    {
        public string FirstName => firstNameTextBox.Text;
        public string LastName => lastNameTextBox.Text;
        public string Email => emailTextBox.Text;
        public bool IsMale => maleCheckBox.Checked;
        public bool IsFemale => femaleCheckBox.Checked;
        public int Age => int.Parse(ageTextBox.Text);
        public UserDialogForm()
        {
            InitializeComponent();
            SaveButton.Click += SaveBtn_Click;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
