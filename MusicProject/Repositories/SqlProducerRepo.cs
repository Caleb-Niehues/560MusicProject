using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace MusicProject.Repositories
{
    public class SqlProducerRepo : IProducerRepo
    {
        private readonly string connectionString;

        public SqlProducerRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ProducerModel CreateProducer(string name)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.CreateProducer", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        return new ProducerModel(name);
                    }
                }
            }
        }

        public ProducerModel FetchProducer(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.FetchProducer", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            var temp = TranslateProducer(reader);
                            if (temp.Count == 1) return temp[0];
                            return null;
                        }
                    }
                }
            }
        }

        public IReadOnlyList<ProducerModel> RetrieveProducersByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.RetrieveProducersByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            return TranslateProducer(reader);
                        }
                    }
                }
            }
        }

        public IReadOnlyList<ProducerModel> RetrieveProducersByAlbum(string albumTitle)
        {
            if (string.IsNullOrWhiteSpace(albumTitle))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(albumTitle));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.RetrieveProducers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("AlbumTitle", albumTitle);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            return TranslateProducer(reader);
                        }
                    }
                }
            }
        }

        private IReadOnlyList<ProducerModel> TranslateProducer(SqlDataReader reader)
        {
            var producers = new List<ProducerModel>();

            var recordLabelNameOrdinal = reader.GetOrdinal("ProducerName");
            while (reader.Read())
            {
                producers.Add(new ProducerModel(reader.GetString(recordLabelNameOrdinal)));
            }
            return producers;
        }
    }
}
