using MusicProject.Models;
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

        /// <summary>
        /// perhaps a return is necessary to validate user deletion
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public void DeleteUser(string name, string password)
        {
            //need to double dip to check password match


            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.DeleteUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);
                        command.Parameters.AddWithValue("Password", password);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();
                    }
                }
            }
        }

        private bool checkPassword(string name, string password)
        {
            bool success = false;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("MusicProject.FetchPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("Name", name);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        var passwordOrdinal = reader.GetOrdinal("Password");

                        string test;

                        while (reader.Read())
                        {
                            test = reader.GetString(passwordOrdinal);

                            success = test.Equals(password);
                        }
                    }
                }
            }

            return success;
        }

        public bool FetchUser(string name, string password, out UserModel user)
        {
            bool success = checkPassword(name, password);
            user = null;

            if (success)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.FetchUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            var weightOrdinal = reader.GetOrdinal("UserWeight");
                            var dateAddedOrdinal = reader.GetOrdinal("DateAdded");

                            while (reader.Read())
                            {
                                user = new UserModel(name,
                                    reader.GetInt32(weightOrdinal),
                                    reader.GetDateTime(dateAddedOrdinal));
                            }
                        }
                    }
                }
            }

            return success;
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
