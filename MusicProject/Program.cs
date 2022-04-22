using System;
using System.Configuration;
using System.Windows.Forms;
using MusicProject.Repositories;
using MusicProject.Views;
//using MusicProject.Repositories;

namespace MusicProject
{
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
            string testConnect = ConfigurationManager.ConnectionStrings["configConnection"].ConnectionString;//just one call in maincontroller and pass throughout in actual practice
            var testRepo = new SqlArtistRepo(testConnect);
            var test = testRepo.RetrieveArtists();
            Application.Run(new MainView());
        }
    }
}
