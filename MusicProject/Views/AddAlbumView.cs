using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MusicProject.Views
{
    public partial class AddAlbumView : Form
    {
        private static CreateAlbum create;
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
        private BindingList<ProducerModel> producers = new BindingList<ProducerModel>();
        private BindingList<SongModel> songs = new BindingList<SongModel>();

        public AddAlbumView(AlbumModel album)
        {
            InitializeComponent();
            this.album = album;
            uxCertificationCombo.DataSource = Enum.GetValues(typeof(Certification));
            uxProducerList.DataSource = producers;
            uxSongList.DataSource = songs;
        }

        public static void InitializeDelegates(CreateAlbum createAlbum, RetrieveProducersByAlbum retProducers, RetrieveLabelsByAlbum retRecordLabels,
            RetrieveSongsByAlbum retSongs, FetchLabel fetchRecordLabel, FetchProducer fetchProducerDel)
        {
            create = createAlbum;
            getProd = retProducers;
            getLabels = retRecordLabels;
            getSongs = retSongs;
            fetchLabel = fetchRecordLabel;
            fetchProducer = fetchProducerDel;
        }

        private void AddAlbumView_Load(object sender, EventArgs e)
        {
            if (album != null)
            {
                //producers = getProd();
            }
        }

        private void uxNewProducerButton_Click(object sender, EventArgs e)
        {
            new AddProducerView().Show();
        }

        private void uxNewRecordLabelButton_Click(object sender, EventArgs e)
        {
            new AddRecordLabelView().Show();
        }

        private void uxNewSongButton_Click(object sender, EventArgs e)
        {
            new AddSongView().Show();
        }

        private void uxFetchRecordLabelText_HitEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tempLabel = fetchLabel(uxFetchLabelBox.Text);
                if (tempLabel == null) MessageBox.Show("No name found on data base - needs to be an exact match");
                else 
                {
                    label = tempLabel;
                    uxLabelLabel.Text = "Record label: " + label.Name;
                    MessageBox.Show("label updated to " + label.Name);
                }
            }
        }

        private void uxFetchProducerText_HitEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tempProducer = fetchProducer(uxFetchProducerText.Text);
                if (tempProducer == null) MessageBox.Show("No name found on data base - needs to be an exact match");
                else if (producers.Contains(tempProducer)) MessageBox.Show("Producer already added");
                else 
                {
                    producers.Add(tempProducer);
                    MessageBox.Show("producer added as " + tempProducer.Name);
                }
            }
        }

        private void uxFinishButton_Click(object sender, EventArgs e)
        {
            length = new TimeSpan();
            foreach (SongModel song in songs)
                length += song.Length;

            if (isFinished())
            {
                create(title, uxReleaseDate.Value, artist, songs, length, )
                this.Close();
            }
        }

        private bool isFinished()
        {
            return producers.Count > 0 && songs.Count > 0 && label != null && artist != null && !string.IsNullOrWhiteSpace(title) && length > TimeSpan.Zero;
        }
    }
}
