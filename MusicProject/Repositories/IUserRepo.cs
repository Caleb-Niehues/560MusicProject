using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public interface IUserRepo
    {
        /// <summary>
        /// Checks if a given username and password can log into the database, also returns the user in the event of success
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        bool LoginSuccesful(string name, string password, out UserModel user);

        UserModel CreateUser();

        /// <summary>
        /// Gets the most active reviewers of a given artist
        /// </summary>
        /// <param name="artistName"></param>
        /// <returns></returns>
        IReadOnlyList<UserModel> RetrieveSuperFans(string artistName);
    }
}
