using System.Windows.Forms;

namespace savarjisho
{
    public partial class Form1 : Form
    {
        private int nextUserId = 1;
        private List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }
        private int GenerateUniqueId()
        {
            return nextUserId++;
        }
        private void RefreshUserList()
        {
            UserData.Items.Clear();
            foreach (User user in users)
            {
                UserData.Items.Add($"{user.ID}: {user.FirstName} {user.LastName}");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (UserDialogForm addUserDialog = new UserDialogForm())
            {
                if (addUserDialog.ShowDialog() == DialogResult.OK)
                {
                    users.Add(new User
                    {
                        ID = GenerateUniqueId(),
                        FirstName = addUserDialog.FirstName,
                        LastName = addUserDialog.LastName,
                        Email = addUserDialog.Email,
                        IsMale = addUserDialog.IsMale,
                        IsFemale = addUserDialog.IsFemale,
                        Age = addUserDialog.Age
                    });

                    RefreshUserList();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (UserData.SelectedIndex != -1)
            {

                User selectedUser = users[UserData.SelectedIndex];


                using (EditUserDialogForm editUserDialog = new EditUserDialogForm())
                {
                    editUserDialog.SetUser(selectedUser);

                    if (editUserDialog.ShowDialog() == DialogResult.OK)
                    {

                        users[UserData.SelectedIndex].FirstName = editUserDialog.FirstName;
                        users[UserData.SelectedIndex].LastName = editUserDialog.LastName;
                        users[UserData.SelectedIndex].Email = editUserDialog.Email;
                        users[UserData.SelectedIndex].IsMale = editUserDialog.IsMale;
                        users[UserData.SelectedIndex].IsFemale = editUserDialog.IsFemale;
                        users[UserData.SelectedIndex].Age = editUserDialog.Age;

                        RefreshUserList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            users.RemoveAt(UserData.SelectedIndex);
            RefreshUserList();
        }
    }
}