using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly string connectionString;

        public SqlUserRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public UserModel CreateUser(string name, int weight, DateTime dateAdded)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string name, string password)
        {
            throw new NotImplementedException();
        }

        public bool LoginSuccesful(string name, string password, out UserModel user)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<UserModel> RetrieveSuperFans(string artistName)
        {
            throw new NotImplementedException();
        }

        public UserModel UpdatePassword(string name, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public UserModel UpdateUserName(string oldName, string newName, string password)
        {
            throw new NotImplementedException();
        }

        public UserModel UpdateWeight(string name, string password, int newWeight)
        {
            throw new NotImplementedException();
        }
    }
}
