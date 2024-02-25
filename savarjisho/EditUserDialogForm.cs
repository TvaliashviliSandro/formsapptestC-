using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditUserDialogForm : Form
    {
        private User? user;
        public string FirstName
        {
            get => firstNameTextBox.Text;
            set => firstNameTextBox.Text = value;
        }

        public string LastName
        {
            get => lastNameTextBox.Text;
            set => lastNameTextBox.Text = value;
        }

        public string Email
        {
            get => emailTextBox.Text;
            set => emailTextBox.Text = value;
        }

        public bool IsMale
        {
            get => maleCheckBox.Checked;
            set => maleCheckBox.Checked = value;
        }

        public bool IsFemale
        {
            get => femaleCheckBox.Checked;
            set => femaleCheckBox.Checked = value;
        }

        public int Age
        {
            get => int.Parse(ageTextBox.Text);
            set => ageTextBox.Text = value.ToString();
        }
        public EditUserDialogForm()
        {
            InitializeComponent();
            SaveButton.Click += SaveButton_Click;
        }
        public EditUserDialogForm(User user) : this()
        {
            this.user = user;
            SetUser(user);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        public void SetUser(User user)
        {
            if (user != null)
            {
                FirstName = user.FirstName;
                LastName = user.LastName;
                Email = user.Email;
                IsMale = user.IsMale;
                IsFemale = user.IsFemale;
                Age = user.Age;
            }
        }

    }
}
