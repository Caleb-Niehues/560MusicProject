using System;
using System.Windows.Forms;
using MusicProject.Models;
using MusicProject.Views;
using MusicProject.Controllers;
using System.Collections.Generic;

namespace MusicProject
{
    public delegate UserModel CheckCredentials(string userName, string password);
    public delegate UserModel CreateUser(string userName, string password, int weight);
    public delegate bool DeleteUser(string userName, string password);
    public delegate bool Search(string name);
    public delegate void UpdateSearch(IReadOnlyList<AlbumModel> albums, IReadOnlyList<ArtistModel> artists, IReadOnlyList<SongModel> songs, IReadOnlyList<PersonModel> people, IReadOnlyList<ProducerModel> producers, IReadOnlyList<RecordLabelModel> recordLabels);
    public delegate IReadOnlyList<ReviewModel> GetReviews(AlbumModel album);
    public delegate ReviewModel FetchReview(string userName, string albumTitle);
    public delegate ReviewModel CreateOrSaveReview(ReviewModel review, bool newRev);

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
            controller.InitializeDelegates(view.RegisterSearch);

            Application.Run(view);//confirmed issue of needing to run - does this mean the powershell stuff is required?
        }
    }
}
