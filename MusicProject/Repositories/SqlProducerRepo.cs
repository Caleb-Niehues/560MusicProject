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

        public IReadOnlyList<ProducerModel> FetchProducer(string name)
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
                            return TranslateFetchProducer(reader);
                    }
                }
            }
        }

        private IReadOnlyList<ProducerModel> TranslateFetchProducer(SqlDataReader reader)
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
