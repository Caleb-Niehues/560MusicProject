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

        public void AddArtist(string name)
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

                        var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        var personId = (int)command.Parameters["PersonId"].Value;

                        //return new Person(personId, firstName, lastName, email);
                    }
                }
            }
        }

        public IReadOnlyList<ArtistModel> RetrieveArtists()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("MusicProject.RetrieveArtists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslatePersons(reader);
                }
            }
        }

        private IReadOnlyList<ArtistModel> TranslatePersons(SqlDataReader reader)
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
