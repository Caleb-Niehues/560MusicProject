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
        private LogInView login;
        private Search search;

        private UserModel activeUser = null;

        private ReviewModel _reviewModel = null;

        private IReadOnlyList<PersonModel> members = new List<PersonModel>();

        private IReadOnlyList<ArtistModel> artists = new List<ArtistModel>();

        private IReadOnlyList<SongModel> songs = new List<SongModel>();

        private IReadOnlyList<ProducerModel> producers = new List<ProducerModel>();

        private IReadOnlyList<RecordLabelModel> recordLabels = new List<RecordLabelModel>();

        private IReadOnlyList<AlbumModel> albums = new List<AlbumModel>();

        public MainView(MainController controller)
        {
            InitializeComponent();
            search = controller.Search;
        }

        private void RegisterLogin(UserModel user)
        {
            activeUser = user;
            if (activeUser == null)
                uxUserLabel.Text = "Not logged in";
            else
                uxUserLabel.Text = "Logged in as: " + activeUser.Name;
        }

        public void RegisterSearch(IReadOnlyList<ArtistModel> artists, IReadOnlyList<SongModel> songs, IReadOnlyList<ProducerModel> producers, IReadOnlyList<AlbumModel> albums)
        {
            uxArtistListBox.DataSource = artists;
            uxSongList.DataSource = songs;
            uxProducerList.DataSource = producers;
            ux
        }

        private void uxSearch_HitEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (search(uxLookUpText.Text))
                {
                    
                }
                else MessageBox.Show("No name found on data base - needs to be an exact match");
            }
        }

        private void uxLogIn_Click(object sender, EventArgs e)
        {
            login = new LogInView(RegisterLogin);
            login.Show();
        }

        private void uxLeaveReview_Click(object sender, EventArgs e)
        {

        }
    }
}
