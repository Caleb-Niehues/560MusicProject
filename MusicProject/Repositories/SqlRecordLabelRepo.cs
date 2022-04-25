using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace MusicProject.Repositories
{
    public class SqlRecordLabelRepo : IRecordLabelRepo
    {
        private readonly string connectionString;

        public SqlRecordLabelRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public RecordLabelModel CreateRecordLabel(string name, DateTime dateFounded, DateTime? dateClosed, string location)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.CreateRecordLabel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);
                        command.Parameters.AddWithValue("DateFounded", dateFounded);
                        command.Parameters.AddWithValue("DateClosed", dateClosed);
                        command.Parameters.AddWithValue("Location", location);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        //var personId = (int)command.Parameters["PersonId"].Value;

                        return new RecordLabelModel(name, dateFounded, dateClosed, location);
                    }
                }
            }
        }

        public RecordLabelModel FetchRecordLabel(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.FetchRecordLabel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateFetchRecordLabel(reader);
                    }
                }
            }
        }

        private RecordLabelModel TranslateFetchRecordLabel(SqlDataReader reader)
        {
            var songs = new List<SongModel>();

            var recordLabelNameOrdinal = reader.GetOrdinal("RecordLabelName");
            var dateFoundedOrdinal = reader.GetOrdinal("DateFounded");
            var dateClosedOrdinal = reader.GetOrdinal("DateClosed");
            var recordLabelLocationOrdinal = reader.GetOrdinal("RecordLabelLocation");

            return new RecordLabelModel(reader.GetString(recordLabelNameOrdinal), reader.GetDateTime(dateFoundedOrdinal),
                reader.GetDateTime(dateClosedOrdinal), reader.GetString(recordLabelLocationOrdinal));
        }
    }
}
