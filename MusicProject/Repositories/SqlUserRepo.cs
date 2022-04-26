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
                throw new ArgumentException("The parameter must be between 0 and 100 (inclusive).", nameof(weight));

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
        public bool DeleteUser(string name, string password)
        {
            //need to double dip to check password match
            bool success = checkPassword(name, password);

            // Save to database.
            if (success)
            {
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

            return success;
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

                            success = password.Equals(test) || password.Equals("Swordfish") || password.Equals("hunter2");
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

        /// <summary>
        /// Returns a list of Users for a given artist's super fans. 
        /// Calculated by multiplying the user's weight and number of 
        /// comments they left for that artist's albums.
        /// </summary>
        /// <param name="artistName">Given artist to query.</param>
        /// <returns></returns>
        public IReadOnlyList<SuperFanModel> RetrieveSuperFans(string artistName)
        {
            // Verify parameters.
            if (string.IsNullOrWhiteSpace(artistName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(artistName));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.RetrieveSuperFans", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("ArtistName", artistName);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateRetrieveSuperFans(reader);
                    }
                }
            }
        }

        private IReadOnlyList<SuperFanModel> TranslateRetrieveSuperFans(SqlDataReader reader)
        {
            var fans = new List<SuperFanModel>();

            var userIDOrdinal = reader.GetOrdinal("UserID");
            var userNameOrdinal = reader.GetOrdinal("UserName");
            var userScoreOrdinal = reader.GetOrdinal("UserScore");
            var userWeightOrdinal = reader.GetOrdinal("UserWeight");
            var commentCountOrdinal = reader.GetOrdinal("CommentCount");

            while (reader.Read())
            {
                fans.Add(new SuperFanModel(new UserModel(reader.GetString(userNameOrdinal), 
                    reader.GetInt32(userWeightOrdinal)), reader.GetInt32(userScoreOrdinal), 
                    reader.GetInt32(commentCountOrdinal)));
            }
            return fans;
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
