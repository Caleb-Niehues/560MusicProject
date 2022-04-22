using System;
using System.Windows.Forms;
using MusicProject.Views;
using MusicProject.Repositories;

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
            var test = new SqlAlbumRepo("hmm");
            Application.Run(new MainView());
        }
    }
}
