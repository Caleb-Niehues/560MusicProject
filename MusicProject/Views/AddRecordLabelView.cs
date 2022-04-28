using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicProject.Views
{
    public partial class AddRecordLabelView : Form
    {
        private static CreateLabel create;

        public AddRecordLabelView()
        {
            InitializeComponent();
        }

        public static void InitializeDelegates(CreateLabel createLabel)
        {
            create = createLabel;
        }

        private void uxAddRLButton_Click(object sender, EventArgs e)
        {
            string name = uxNameText.Text;
            string location = uxLocationText.Text;
            DateTime? ended;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please add a name!");
            }
            else if(string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Please add a location!");
            }
            else
            {
                if (uxEndedCheck.Checked)
                    ended = null;
                else
                    ended = uxEndedDate.Value;

                var label = create(uxNameText.Text, uxFoundedDate.Value, ended, uxLocationText.Text);
                MessageBox.Show("Artist successfully added as: " + label.ToString());
                this.Close();
            }
        }

        private void uxEndedCheck_CheckedChanged(object sender, EventArgs e)
        {
            uxEndedDate.Enabled = !uxEndedDate.Enabled;
        }
    }
}
