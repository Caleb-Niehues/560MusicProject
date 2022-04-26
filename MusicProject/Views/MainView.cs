using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicProject.Controllers;
using MusicProject.Models;
using System.Windows.Forms;

namespace MusicProject.Views
{
    public delegate void UpdateUser(UserModel user);
    public partial class MainView : Form
    {
        public MainView(MainController controller)
        {
            InitializeComponent();
            search = controller.Search;
            uxFocusedList.DataSource = albums;
        }

        #region Basic Fields
        private LogInView login;
        public AddProducerView producerView;

        public CheckCredentials check;
        private Search search;

        private UserModel activeUser = null;
        private IReadOnlyList<PersonModel> people = new List<PersonModel>();
        private IReadOnlyList<ArtistModel> artists = new List<ArtistModel>();
        private IReadOnlyList<SongModel> songs = new List<SongModel>();
        private IReadOnlyList<ProducerModel> producers = new List<ProducerModel>();
        private IReadOnlyList<RecordLabelModel> recordLabels = new List<RecordLabelModel>();
        private IReadOnlyList<AlbumModel> albums = new List<AlbumModel>();
        #endregion

        #region Search and Focus
        public void RegisterSearch(IReadOnlyList<AlbumModel> albums, IReadOnlyList<ArtistModel> artists, IReadOnlyList<SongModel> songs, IReadOnlyList<PersonModel> people, IReadOnlyList<ProducerModel> producers, IReadOnlyList<RecordLabelModel> recordLabels)
        {
            this.albums = albums;
            this.artists = artists;
            this.songs = songs;
            this.people = people;
            this.producers = producers;
            this.recordLabels = recordLabels;

            uxAlbumListBox.DataSource = albums;
            uxArtistListBox.DataSource = artists;
            uxSongList.DataSource = songs;
            uxPersonList.DataSource = people;
            uxProducerList.DataSource = producers;
            uxRecordLabelList.DataSource = recordLabels;
            uxFocusedList.Refresh();
        }

        private void uxSearch_HitEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !search(uxLookUpText.Text)) //update is called by search
                    MessageBox.Show("No name found on data base - needs to be an exact match");
        }

        private void uxAlbumsFocus_CheckedChanged(object sender, EventArgs e)
        {
            uxFocusedList.DataSource = albums;
        }

        private void uxSongsFocus_CheckedChanged(object sender, EventArgs e)
        {
            uxFocusedList.DataSource = songs;
        }

        private void uxArtistsFocus_CheckedChanged(object sender, EventArgs e)
        {
            uxFocusedList.DataSource = artists;
        }

        private void uxLabelsFocus_CheckedChanged(object sender, EventArgs e)
        {
            uxFocusedList.DataSource = recordLabels;
        }

        private void uxProducersFocus_CheckedChanged(object sender, EventArgs e)
        {
            uxFocusedList.DataSource = producers;
        }

        private void uxPeopleFocus_CheckedChanged(object sender, EventArgs e)
        {
            uxFocusedList.DataSource = people;
        }
        #endregion

        #region User Actions
        private void RegisterLogin(UserModel user)
        {
            activeUser = user;
            if (activeUser == null)
                uxUserLabel.Text = "Not logged in";
            else
                uxUserLabel.Text = "Logged in as: " + activeUser.Name;
        }

        private void uxLogIn_Click(object sender, EventArgs e)
        {
            login = new LogInView(RegisterLogin);
            login.Show();
        }

        private void uxLeaveReview_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Add to DB
        private void uxAddAlbum_Click(object sender, EventArgs e)
        {

        }

        private void uxAddArtist_Click(object sender, EventArgs e)
        {

        }

        private void uxAddRecordLabel_Click(object sender, EventArgs e)
        {

        }

        private void uxAddProducer_Click(object sender, EventArgs e)
        {
            producerView = new AddProducerView();
            producerView.Show();
        }

        private void uxAddPerson_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
