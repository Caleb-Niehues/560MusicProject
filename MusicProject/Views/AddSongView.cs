using System;
using System.Windows.Forms;
using MusicProject.Models;

namespace MusicProject.Views
{
    public partial class AddSongView : Form
    {
        private updateSongs update;

        private string albumTitle;
        private string artistName;

        public AddSongView(updateSongs update, string albumTitle, string artistName)
        {
            InitializeComponent();
            this.update = update;
            this.albumTitle = albumTitle;
            this.artistName = artistName;
            uxAlbumLabel.Text = albumTitle;
            uxArtistLabel.Text = artistName;
            uxGenreDropDown.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void uxAddSongButton_Click(object sender, EventArgs e)
        {
            string name = uxNameBox.Text;
            int minutes = (int)uxMinute.Value;
            int seconds = (int)uxSecond.Value;
            TimeSpan length = new TimeSpan(0, minutes, seconds);
            if (!string.IsNullOrWhiteSpace(name) && length > TimeSpan.Zero)
            {
                update(new SongModel(uxNameBox.Text, albumTitle, artistName, (Genre)uxGenreDropDown.SelectedIndex, length));
            }
            else MessageBox.Show("All fields must be filled out");
        }
    }
}
