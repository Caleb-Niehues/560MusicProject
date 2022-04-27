using System;
using System.Windows.Forms;

namespace MusicProject.Views
{
    public partial class AddAlbumView : Form
    {
        public AddAlbumView()
        {
            InitializeComponent();
        }

        private void uxNewProducerButton_Click(object sender, EventArgs e)
        {

        }

        private void uxFetchRecordLabelText_HitEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)// && !search(uxLookUpText.Text)) //update is called by search
                MessageBox.Show("No name found on data base - needs to be an exact match");
        }

        private void uxFetchProducerText_HitEnter(object sender, KeyEventArgs e)
        {

        }

        private void uxNewRecordLabelButton_Click(object sender, EventArgs e)
        {

        }

        private void uxNewSongButton_Click(object sender, EventArgs e)
        {

        }

        private void uxFinishButton_Click(object sender, EventArgs e)
        {

        }
    }
}
