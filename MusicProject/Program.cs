using System;
using System.Configuration;
using System.Windows.Forms;
using MusicProject.Models;
using MusicProject.Repositories;
using MusicProject.Views;
using MusicProject.Mic;
using MusicProject.Controllers;

namespace MusicProject
{
    public delegate UserModel CheckCredentials(string userName, string password);
    public delegate void SuccessfulLogin();
    
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
            MainController test = new MainController(testConnect);
            LogInView.InitializeDelegates(test.CredentialCheck);
            //var testRepo = new SqlUserRepo(testConnect);
            //UserModel testUser;
            //if (testRepo.FetchUser("3ero8x", "meestamastae3", out testUser));
            DatabaseProxy proxy = new DatabaseProxy();
          
            Application.Run(new MainView());//confirmed issue of needing to run - does this mean the powershell stuff is required?
        }
    }
}
