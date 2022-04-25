using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicProject.Mic;

namespace MusicProject.Views
{
    public partial class uxLogInView : Form
    {
        public CheckCredentials check;
        private DatabaseProxy proxy;

        public uxLogInView(DatabaseProxy proxy, CheckCredentials check)
        {
            InitializeComponent();
            proxy = this.proxy;
            check = this.check;
        }

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            if (check(uxPasswordText.Text, uxUsernameText.Text, proxy))
            {
                //this.Hide();
                this.Close();
                //View v = new View(proxy);
                //v.Show();
            }
            else
            {
                MessageBox.Show("Incorrect password or username");
            }
            uxPasswordText.Clear();
            uxUsernameText.Clear();
        }
    }
}
