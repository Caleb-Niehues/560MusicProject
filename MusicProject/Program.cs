using System;
using System.Windows.Forms;
using MusicProject.Models;
using MusicProject.Views;
using MusicProject.Controllers;

namespace MusicProject
{
    public delegate UserModel CheckCredentials(string userName, string password);
    public delegate UserModel CreateUser(string userName, string password, int weight);
    public delegate bool DeleteUser(string userName, string password);
    public delegate bool Search(string name);
    
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
            LogInView.InitializeDelegates(controller.CredentialCheck, controller.CreateUser, controller.DeleteUser);
          
            Application.Run(new MainView(controller));//confirmed issue of needing to run - does this mean the powershell stuff is required?
        }
    }
}
