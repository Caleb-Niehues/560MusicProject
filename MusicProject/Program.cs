using System;
using System.Windows.Forms;
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
            DatabaseProxy proxy = new DatabaseProxy();
            Application.Run(new MainView());
        }
    }
}
