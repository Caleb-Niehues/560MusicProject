using System;
using System.Configuration;
using System.Windows.Forms;
using MusicProject.Models;
using MusicProject.Repositories;
using MusicProject.Views;

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
            string testConnect = ConfigurationManager.ConnectionStrings["configConnectionCaleb"].ConnectionString;//just one call in maincontroller and pass throughout in actual practice
            var testRepo = new SqlUserRepo(testConnect);
            UserModel testUser;
            if (testRepo.FetchUser("3ero8x", "swordfish", out testUser));
            //testRepo.DeleteUser("Ashley Redy", "hunter2");
            Application.Run(new MainView()); //confirmed issue of needing to run - does this mean the powershell stuff is required?
        }
    }
}
