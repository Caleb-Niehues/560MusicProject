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
                        command.Parameters.AddWithValue("DateClosed", dateClosed ?? (object)DBNull.Value);
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

        public IReadOnlyList<RecordLabelModel> FetchRecordLabel(string name)
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

        private IReadOnlyList<RecordLabelModel> TranslateFetchRecordLabel(SqlDataReader reader)
        {
            var recordLabels = new List<RecordLabelModel>();

            var recordLabelNameOrdinal = reader.GetOrdinal("RecordLabelName");
            var dateFoundedOrdinal = reader.GetOrdinal("DateFounded");
            var dateClosedOrdinal = reader.GetOrdinal("DateClosed");
            var recordLabelLocationOrdinal = reader.GetOrdinal("RecordLabelLocation");
            
            while (reader.Read())
            {
                if (!reader.IsDBNull(dateClosedOrdinal))
                {
                    recordLabels.Add(new RecordLabelModel(reader.GetString(recordLabelNameOrdinal), reader.GetDateTime(dateFoundedOrdinal),
                        reader.GetDateTime(dateClosedOrdinal), reader.GetString(recordLabelLocationOrdinal)));
                }
                else
                {
                    Nullable<DateTime> d = null;
                    recordLabels.Add(new RecordLabelModel(reader.GetString(recordLabelNameOrdinal), reader.GetDateTime(dateFoundedOrdinal),
                       d, reader.GetString(recordLabelLocationOrdinal)));
                }                
            }

            return recordLabels;
        }

        /// <summary>
        /// Gets the album within a certain record label
        /// 
        /// </summary>
        /// <param name="recordLabelName"></param>
        /// <param name="startYear"></param>
        /// <param name="endYear"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public AlbumsWithRecordLabelModel GetAlbumsWithRecordLabel(string recordLabelName, DateTime startYear, DateTime endYear)
        {
            if (string.IsNullOrWhiteSpace(recordLabelName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(recordLabelName));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.AlbumsWithRecordLabel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("RecordLabelName", recordLabelName);
                        command.Parameters.AddWithValue("StartYear", startYear);
                        command.Parameters.AddWithValue("EndYear", endYear);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateGetAlbumsWithRecordLabel(reader);
                    }
                }
            }
        }
        private AlbumsWithRecordLabelModel TranslateGetAlbumsWithRecordLabel(SqlDataReader reader)
        {
            var recordLabelNameOrdinal = reader.GetOrdinal("RecordLabelName");
            var albumCountOrdinal = reader.GetOrdinal("AlbumCount");
            var certificationCountOrdinal = reader.GetOrdinal("CertificationCount");

            while (reader.Read())
            {
                return new AlbumsWithRecordLabelModel(reader.GetString(recordLabelNameOrdinal),
                    reader.GetInt32(albumCountOrdinal), reader.GetInt32(certificationCountOrdinal));
            }
            return null;
        }
    }
}
