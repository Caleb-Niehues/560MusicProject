using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;
using MusicProject.Models;

namespace MusicProject.Repositories
{
    public class SqlArtistRepo : IArtistRepo
    {
        private readonly string connectionString;

        public SqlArtistRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ArtistModel CreateArtist(string name, List<PersonModel> members)
        {
            // Verify parameters.
            //if (string.IsNullOrWhiteSpace(name))
            //    throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.AddArtist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("ArtistName", name);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        //var personId = (int)command.Parameters["PersonId"].Value;

                        //return new Person(personId, firstName, lastName, email);
                    }
                }
            }

            return new ArtistModel(name, members);
        }

        public IReadOnlyList<ArtistModel> FetchArtist(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.FetchArtist", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateFetchArtist(reader);
                    }
                }
            }
        }

        private IReadOnlyList<ArtistModel> TranslateFetchArtist(SqlDataReader reader)
        {
            var artists = new List<ArtistModel>();

            var artistNameOrdinal = reader.GetOrdinal("ArtistName");
            while (reader.Read())
            {
                artists.Add(new ArtistModel(reader.GetString(artistNameOrdinal), null));
            }
            return artists;
        }

        public IReadOnlyList<ArtistModel> GetArtistsInWindow(string labelName, DateTime startYear, DateTime endYear)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.GetArtistsInWindow", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("LabelName", labelName);
                        command.Parameters.AddWithValue("StartYear", startYear);
                        command.Parameters.AddWithValue("EndYear", endYear);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateGetArtistsInWindow(reader);
                    }
                }
            }
        }

        private IReadOnlyList<ArtistModel> TranslateGetArtistsInWindow(SqlDataReader reader)
        {
            var artists = new List<ArtistModel>();

            var artistNameOrdinal = reader.GetOrdinal("ArtistName");

            while (reader.Read())
            {
                artists.Add(new ArtistModel(reader.GetString(artistNameOrdinal), null));
            }

            return artists;
        }

        /// <summary>
        /// test - don't think this is actually necessary
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<ArtistModel> RetrieveArtists()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("MusicProject.RetrieveArtists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateArtists(reader);
                }
            }
        }

        /// <summary>
        /// helper method for Retrieval
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private IReadOnlyList<ArtistModel> TranslateArtists(SqlDataReader reader)
        {
            var artists = new List<ArtistModel>();

            var artistIdOrdinal = reader.GetOrdinal("ArtistId");
            var artistNameOrdinal = reader.GetOrdinal("ArtistName");

            while (reader.Read())
            {
                artists.Add(new ArtistModel(reader.GetString(artistNameOrdinal), null));
            }

            return artists;
        }
    }
}
