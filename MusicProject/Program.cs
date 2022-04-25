using System;
using System.Configuration;
using System.Windows.Forms;
using MusicProject.Repositories;
using MusicProject.Views;
using MusicProject.Mic;

namespace MusicProject
{
    public delegate bool CheckCredentials(string password, string username, DatabaseProxy dbp);
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
            //var testRepo = new SqlUserRepo(testConnect);
            //var test = testRepo.CreateUser("Ashley Redy", "hunter2", 2);
            DatabaseProxy proxy = new DatabaseProxy();
            Application.Run(new MainView());
        }
    }
}
