﻿using MusicProject.Models;
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

        public AddAlbumView(AlbumModel album)
        {
            InitializeComponent();
            this.album = album;
            if (album != null)
            {
                title = album.Title;
                uxTitleBox.ReadOnly = true;
                artist = album.Artist;
                uxArtistBox.ReadOnly = true;
                uxReleaseDate.Enabled = false;
            }
            uxCertificationCombo.DataSource = Enum.GetValues(typeof(Certification));
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

        private void AddAlbumView_Load(object sender, EventArgs e)
        {
            if (album != null)
            {
                //producers = getProd();
            }
        }

        private void updateProducers(ProducerModel producer)
        {
            producers.Add(producer);
            uxProducerList.DataSource = null;
            uxProducerList.DataSource = producers;
        }

        private void uxNewProducerButton_Click(object sender, EventArgs e)
        {
            new AddProducerView(updateProducers).Show();
        }

        private void updateLabel(RecordLabelModel recordLabel)
        {
            label = recordLabel;
            uxLabelLabel.Text = "Record label: " + label.Name;
        }

        private void uxNewRecordLabelButton_Click(object sender, EventArgs e)
        {
            new AddRecordLabelView(updateLabel).Show();
        }

        private void updateSongs(SongModel song)
        {
            songs.Add(song);
            uxSongList.DataSource = null;
            uxSongList.DataSource = songs;
        }

        private void uxNewSongButton_Click(object sender, EventArgs e)
        {
            new AddSongView(updateSongs, artist.Name, title).Show();
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
            title = uxTitleBox.Text;

            length = new TimeSpan();
            foreach (SongModel song in songs)
                length += song.Length;

            create(title, uxReleaseDate.Value, artist, songs, length, producers, label, (Certification)uxCertificationCombo.SelectedIndex);
            this.Close();
        }

        private bool isFinished()
        {
            return !string.IsNullOrWhiteSpace(title) && artist != null && songs.Count > 0 && length > TimeSpan.Zero && producers.Count > 0 && label != null;
        }

        private void uxTitleBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(uxTitleBox.Text))
                uxNewSongButton.Enabled = artist != null;
        }
    }
}
