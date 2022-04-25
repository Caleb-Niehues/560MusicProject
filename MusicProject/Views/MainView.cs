﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicProject.Controllers;
using MusicProject.Models;
using MusicProject.Mic;
using System.Windows.Forms;

namespace MusicProject.Views
{
    public delegate void UpdateUser(UserModel user);
    public partial class MainView : Form
    {
        #region Test Album/Load Order
        private ReviewModel reviewModel = null;
        private UserModel user;

        private List<PersonModel> members = new List<PersonModel>();
        private ArtistModel artistModel;

        private List<SongModel> songs = new List<SongModel>();

        private List<ProducerModel> producerModels = new List<ProducerModel>();

        private List<RecordLabelModel> recordLabels = new List<RecordLabelModel>();

        private AlbumModel test;

        public void TestInitialization()
        {
            members.Add(new PersonModel("Kendrick Lamar Duckworth", new DateTime(1987, 6, 17), null, "Compton, CA, USA"));
            artistModel = new ArtistModel("Kendrick Lamar", members);//could possibly use solo query to match name

            #region Adding Songs
            //songs.Add(new SongModel("Wesley's Theory", test, Genre.HipHop, new TimeSpan(0, 4, 47)));
            //songs.Add(new SongModel("For Free? (Interlude)", test, Genre.HipHop, new TimeSpan(0, 2, 10)));
            //songs.Add(new SongModel("King Kunta", test, Genre.HipHop, new TimeSpan(0, 3, 54)));
            //songs.Add(new SongModel("Institutionalized", test, Genre.HipHop, new TimeSpan(0, 4, 31)));
            //songs.Add(new SongModel("These Walls", test, Genre.HipHop, new TimeSpan(0, 5, 0)));
            //songs.Add(new SongModel("U", test, Genre.HipHop, new TimeSpan(0, 4, 28)));
            //songs.Add(new SongModel("Alright", test, Genre.HipHop, new TimeSpan(0, 3, 39)));
            //songs.Add(new SongModel("For Sale? (Interlude)", test, Genre.HipHop, new TimeSpan(0, 4, 51)));
            //songs.Add(new SongModel("Momma", test, Genre.HipHop, new TimeSpan(0, 4, 43)));
            //songs.Add(new SongModel("Hood Politics", test, Genre.HipHop, new TimeSpan(0, 4, 52)));
            //songs.Add(new SongModel("How Much a Dollar Cost", test, Genre.HipHop, new TimeSpan(0, 4, 21)));
            //songs.Add(new SongModel("Complexion (A Zulu Love)", test, Genre.HipHop, new TimeSpan(0, 4, 23)));
            //songs.Add(new SongModel("The Blacker the Berry", test, Genre.HipHop, new TimeSpan(0, 5, 28)));
            //songs.Add(new SongModel("You Ain't Gotta Lie", test, Genre.HipHop, new TimeSpan(0, 4, 1)));
            //songs.Add(new SongModel("I", test, Genre.HipHop, new TimeSpan(0, 5, 36)));
            //songs.Add(new SongModel("Mortal Man", test, Genre.HipHop, new TimeSpan(0, 12, 7)));
            #endregion

            recordLabels.Add(new RecordLabelModel("TDE", new DateTime(2004, 1, 1), null, "Carson, CA, USA"));
            recordLabels.Add(new RecordLabelModel("Aftermath Entertainment", new DateTime(1996, 3, 22), null, "Santa Monica, CA, USA"));
            recordLabels.Add(new RecordLabelModel("Interscope Records", new DateTime(1990, 1, 1), null, "Santa Monica, CA, USA"));

            #region Adding Producers
            producerModels.Add(new ProducerModel("Boi-1da"));
            producerModels.Add(new ProducerModel("Flippa"));
            producerModels.Add(new ProducerModel("Flying Lotus"));
            producerModels.Add(new ProducerModel("Knxledge"));
            producerModels.Add(new ProducerModel("KOZ"));
            producerModels.Add(new ProducerModel("Larrance"));
            producerModels.Add(new ProducerModel("Dopson"));
            producerModels.Add(new ProducerModel("LoveDragon"));
            producerModels.Add(new ProducerModel("Pharrel Williams"));
            producerModels.Add(new ProducerModel("Rahki"));
            producerModels.Add(new ProducerModel("Sounwave"));
            producerModels.Add(new ProducerModel("Tae Beast"));
            producerModels.Add(new ProducerModel("Taz Arnold"));
            producerModels.Add(new ProducerModel("Terrace Martin"));
            producerModels.Add(new ProducerModel("Thundercat"));
            producerModels.Add(new ProducerModel("Tommy Black"));
            producerModels.Add(new ProducerModel("Whoarei"));
            #endregion

            test = new AlbumModel("To Pimp A Butterfly", new DateTime(2015, 3, 15), artistModel, songs, new TimeSpan(0, 78, 51), producerModels, recordLabels, Certification.Platinum);
        }
        #endregion

        private void RegisterLogin(UserModel user)
        {
            uxUserLabel.Text = "Logged in as: " + user.Name;
        }

        public LogInView login;
        public DatabaseProxy proxy;
        public CheckCredentials check;
        public MainView(MainController controller)
        {
            InitializeComponent();
            user = controller.ActiveUser;
            //TestInitialization();
        }

        private void uxLookUpText_KeyDown(object sender, KeyEventArgs e)
        {
            //check if enter key pressed and run search
            uxSongList.DataSource = test.Songs;
            uxProducerList.DataSource = test.Producers;
            uxPersonList.DataSource = members;
            uxRecordLabelList.DataSource = recordLabels;
        }

        private void uxLogIn_Click(object sender, EventArgs e)
        {
            login = new LogInView(RegisterLogin);
            login.Show();
        }
    }
}
