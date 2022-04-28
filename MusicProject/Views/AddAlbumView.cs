using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicProject.Views
{
    public partial class AddAlbumView : Form
    {
        private static RetrieveProducersByAlbum getProd;
        private static RetrieveLabelsByAlbum getLabels;
        private static RetrieveSongsByAlbum getSongs;

        private AlbumModel album;
        private List<ProducerModel> producers = new List<ProducerModel>();
        private List<RecordLabelModel> labels = new List<RecordLabelModel>();
        private List<SongModel> songs = new List<SongModel>();

        public AddAlbumView(AlbumModel album)
        {
            InitializeComponent();
            this.album = album;
            uxProducerList.DataSource = producers;
            uxRecordLabelList.DataSource = labels;
            uxSongList.DataSource = songs;
        }

        public static void InitializeDelegates(RetrieveProducersByAlbum retProducers,
                                                RetrieveLabelsByAlbum retRecordLabels, RetrieveSongsByAlbum retSongs)
        {
            getProd = retProducers;
            getLabels = retRecordLabels;
            getSongs = retSongs;
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
            if (e.KeyCode == Keys.Enter)// && !search(uxLookUpText.Text)) //update is called by search
                MessageBox.Show("No name found on data base - needs to be an exact match");
        }

        private void uxFetchProducerText_HitEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)// && !search(uxLookUpText.Text)) //update is called by search
                MessageBox.Show("No name found on data base - needs to be an exact match");
        }

        private void uxFinishButton_Click(object sender, EventArgs e)
        {

        }
    }
}
