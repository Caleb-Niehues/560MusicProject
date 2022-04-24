﻿using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace MusicProject.Repositories
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly string connectionString;

        public SqlUserRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public UserModel CreateUser(string name, string password, int weight)
        {
            // Verify parameters.
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(password));

            if (weight < 0 || weight > 100)
                throw new ArgumentException("The parameter cannot be between 0 and 100.", nameof(weight));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.CreateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);
                        command.Parameters.AddWithValue("Password", password);
                        command.Parameters.AddWithValue("Weight", weight);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        //var personId = (int)command.Parameters["PersonId"].Value;

                        return new UserModel(name, weight);
                    }
                }
            }
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
