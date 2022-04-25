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

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        //var personId = (int)command.Parameters["PersonId"].Value;

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

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateFetchProducer(reader);
                    }
                }
            }
        }

        private ProducerModel TranslateFetchProducer(SqlDataReader reader)
        {
            var recordLabelNameOrdinal = reader.GetOrdinal("ProducerName");
            while (reader.Read())
            {
                return new ProducerModel(reader.GetString(recordLabelNameOrdinal));
            }
            return null;
        }
    }
}
