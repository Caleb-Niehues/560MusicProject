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
        public LogInView login;
        public CheckCredentials check;

        private UserModel activeUser;
        
        private ReviewModel reviewModel = null;

        private List<PersonModel> members = new List<PersonModel>();
        
        private ArtistModel artistModel;

        private List<SongModel> songs = new List<SongModel>();

        private List<ProducerModel> producerModels = new List<ProducerModel>();

        private List<RecordLabelModel> recordLabels = new List<RecordLabelModel>();

        private AlbumModel selectedAlbum;

        public MainView(MainController controller)
        {
            InitializeComponent();
            activeUser = controller.ActiveUser;
            login = new LogInView(RegisterLogin);
            login.Show();
        }

        private void RegisterLogin(UserModel user)
        {
            activeUser = user;
            if (activeUser == null)
                uxUserLabel.Text = "Not logged in";
            else
                uxUserLabel.Text = "Logged in as: " + activeUser.Name;
        }

        private void uxLookUpText_KeyDown(object sender, KeyEventArgs e)
        {
            //check if enter key pressed and run search
            //uxSongList.DataSource = test.Songs;
            //uxProducerList.DataSource = test.Producers;
            //uxPersonList.DataSource = members;
            //uxRecordLabelList.DataSource = recordLabels;
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
