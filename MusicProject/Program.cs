﻿using System;
using System.Windows.Forms;
using MusicProject.Models;
using MusicProject.Views;
using MusicProject.Controllers;
using System.Collections.Generic;

namespace MusicProject
{
    public delegate UserModel CheckCredentials(string userName, string password);
    public delegate UserModel CreateUser(string userName, string password, int weight);
    public delegate ReviewModel CreateOrSaveReview(ReviewModel review, bool newRev);
    public delegate ArtistModel CreateArtist(string name);
    public delegate ProducerModel CreateProducer(string name);
    public delegate RecordLabelModel CreateLabel(string name, DateTime founded, DateTime? ended, string location);
    public delegate bool DeleteUser(string userName, string password);
    public delegate bool Search(string name);
    public delegate void UpdateSearch(IReadOnlyList<AlbumModel> albums, IReadOnlyList<ArtistModel> artists, IReadOnlyList<SongModel> songs, IReadOnlyList<PersonModel> people, IReadOnlyList<ProducerModel> producers, IReadOnlyList<RecordLabelModel> recordLabels);
    public delegate IReadOnlyList<ReviewModel> GetReviews(AlbumModel album);
    public delegate ReviewModel FetchReview(string userName, string albumTitle);

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var controller = new MainController();
            var view = new MainView(controller);
            LogInView.InitializeDelegates(controller.CredentialCheck, controller.CreateUser, controller.DeleteUser);
            ReviewView.InitializeDelegates(controller.GetReviews, controller.FetchReview, controller.CreateOrSaveReview);
            AddAlbumView.InitializeDelegates();
            AddArtistView.InitializeDelegates(controller.CreateArtist);
            AddProducerView.InitializeDelegates(controller.CreateProducer);
            AddRecordLabelView.InitializeDelegates(controller.CreateLabel);
            AddSongView.InitializeDelegates();
            controller.InitializeDelegates(view.RegisterSearch);

            Application.Run(view);//confirmed issue of needing to run - does this mean the powershell stuff is required?
        }
    }
}
