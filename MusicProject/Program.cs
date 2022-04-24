using System;
using System.Configuration;
using System.Windows.Forms;
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
            //var testRepo = new SqlUserRepo(testConnect);
            //var test = testRepo.CreateUser("Ashley Redy", "hunter2", 2);
            Application.Run(new MainView());
        }
    }
}
