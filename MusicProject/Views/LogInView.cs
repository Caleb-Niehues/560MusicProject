using System;
using System.Windows.Forms;

namespace MusicProject.Views
{
    public partial class LogInView : Form
    {
        private static CheckCredentials check;
        private static CreateUser create;
        private static DeleteUser delete;
        private UpdateUser updateMain;

        public LogInView(UpdateUser user)
        {
            InitializeComponent();
            updateMain = user;
        }

        public static void InitializeDelegates(CheckCredentials checkDel, CreateUser createDel, DeleteUser deleteDel)
        {
            check = checkDel;
            create = createDel;
            delete = deleteDel;
        }

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            var temp = check(uxUsernameText.Text, uxPasswordText.Text);
            if (temp != null)
            {
                //MessageBox.Show("Logged in as: " + temp.Name);
                updateMain(temp);
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password or username");
                uxPasswordText.Clear();
                //uxUsernameText.Clear();
            }
        }

        private void uxCreateUser_Click(object sender, EventArgs e)
        {
            int tempInt;
            if (Int32.TryParse(uxUserWeight.Text, out tempInt))
            {
                updateMain(create(uxUsernameText.Text, uxPasswordText.Text, tempInt));
                this.Close();
            }
            else MessageBox.Show("You must enter a number for the weight");
        }

        private void uxDeleteUser_Click(object sender, EventArgs e)
        {
            if (delete(uxUsernameText.Text, uxPasswordText.Text))
            {
                updateMain(null);
                this.Close();
            }
            else MessageBox.Show("Account could not be deleted");
        }
    }
}
