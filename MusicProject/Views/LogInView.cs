using System;
using System.Windows.Forms;
using MusicProject.Mic;
using MusicProject.Models;

namespace MusicProject.Views
{
    public partial class LogInView : Form
    {
        private static CheckCredentials check;
        private DatabaseProxy proxy;

        public LogInView(DatabaseProxy proxy, CheckCredentials check)
        {
            InitializeComponent();
            //proxy = this.proxy;
            //check = this.check;
        }

        public static void InitializeDelegates(CheckCredentials checkProxy)
        {
            check = checkProxy;
        }

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            UserModel temp = check(uxUsernameText.Text, uxPasswordText.Text);
            if (temp != null)
            {
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
