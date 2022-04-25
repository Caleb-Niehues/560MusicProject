using System;
using System.Windows.Forms;
using MusicProject.Mic;
using MusicProject.Models;

namespace MusicProject.Views
{
    public partial class LogInView : Form
    {
        private static CheckCredentials check;
        private UpdateUser updateMain;
        private DatabaseProxy proxy;

        public LogInView(UpdateUser user)
        {
            InitializeComponent();
            updateMain = user;
        }

        public static void InitializeDelegates(CheckCredentials checkProxy)
        {
            check = checkProxy;
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
    }
}
