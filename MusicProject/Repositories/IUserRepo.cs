using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public interface IUserRepo
    {
        /// <summary>
        /// Checks if a given username and password can log into the database, also returns the user in the event of success - acts as Fetch
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        bool FetchUser(string name, string password, out UserModel user);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="dateAdded"></param>
        /// <returns></returns>
        UserModel CreateUser(string name, string password, int weight);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        UserModel UpdateUserName(string oldName, string newName, string password);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        UserModel UpdatePassword(string name, string oldPassword, string newPassword);

        /// <summary>
        /// likely doesn't need shown or even implemented - honestly the weight system might be dumb
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="newWeight"></param>
        /// <returns></returns>
        UserModel UpdateWeight(string name, string password, int newWeight);

        /// <summary>
        /// user must input password, FLAGS as deleted, does NOT actually delete data
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        void DeleteUser(string name, string password);

        /// <summary>
        /// Gets the most active reviewers of a given artist
        /// </summary>
        /// <param name="artistName"></param>
        /// <returns></returns>
        IReadOnlyList<UserModel> RetrieveSuperFans(string artistName);
    }
}
