using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MusicProject.Views
{
    public delegate void updateProducers(ProducerModel producer);
    public delegate void updateLabel(RecordLabelModel label);
    public delegate void updateSongs(SongModel song);

    public partial class AddAlbumView : Form
    {
        private static CreateAlbum create;
        private static RetrieveArtistsByName getArtist;
        private static RetrieveProducersByAlbum getProd;
        private static RetrieveLabelsByAlbum getLabels;
        private static RetrieveSongsByAlbum getSongs;
        private static FetchLabel fetchLabel;
        private static FetchProducer fetchProducer;

        private AlbumModel album;
        private string title;
        private TimeSpan length;
        private ArtistModel artist;
        private RecordLabelModel label;
        private List<ProducerModel> producers = new List<ProducerModel>();
        private List<SongModel> songs = new List<SongModel>();

        private AddSongView addSong = null;

        public AddAlbumView(AlbumModel album)
        {
            InitializeComponent();
            this.album = album;
            uxCertificationCombo.DataSource = Enum.GetValues(typeof(Certification));

            if (album != null)
            {
                title = album.Title;
                artist = album.Artist;
                songs = album.Songs;
                producers = album.Producers;
                label = album.RecordLabel;

                uxTitleBox.Text = title;
                uxTitleBox.ReadOnly = true;

                uxArtistBox.Text = artist.Name;
                uxArtistBox.ReadOnly = true;

                uxReleaseDate.Value = album.ReleaseDate;

                uxCertificationCombo.SelectedIndex = (int)album.Certification;

                uxLabelLabel.Text = $"Record label: {label.Name}";

                uxFinishButton.Enabled = isFinished();
                uxNewSongButton.Enabled = true;
            }

            uxProducerList.DataSource = producers;
            uxSongList.DataSource = songs;
        }

        public static void InitializeDelegates(CreateAlbum createAlbum, RetrieveArtistsByName retArtist, RetrieveProducersByAlbum retProducers,
            RetrieveLabelsByAlbum retRecordLabels, RetrieveSongsByAlbum retSongs, FetchLabel fetchRecordLabel, FetchProducer fetchProducerDel)
        {
            create = createAlbum;
            getArtist = retArtist;
            getProd = retProducers;
            getLabels = retRecordLabels;
            getSongs = retSongs;
            fetchLabel = fetchRecordLabel;
            fetchProducer = fetchProducerDel;
        }

        private void uxTitleBox_Leave(object sender, EventArgs e)
        {
            if (album == null) title = uxTitleBox.Text;
            if (!string.IsNullOrWhiteSpace(title))
                uxNewSongButton.Enabled = artist != null;
            uxFinishButton.Enabled = isFinished();
        }

        private void updateProducers(ProducerModel producer)
        {
            producers.Add(producer);
            uxProducerList.DataSource = null;
            uxProducerList.DataSource = producers;
            uxFinishButton.Enabled = isFinished();
        }

        private void uxNewProducerButton_Click(object sender, EventArgs e)
        {
            new AddProducerView(updateProducers).Show();
        }

        private void updateLabel(RecordLabelModel recordLabel)
        {
            label = recordLabel;
            uxLabelLabel.Text = "Record label: " + label.Name;
            uxFinishButton.Enabled = isFinished();
        }

        private void uxNewRecordLabelButton_Click(object sender, EventArgs e)
        {
            new AddRecordLabelView(updateLabel).Show();
        }

        private void updateSongs(SongModel song)
        {
            if (songs.Contains(song))
            {
                songs[songs.IndexOf(song)] = song;
                MessageBox.Show($"Updated {song.Name}");
            }
            else
                songs.Add(song);

            length += song.Length;
            uxSongList.DataSource = null;
            uxSongList.DataSource = songs;
            uxFinishButton.Enabled = isFinished();
        }

        private void uxNewSongButton_Click(object sender, EventArgs e)
        {
            if (addSong == null || !addSong.IsOpen)
            {
                addSong = new AddSongView(updateSongs, title, artist.Name);
                addSong.Show();
            }
        }

        private void uxArtistBox_HitEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tempArtist = getArtist(uxArtistBox.Text);
                if (tempArtist.Count == 0)
                {
                    uxArtistBox.Clear();
                    MessageBox.Show("No name found on data base - needs to be an exact match");
                }
                else
                {
                    artist = tempArtist[0];
                    uxFinishButton.Enabled = isFinished();
                    uxNewSongButton.Enabled = !string.IsNullOrWhiteSpace(title);
                    MessageBox.Show("Artist updated to " + artist.Name);
                }
            }
        }

        private void uxFetchRecordLabelText_HitEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tempLabel = fetchLabel(uxFetchLabelBox.Text);
                if (tempLabel == null)
                {
                    uxFetchLabelBox.Clear();
                    MessageBox.Show("No name found on data base - needs to be an exact match");
                }
                else 
                {
                    label = tempLabel;
                    uxLabelLabel.Text = "Record label: " + label.Name;
                    uxFetchLabelBox.Clear();
                    uxFinishButton.Enabled = isFinished();
                    MessageBox.Show("Label updated to " + label.Name);
                }
            }
        }

        private void uxFetchProducerText_HitEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tempProducer = fetchProducer(uxFetchProducerText.Text);
                if (tempProducer == null) MessageBox.Show("No name found on data base - needs to be an exact match");
                else if (producers.Contains(tempProducer))
                {
                    uxFetchProducerText.Clear();
                    MessageBox.Show("Producer already added");
                }
                else 
                {
                    producers.Add(tempProducer);
                    uxProducerList.DataSource = null;
                    uxProducerList.DataSource = producers;
                    uxFetchProducerText.Clear();
                    uxFinishButton.Enabled = isFinished();
                    MessageBox.Show("producer added as " + tempProducer.Name);
                }
            }
        }

        private void uxFinishButton_Click(object sender, EventArgs e)
        {
            create(title, uxReleaseDate.Value, artist, songs, length, producers, label, (Certification)uxCertificationCombo.SelectedIndex);
            this.Close();
        }

        private bool isFinished()
        {
            return !(string.IsNullOrWhiteSpace(title)) && artist != null && songs.Count > 0 && length > TimeSpan.Zero && producers.Count > 0 && label != null;
        }
    }
}
